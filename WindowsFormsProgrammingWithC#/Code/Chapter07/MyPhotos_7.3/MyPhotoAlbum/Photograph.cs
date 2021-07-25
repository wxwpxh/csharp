using System;
using System.Drawing;

namespace Manning.MyPhotoAlbum
{
	/// <summary>
	/// The Photograph class represents a single photo and its properties.
	/// </summary>
	public class Photograph : IDisposable
	{
		private string _fileName;
		private Bitmap _bitmap;
		private static Bitmap _invalidImageBitmap = null;
			
		public Photograph(string fileName)
		{
			_fileName = fileName;
			_bitmap = null;
		}

		public void Dispose()
		{
			if (_bitmap != null && _bitmap != InvalidPhotoImage)
			{
				_bitmap.Dispose();
			}

			_bitmap = null;
		}

		public string FileName
		{
			get { return _fileName; }
		}

		public Bitmap Image
		{
			get
			{
				if (_bitmap == null)
				{
					try
					{
						_bitmap = new Bitmap(_fileName);
					}
					catch
					{
						_bitmap = InvalidPhotoImage;
					}
				}

				return _bitmap;
			}
		}

		public static Bitmap InvalidPhotoImage
		{
			get 
			{
				if (_invalidImageBitmap == null)
				{
					// Create the "bad photo" bitmap
					Bitmap bm = new Bitmap(100, 100);
					Graphics g = Graphics.FromImage(bm);
					g.Clear(Color.WhiteSmoke);

					// Draw a red X
					Pen p = new Pen(Color.Red, 5);
					g.DrawLine(p, 0, 0, 100, 100);
					g.DrawLine(p, 100, 0, 0, 100);

					_invalidImageBitmap = bm;
				}

				return _invalidImageBitmap;
			}
		}

		public bool IsImageValid
		{
			get
			{
				return (_bitmap != InvalidPhotoImage);
			}
		}

		// Object class overrides
		public override bool Equals(object obj)
		{
			if (obj is Photograph)
			{
				Photograph p = (Photograph)obj;

				return (_fileName.ToLower().Equals(p.FileName.ToLower()));
			}

			return false;
		}

		public override int GetHashCode()
		{
			return this.FileName.GetHashCode();
		}

		public override string ToString()
		{
			return this.FileName;
		}

		// Other methods
		public Rectangle ScaleToFit(Rectangle targetArea)
		{
			Rectangle result = new Rectangle(targetArea.Location, targetArea.Size);

			// Determine best fit: width or height
			if (result.Height * Image.Width > result.Width * Image.Height)
			{
				// Final width should match target, determine and center height
				result.Height = result.Width * Image.Height / Image.Width;
				result.Y += (targetArea.Height - result.Height) / 2;
			}
			else
			{
				// Final height should match target, determine and center width
				result.Width = result.Height * Image.Width / Image.Height;
				result.X += (targetArea.Width - result.Width) / 2;
			}

			return result;
		}

		// end of Photograph class
	}
}