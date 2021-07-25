using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.IO;
using Manning.MyPhotoAlbum;
using Manning.MyPhotoControls;

namespace MyAlbumExplorer
{
	public partial class ExplorerForm : Form
	{
		private Photograph _priorPhoto = null;

		public ExplorerForm()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			// Assign title bar
			Version v = new Version(Application.ProductVersion);
			this.Text = String.Format("MyAlbumExplorer {0:#}.{1:#}",
				v.Major, v.Minor);

			// Define nodes for the default albums
			albumTree.Nodes.Clear();
			string[] albums = Directory.GetFiles(AlbumManager.DefaultPath, "*.abm");

			foreach (string file in albums)
			{
				string baseName = Path.GetFileNameWithoutExtension(file);
				try
				{
					// Define root album node
					PhotoAlbum album = AlbumStorage.ReadAlbum(file);
					string title = album.Title;
					if (String.IsNullOrEmpty(title))
						title = baseName;

					TreeNode node = albumTree.Nodes.Add(title);
					node.ToolTipText = file;
					foreach (Photograph p in album)
					{
						// Define child photograph node
						TreeNode child = node.Nodes.Add(p.Caption);
						child.ToolTipText = p.FileName;
						child.Tag = p;
					}
				}
				catch (AlbumStorageException)
				{
					// Unable to open album
					TreeNode node = albumTree.Nodes.Add(baseName);
					node.ToolTipText = "Unable to open album: " + file;
				}
			}

			base.OnLoad(e);
		}

		private void albumTree_BeforeSelect(object sender, TreeViewCancelEventArgs e)
		{
			if (_priorPhoto != null)
			{
				spbxPhoto.Image = null;
				_priorPhoto.ReleaseImage();
				_priorPhoto = null;
			}
		}

		private void albumTree_AfterSelect(object sender, TreeViewEventArgs e)
		{
			Photograph p = e.Node.Tag as Photograph;
			if (p != null)
				spbxPhoto.Image = p.Image;

			_priorPhoto = p;
		}
	}
}