using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlbumViewer
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
			Brush b;

			if (e.Index == SelectedIndex)
				b = new SolidBrush(SelectedTabColor);
			else
				b = new SolidBrush(TabColor);

			StringFormat sf = new StringFormat();
			sf.LineAlignment = StringAlignment.Center;
			sf.Alignment = StringAlignment.Center;

			if (Alignment == TabAlignment.Right)
			{
				sf.FormatFlags = StringFormatFlags.DirectionVertical;
				e.Graphics.DrawString(page.Text, e.Font, b, e.Bounds, sf);
			}
			else if (Alignment == TabAlignment.Left)
			{
				sf.FormatFlags = StringFormatFlags.DirectionVertical;
				Bitmap bmp = new Bitmap(e.Bounds.Width, e.Bounds.Height);

				Graphics g = Graphics.FromImage(bmp);
				g.DrawString(page.Text, e.Font, b,
					bmp.Width / 2 - 1, bmp.Height / 2 - 1, sf);
				g.Dispose();

				bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
				e.Graphics.DrawImage(bmp, e.Bounds);
			}
			else
			{
				e.Graphics.DrawString(page.Text, e.Font, b, e.Bounds, sf);
			}
		}

	}
}