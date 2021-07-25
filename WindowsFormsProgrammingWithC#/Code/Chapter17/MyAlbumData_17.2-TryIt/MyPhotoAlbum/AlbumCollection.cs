using System;
using System.Collections;
using System.IO;

namespace Manning.MyPhotoAlbum
{
	/// <summary>
	/// Summary description for AlbumCollection.
	/// </summary>
	public class AlbumCollection : CollectionBase, IDisposable
	{
		public AlbumCollection(string albumDir)
		{
			string[] albums = Directory.GetFiles(albumDir, "*.abm");
			foreach (string albumFile in albums)
			{
				try
				{
					PhotoAlbum album = new PhotoAlbum();
					album.Open(albumFile);

					// Add the open album to the collection
					Add(album);
				}
				catch (Exception)
				{
					// Ignore this album.
					// Alternately this could allow the exception to occur.
				}
			}
		}

		public AlbumCollection() : this(PhotoAlbum.DefaultDir)
		{
			// Nothing further actions required
		}

		public void Dispose()
		{
			foreach (Photograph photo in this)
			{
				photo.Dispose();
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

		public virtual void CopyTo(PhotoAlbum[] array, int index)
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

		public virtual PhotoAlbum this[int index]
		{
			get { return (PhotoAlbum)(List[index]); }
			set { List[index] = value; }
		}

		public virtual int Add(PhotoAlbum photo)
		{
			return List.Add(photo);
		}

		public virtual bool Contains(PhotoAlbum photo)
		{
			return List.Contains(photo);
		}

		public virtual int IndexOf(PhotoAlbum photo)
		{
			return List.IndexOf(photo);
		}
			
		public virtual void Insert(int index, PhotoAlbum photo)
		{
			List.Insert(index, photo);
		}

		public virtual void Remove(PhotoAlbum photo)
		{
			List.Remove(photo);
		}

	}
}
