using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorTabApp
{
	public partial class ColorTabControl : TabControl
	{
		public ColorTabControl()
		{
			base.DrawMode = TabDrawMode.OwnerDrawFixed;
		}

		private Color _tabColor;
		private Color _selTabColor;

		public new TabDrawMode DrawMode
		{
			get { return TabDrawMode.OwnerDrawFixed; }
		}

		public Color TabColor
		{
			get { return _tabColor; }
			set { _tabColor = value; }
		}

		public Color SelectedTabColor
		{
			get { return _selTabColor; }
			set { _selTabColor = value; }
		}

		protected override void OnDrawItem(DrawItemEventArgs e)
		{
			base.OnDrawItem(e);
			TabPage page = TabPages[e.Index];
			TabControl tab = page.Parent as TabControl;
			if (tab == null || page == null)
				throw new ArgumentException("not a tab control");

			Brush b;
			int offset = 0;
			if (e.Index == SelectedIndex)
				b = new SolidBrush(SelectedTabColor);
			else
			{
				b = new SolidBrush(TabColor);
				offset = -2;
			}

			StringFormat sf = new StringFormat();
			sf.LineAlignment = StringAlignment.Center;
			sf.Alignment = StringAlignment.Center;

			// Get any image for this page.
			Image img = GetPageImage(tab, page);
			Rectangle targetImg = new Rectangle();
			if (img != null)
			{
				// Target location for image
				// Ideally we should check that the image actually fits in the tab
				// We take the shortcut of assuming that the image is okay
				targetImg = new Rectangle(e.Bounds.Left + page.Margin.Left,
						e.Bounds.Top + page.Margin.Top,
						img.Width, img.Height);
			}

			if (Alignment == TabAlignment.Right)
			{
				if (img != null)
				{
					// Orient the image for a right tab
					img.RotateFlip(RotateFlipType.Rotate90FlipNone);

					targetImg.Offset(offset, 0);
					e.Graphics.DrawImage(img, targetImg);
					offset += page.Margin.Bottom + img.Height;
				}

				// Adjust text location
				Rectangle txtTarget = new Rectangle(
					e.Bounds.X, e.Bounds.Y + offset,
					e.Bounds.Width,
					e.Bounds.Height - offset);

				sf.FormatFlags = StringFormatFlags.DirectionVertical;
				e.Graphics.DrawString(page.Text, e.Font, b,
					txtTarget, sf);
			}
			else if (Alignment == TabAlignment.Left)
			{
				if (img != null)
				{
					// Orient the image for a right tab
					img.RotateFlip(RotateFlipType.Rotate270FlipNone);

					// Draw the image in the target location
					targetImg.X += offset;
					targetImg.Y = e.Bounds.Bottom - page.Margin.Bottom - img.Height;
					e.Graphics.DrawImage(img, targetImg);
					offset += page.Margin.Bottom + img.Height;
				}

				sf.FormatFlags = StringFormatFlags.DirectionVertical;

				Bitmap bmp = new Bitmap(e.Bounds.Width, e.Bounds.Height - offset);
				Graphics g = Graphics.FromImage(bmp);
				g.DrawString(page.Text, e.Font, b,
					bmp.Width / 2 - 1, bmp.Height / 2 - 1, sf);
				g.Dispose();

				// Adjust text location
				Rectangle txtTarget = new Rectangle(
					e.Bounds.X, e.Bounds.Y,
					bmp.Width,
					bmp.Height);

				bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
				e.Graphics.DrawImage(bmp, txtTarget);
			}
			else // Top or Bottom alignment
			{
				if (img != null)
				{
					targetImg.Offset(0, offset);
					e.Graphics.DrawImage(img, targetImg);
					offset += page.Margin.Right + img.Width;
				}

				Rectangle txtTarget = new Rectangle(
					e.Bounds.X + offset, e.Bounds.Y,
					e.Bounds.Width - offset,
					e.Bounds.Height);
				e.Graphics.DrawString(page.Text, e.Font, b,
					txtTarget, sf);
			}
		}

		private Image GetPageImage(TabControl tab, TabPage page)
		{
			Image result = null;
			if (tab.ImageList != null)
			{
				if (!String.IsNullOrEmpty(page.ImageKey))
					result = tab.ImageList.Images[page.ImageKey];
				else if (page.ImageIndex >= 0)
					result = tab.ImageList.Images[page.ImageIndex];
			}

			return result;
		}

	}
}