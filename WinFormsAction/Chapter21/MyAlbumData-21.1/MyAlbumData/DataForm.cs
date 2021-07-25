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

namespace MyAlbumData
{
	public partial class DataForm : Form
	{
		private AlbumManager _manager;
		internal AlbumManager Manager { get { return _manager; } }

		public DataForm()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			Version ver = new Version(Application.ProductVersion);
			Text = String.Format("MyAlbumData {0:#}.{1:#}", ver.Major, ver.Minor);

			_manager = new AlbumManager();
			comboAlbum.DataSource = Directory.GetFiles(
			AlbumManager.DefaultPath, "*.abm");

			OpenAlbum();
			SetDataSources();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void comboAlbum_SelectionChangeCommitted(object sender, EventArgs e)
		{
			OpenAlbum();
			SetDataSources();
		}

		private void OpenAlbum()
		{
			string albumPath = comboAlbum.SelectedItem.ToString();
			if (Manager.FullName == albumPath)
				return;

			if (CloseAlbum() == false)
				return;

			try
			{
				_manager = new AlbumManager(albumPath);
			}
			catch (AlbumStorageException aex)
			{
				_manager = new AlbumManager();
				MessageBox.Show("Unable to open album - " + aex.Message);
			}
		}

		private bool CloseAlbum()
		{
			if (Manager.Album != null)
				Manager.Album.Dispose();
		
			return true;
		}

		private void SetDataSources()
		{
			gridPhotoAlbum.DataSource = Manager.Album;
		}

	}
}