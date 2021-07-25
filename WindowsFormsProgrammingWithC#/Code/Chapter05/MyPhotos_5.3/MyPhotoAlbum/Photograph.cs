using System;
using System.Drawing;

namespace Manning
{
	namespace MyPhotoAlbum
	{
		/// <summary>
		/// The Photograph class represents a single photo and its properties.
		/// </summary>
		public class Photograph
		{
			private string _fileName;
			private Bitmap _bitmap;
			
			public Photograph(string fileName)
			{
				_fileName = fileName;
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
						_bitmap = new Bitmap(_fileName);
					}
					return _bitmap;
				}
			}

			// end of Photograph class
		}
	}
}