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

		protected override void OnLoad(EventArgs e)
		{
			// Assign title bar
			Version v = new Version(Application.ProductVersion);
			this.Text = String.Format("MyAlbumExplorer {0:#}.{1:#}",
				v.Major, v.Minor);

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

			// Add the albums for given node
			foreach (AlbumNode aNode in dirNode.AlbumNodes)
			{
				string text = Path.GetFileNameWithoutExtension(aNode.AlbumPath);
				ListViewItem item = lvAlbumList.Items.Add(text);
				item.ImageKey = aNode.ImageKey;
			}
		}

		private void ListPhotoData(AlbumNode albumNode)
		{
			// Show photographs in list view
			spbxPhoto.Visible = false;
			lvAlbumList.Visible = true;
			ShowingAlbums = false;

			// Add the photos for given node
			AlbumManager mgr = albumNode.GetManager(true);
			if (mgr != null)
			{
				foreach (Photograph p in mgr.Album)
				{
					ListViewItem item = new ListViewItem(p.Caption, "Photo");
					lvAlbumList.Items.Add(item);
				}
			}
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

	}
}