using System;
using System.Collections;
using System.IO;

namespace Manning
{
	namespace MyPhotoAlbum
	{
		/// <summary>
		/// The PhotoAlbum class represents a collection of Photographs.
		/// </summary>
		public class PhotoAlbum : CollectionBase, IDisposable
		{
			private string _fileName = null;

			public PhotoAlbum()
			{
				// Nothing to do
			}

			public void Dispose()
			{
				foreach (Photograph photo in this)
				{
					photo.Dispose();
				}
			}

			// Default directory implementation
			static private string _defaultDir = null;
			static private bool _initializeDir = true;

			static private void InitDefaultDir()
			{
				if (_defaultDir == null)
				{
					_defaultDir = Environment.GetFolderPath(
						Environment.SpecialFolder.Personal);
					_defaultDir += @"\Albums";
				}

				Directory.CreateDirectory(_defaultDir);
			}

			static public string DefaultDir
			{
				get
				{
					if (_initializeDir)
					{
						InitDefaultDir();
						_initializeDir = false;
					}
					return _defaultDir;
				}
				set
				{
					_defaultDir = value;
					_initializeDir = true;
				}
			}

			// Implementation of ICollection interface
			public virtual bool IsSynchronized
			{
				get { return false; }
			}

			public virtual object SyncRoot
			{
				get { return List.SyncRoot; }
			}

			public virtual void CopyTo(Photograph[] array, int index)
			{
				List.CopyTo(array, index);
			}

			// Implementation of the ILIst interface
			public virtual bool IsFixedSize
			{
				get { return false; }
			}
			
			public virtual bool IsReadOnly
			{
				get { return false; }
			}

			public virtual Photograph this[int index]
			{
				get { return (Photograph)(List[index]); }
				set { List[index] = value; }
			}

			public virtual int Add(Photograph photo)
			{
				return List.Add(photo);
			}

			public virtual bool Contains(Photograph photo)
			{
				return List.Contains(photo);
			}

			public virtual int IndexOf(Photograph photo)
			{
				return List.IndexOf(photo);
			}
			
			public virtual void Insert(int index, Photograph photo)
			{
				List.Insert(index, photo);
			}

			public virtual void Remove(Photograph photo)
			{
				List.Remove(photo);
			}

			/// <summary>
			/// Tracks the current index position when displaying the album.
			/// </summary>
			private int _currentPos = 0;

			public int CurrentPosition
			{
				get { return _currentPos; }

				set
				{
					if (value <= 0)
					{
						_currentPos = 0;
					}
					else if (value >= this.Count)
					{
						_currentPos = this.Count - 1;
					}
					else
					{
						_currentPos = value;
					}
				}
			}

			protected override void OnClear()
			{
				_currentPos = 0;
				_fileName = null;
				this.Dispose();
				base.OnClear();
			}

			public Photograph CurrentPhoto
			{
				get
				{
					if (this.Count == 0)
						return null;

					return this[CurrentPosition];
				}
			}

			public bool CurrentNext()
			{
				if (CurrentPosition+1 < this.Count)
				{
					CurrentPosition ++;
					return true;
				}

				return false;
			}

			public bool CurrentPrev()
			{
				if (CurrentPosition > 0)
				{
					CurrentPosition --;
					return true;
				}

				return false;
			}

			protected override void OnRemoveComplete(int index, object val)
			{
				CurrentPosition = _currentPos;
				base.OnRemoveComplete(index, val);
			}

			// Other class members
			public string FileName
			{
				get { return _fileName; }
				set { _fileName = value; }
			}

			private const int _CurrentVersion = 92;

			public void Save(string fileName)
			{
				FileStream fs = new FileStream(fileName,
					FileMode.Create,
					FileAccess.ReadWrite);

				StreamWriter sw = new StreamWriter(fs);

				try
				{
					sw.WriteLine(_CurrentVersion.ToString());

					// Store each photo separately
					foreach (Photograph photo in this)
					{
						photo.Write(sw);
					}

					this._fileName = fileName;
				}

				finally
				{
					sw.Close();
					fs.Close();
				}
			}

			public void Save()
			{
				// Assumes FileName is not null
				Save(this.FileName);
			}

			public void Open(string fileName)
			{
				FileStream fs = new FileStream(fileName,
					FileMode.Open,
					FileAccess.Read);

				StreamReader sr = new StreamReader(fs);

				int version;

				try
				{
					version = Int32.Parse(sr.ReadLine());
				}
				catch
				{
					version = 0;
				}

				try
				{
					Clear();
					this._fileName = fileName;
					Photograph.ReadDelegate ReadPhoto;

					switch (version)
					{
						case 66:
							ReadPhoto = new Photograph.ReadDelegate(Photograph.ReadVersion66);
							break;

						case 83:
							ReadPhoto = new Photograph.ReadDelegate(Photograph.ReadVersion83);
							break;

						case 92:
							ReadPhoto = new Photograph.ReadDelegate(Photograph.ReadVersion92);
							break;

						default:
							// Unknown version or bad file.
							throw (new IOException
								("Unrecognized album file format"));
					}

					// Read in each photograph in the album
					Photograph p = ReadPhoto (sr);
					while (p != null)
					{
						this.Add(p);
						p = ReadPhoto (sr);
					}
				}
				finally
				{
					sr.Close();
					fs.Close();
				}
			}

			// end of PhotoAlbum class
		}
	}
}
