using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Manning.MyPhotoControls
{
	public class ScrollablePictureBox : PictureBox
	{
		public event ScrollEventHandler Scroll;
		
		private bool _allowScrollBars = true;
		private HScrollBar _hbar = new HScrollBar();
		private VScrollBar _vbar = new VScrollBar();
		private Control _vbarContainer = new Control();

		private HScrollBar HBar { get { return _hbar; } }
		private VScrollBar VBar { get { return _vbar; } }
		private Control VContainer { get { return _vbarContainer; } }

		public ScrollablePictureBox()
		{
			// Initialize horizontal scroll bar
			HBar.Visible = false;
			HBar.Dock = DockStyle.Bottom;
			HBar.Minimum = 0;
			HBar.Maximum = 1000;
			HBar.Scroll += HandleScroll;

			// Initialize vertical scroll bar container
			VContainer.Visible = false;
			VContainer.Width = VBar.Width;
			VContainer.Height = Height;
			VContainer.Dock = DockStyle.Right;

			// Initialize vertical scroll bar
			VBar.Top = 0;
			VBar.Left = 0;
			VBar.Height = VContainer.Height - HBar.Height;
			VBar.Anchor = AnchorStyles.Top
							| AnchorStyles.Bottom
							| AnchorStyles.Left
							| AnchorStyles.Right;
			VBar.Minimum = 0;
			VBar.Maximum = 1000;

			VBar.Scroll += HandleScroll;
			VContainer.Controls.Add(VBar);

			Controls.Add(HBar);
			Controls.Add(VContainer);

			DoubleBuffered = true;
		}

		public bool AllowScrollBars
		{
			get { return _allowScrollBars; }
			set
			{
				if (_allowScrollBars != value)
				{
					// Force a redraw when value changes
					_allowScrollBars = value;
					Invalidate();
				}
			}
		}

		protected virtual void OnScroll(ScrollEventArgs e)
		{
			if (Scroll != null)
				Scroll(this, e);
		}

		protected void HandleScroll(object sender, ScrollEventArgs e)
		{
			Refresh();
			OnScroll(e);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			if (Image != null && (HBar.Visible || VContainer.Visible))
				DrawImage(e.Graphics);
		}

		private void DrawImage(Graphics g)
		{
			Rectangle targetRect = new Rectangle(0, 0,
				Math.Min(Right - VBar.Width, Image.Width),
				Math.Min(Bottom - HBar.Height,
				Image.Height));

			Rectangle sourceRect = new Rectangle(HBar.Value, VBar.Value,
				Math.Min(Right - VBar.Width, Image.Width),
				Math.Min(Bottom - HBar.Height, Image.Height));

			if (SizeMode == PictureBoxSizeMode.CenterImage)
			{
				Point p = new Point(0, 0);
				if (Right - VBar.Width > Image.Width)
					p.X = Math.Max((ClientSize.Width - targetRect.Width) / 2, 0);
				if (Bottom - HBar.Height > Image.Height)
					p.Y = Math.Max((ClientSize.Height - targetRect.Height) / 2, 0);

				targetRect.Offset(p);
			}

			g.DrawImage(Image, targetRect, sourceRect, GraphicsUnit.Pixel);
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);

			// Force redraw when scrolling
			if (ScrollingActive())
			{
				AdjustScrollBars();
				Refresh();
			}
		}

		private bool ScrollingActive()
		{
			if (Image == null || AllowScrollBars == false
				|| (SizeMode != PictureBoxSizeMode.CenterImage
				&& SizeMode != PictureBoxSizeMode.Normal))
			{
				HBar.Visible = false;
				VContainer.Visible = false;
			}
			else
			{
				// Show scroll bars if partial image shown
				HBar.Visible = Image.Width >= ClientSize.Width - VBar.Width;
				VContainer.Visible = Image.Height >= ClientSize.Height - HBar.Height;
			}

			return (HBar.Visible || VContainer.Visible);
		}

		private void AdjustScrollBars()
		{
			if (HBar.Visible)
			{
				int max = Image.Width - ClientSize.Width;
				HBar.LargeChange = Math.Max(max / 10, 1);
				HBar.SmallChange = Math.Max(max / 20, 1);
				HBar.Maximum = max + HBar.LargeChange;

				if (VBar.Visible)
					HBar.Maximum += VBar.Width;
			}

			if (VContainer.Visible)
			{
				if (HBar.Visible)
					VBar.Height = Height - HBar.Height;
				else
					VBar.Height = Height;

				int max = Image.Height - ClientSize.Height;
				VBar.LargeChange = Math.Max(max / 10, 1);
				VBar.SmallChange = Math.Max(max / 20, 1);
				VBar.Maximum = max + VBar.LargeChange;

				if (HBar.Visible)
					VBar.Maximum += HBar.Height;
			}
		}

		protected override void OnSizeModeChanged(EventArgs e)
		{
			base.OnSizeModeChanged(e);
			ResetScrollBars();
		}

		private void ResetScrollBars()
		{
			// Reset scroll values
			HBar.Value = 0;
			VBar.Value = 0;

			if (Image != null && ScrollingActive())
			{
				AdjustScrollBars();
				if (SizeMode == PictureBoxSizeMode.CenterImage)
				{
					HBar.Value = Math.Abs(Image.Width / 2 - ClientSize.Width / 2);
					VBar.Value = Math.Abs(Image.Height / 2 - ClientSize.Height / 2);
				}
			}

		}

		public new Image Image
		{
			get { return base.Image; }
			set
			{
				base.Image = value;
				ResetScrollBars();
			}
		}
	}
}
