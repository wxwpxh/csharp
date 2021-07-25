using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

using Manning.MyPhotoAlbum;
using Manning.MyPhotoControls;

namespace MyAlbumExplorer
{
	public partial class ExplorerForm : Form
	{
		public ExplorerForm()
		{
			InitializeComponent();
		}

		private Photograph _currentPhoto = null;

		private bool _showingAlbums = true;
		private bool ShowingAlbums
		{
			get { return _showingAlbums; }
			set { _showingAlbums = value; }
		}

		private MyListViewComparer _comparer;
		private MyListViewComparer MyComparer { get { return _comparer; } }

		protected override void OnLoad(EventArgs e)
		{
			// Assign title bar
			Version v = new Version(Application.ProductVersion);
			this.Text = String.Format("MyAlbumExplorer {0:#}.{1:#}",
				v.Major, v.Minor);

			_comparer = new MyListViewComparer(lvAlbumList);
			lvAlbumList.ListViewItemSorter = MyComparer;

			atvAlbumTree.Nodes.Clear();
			atvAlbumTree.AddAlbumDirectory("Default Albums",
				AlbumManager.DefaultPath);

			base.OnLoad(e);
		}

		private void atvAlbumTree_BeforeSelect(object sender, TreeViewCancelEventArgs e)
		{
			if (_currentPhoto != null)
			{
				spbxPhoto.Image = null;
				_currentPhoto.ReleaseImage();
				_currentPhoto = null;
			}
		}

		private void atvAlbumTree_AfterSelect(object sender, TreeViewEventArgs e)
		{
			try
			{
				bool oldShowingAlbums = ShowingAlbums;

				lvAlbumList.BeginUpdate();
				lvAlbumList.Clear();
				if (e.Node is AlbumDirectoryNode)
					ListAlbumData(e.Node as AlbumDirectoryNode);
				else if (e.Node is AlbumNode)
					ListPhotoData(e.Node as AlbumNode);
				else if (e.Node is PhotoNode)
					DisplayPhoto(e.Node as PhotoNode);
				else
					throw new ArgumentException("Unrecognized node");

				if (lvAlbumList.Visible && ShowingAlbums != oldShowingAlbums)
				{
					// Columns changed, so reset sorting
					MyComparer.SortColumn = 0;
					lvAlbumList.Sorting = SortOrder.Ascending;
				}
			}
			finally
			{
				lvAlbumList.EndUpdate();
			}
		}

		private void DisplayPhoto(PhotoNode photoNode)
		{
			spbxPhoto.Visible = true;
			lvAlbumList.Visible = false;

			_currentPhoto = photoNode.Photograph;
			spbxPhoto.Image = _currentPhoto.Image;
		}

		private void ListAlbumData(AlbumDirectoryNode dirNode)
		{
			// Show albums in list view
			spbxPhoto.Visible = false;
			lvAlbumList.Visible = true;
			ShowingAlbums = true;

			// Presume list cleared, so recreate columns
			lvAlbumList.Columns.Add("Name", 80);
			lvAlbumList.Columns.Add("Title", 120);
			lvAlbumList.Columns.Add("Size", 40, HorizontalAlignment.Center);

			// Add the albums for given node
			foreach (AlbumNode aNode in dirNode.AlbumNodes)
			{
				string text = Path.GetFileNameWithoutExtension(aNode.AlbumPath);
				ListViewItem item = lvAlbumList.Items.Add(text);

				AlbumManager mgr = aNode.GetManager(false);
				item.ImageKey = aNode.ImageKey;
				AssignSubItems(item, aNode.AlbumPath, mgr);
			}
		}

		private void ListPhotoData(AlbumNode albumNode)
		{
			// Show photographs in list view
			spbxPhoto.Visible = false;
			lvAlbumList.Visible = true;
			ShowingAlbums = false;

			// Presume contents cleared, so recreate columns
			lvAlbumList.Columns.Add("Caption", 120);
			lvAlbumList.Columns.Add("Photographer", 100);
			lvAlbumList.Columns.Add("Taken", 80, HorizontalAlignment.Center);
			lvAlbumList.Columns.Add("File Name", 200);

			// Add the photos for given node
			AlbumManager mgr = albumNode.GetManager(true);
			if (mgr != null)
			{
				foreach (Photograph p in mgr.Album)
				{
					ListViewItem item = new ListViewItem(p.Caption, "Photo");
					AssignSubItems(item, p);
					lvAlbumList.Items.Add(item);
				}
			}
		}

		private void AssignSubItems(ListViewItem item, string path, AlbumManager mgr)
		{
			item.SubItems.Clear();
			item.Text = Path.GetFileNameWithoutExtension(path);
			ListViewItem.ListViewSubItem subitem;
			if (mgr == null)
			{
				item.Tag = path;
				item.SubItems.Add("");
				subitem = item.SubItems.Add("?");
				subitem.Tag = 999;
			}
			else
			{
				PhotoAlbum album = mgr.Album;
				int count = album.Count;

				item.Tag = mgr;
				item.SubItems.Add(album.Title);
				subitem = item.SubItems.Add(count.ToString());
				subitem.Tag = count;
			}
		}

		private void AssignSubItems(ListViewItem item, Photograph photo)
		{
			item.SubItems.Clear();
			item.Text = photo.Caption;
			item.Tag = photo;

			ListViewItem.ListViewSubItem subitem;
			item.SubItems.Add(photo.Photographer);
			subitem = item.SubItems.Add(photo.DateTaken.ToString("dd MMM yyyy"));
			subitem.Tag = photo.DateTaken;
			item.SubItems.Add(photo.FileName);
		}

		private void menuFileExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void menuView_DropDownOpening(object sender, EventArgs e)
		{
			View v = lvAlbumList.View;
			menuViewLarge.Checked = (v == View.LargeIcon);
			menuViewSmall.Checked = (v == View.SmallIcon);
			menuViewList.Checked = (v == View.List);
			menuViewDetails.Checked = (v == View.Details);
			menuViewTiles.Checked = (v == View.Tile);
		}

		private void menuView_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			ToolStripItem item = e.ClickedItem;
			string enumVal = item.Tag as string;
			if (enumVal != null)
			{
				lvAlbumList.View = (View)
				Enum.Parse(typeof(View), enumVal);
			}
		}

		private void lvAlbumList_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			if (e.Column == MyComparer.SortColumn)
			{
				// Switch the sort order for this column
				if (lvAlbumList.Sorting == SortOrder.Ascending)
					lvAlbumList.Sorting = SortOrder.Descending;
				else
					lvAlbumList.Sorting = SortOrder.Ascending;
			}
			else
			{
				// Define new sort column and order
				MyComparer.SortColumn = e.Column;
				lvAlbumList.Sorting = SortOrder.Ascending;
			}

			lvAlbumList.Sort();
		}

	}
}