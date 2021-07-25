using System;
using System.Collections;

namespace Manning
{
	namespace MyPhotoAlbum
	{
		/// <summary>
		/// The PhotoAlbum class represents a collection of Photographs.
		/// </summary>
		public class PhotoAlbum : CollectionBase
		{
			public PhotoAlbum()
			{
				// Nothing to do
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

			// end of PhotoAlbum class
		}
	}
}
