using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Manning.MyPhotoAlbum
{
	/// <summary>
	/// The Photograph class represents a
	/// photographic image stored in the
	/// file system.
	/// </summary>
	public class Photograph
	{
		private string _fileName;
		private Bitmap _bitmap;

		private string _caption = "";
		private string _photographer = "";
		private DateTime _dateTaken = DateTime.Now;
		private string _notes = "";
		private bool _hasChanged = true;

		public Photograph(string fileName)
		{
			_fileName = fileName;
			_bitmap = null;

			_caption = System.IO.Path.
				GetFileNameWithoutExtension(fileName);
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

		public bool HasChanged
		{
			get { return _hasChanged; }
			internal set { _hasChanged = value; }
		}

		public string Caption
		{
			get { return _caption; }
			set
			{
				if (_caption != value)
				{
					_caption = value;
					HasChanged = true;
				}
			}
		}

		public string Photographer
		{
			get { return _photographer; }
			set
			{
				if (_photographer != value)
				{
					_photographer = value;
					HasChanged = true;
				}
			}
		}

		public DateTime DateTaken
		{
			get { return _dateTaken; }
			set
			{
				if (_dateTaken != value)
				{
					_dateTaken = value;
					HasChanged = true;
				}
			}
		}

		public string Notes
		{
			get { return _notes; }
			set
			{
				if (_notes != value)
				{
					_notes = value;
					HasChanged = true;
				}
			}
		}

	}
}
