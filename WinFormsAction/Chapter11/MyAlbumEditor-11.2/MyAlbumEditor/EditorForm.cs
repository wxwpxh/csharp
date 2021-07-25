using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Manning.MyPhotoAlbum;
using Manning.MyPhotoControls;

namespace MyAlbumEditor
{
	public partial class EditorForm : Form
	{
		private AlbumManager _manager;
		private AlbumManager Manager
		{
			get { return _manager; }
			set { _manager = value; }
		}

		public EditorForm()
		{
			InitializeComponent();
			Manager = new AlbumManager();
		}

		private bool CloseAlbum()
		{
			if (Manager != null)
			{
				DialogResult result = AlbumController.AskForSave(Manager);
				switch (result)
				{
					case DialogResult.Yes:
						Manager.Save();
						break;
					case DialogResult.Cancel:
						return true;
				}

				Manager.Album.Dispose();
				Manager = null;
			}

			return false;
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			e.Cancel = CloseAlbum();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			string path = null;
			string password = null;
			if (AlbumController.OpenAlbumDialog(ref path, ref password))
			{
				if (CloseAlbum())
					return; // cancel open
				try
				{
					Manager = new AlbumManager(
					path, password);
				}
				catch (AlbumStorageException)
				{
					Manager = null;
				}
			}

			DisplayAlbum();
		}

		private void DisplayAlbum()
		{
			if (Manager == null)
			{
				grpPhotos.Enabled = false;
				btnAlbumProps.Enabled = false;
				Text = "The selected album could not be opened";
				lstPhotos.BackColor = SystemColors.Control;
				lstPhotos.Items.Clear();
			}
			else
			{
				grpPhotos.Enabled = true;
				btnAlbumProps.Enabled = true;
				Text = "Album " + Manager.ShortName;
				lstPhotos.BackColor = SystemColors.Window;
				lstPhotos.DataSource = Manager.Album;
			}
		}

		private void btnAlbumProps_Click(object sender, EventArgs e)
		{
			if (Manager == null)
				return;
			
			using (AlbumEditDialog dlg = new AlbumEditDialog(Manager))
			{
				if (dlg.ShowDialog() == DialogResult.OK)
					DisplayAlbum();
			}
		}

		private void btnPhotoProps_Click(object sender, EventArgs e)
		{
			if (Manager == null || lstPhotos.SelectedIndex < 0)
				return; // nothing selected

			Manager.Index = lstPhotos.SelectedIndex;
			using (PhotoEditDialog dlg = new PhotoEditDialog(Manager))
			{
				if (dlg.ShowDialog() == DialogResult.OK)
					DisplayAlbum();
			}
		}

		private void lstPhotos_DoubleClick(object sender, EventArgs e)
		{
			btnPhotoProps.PerformClick();
		}

	}
}