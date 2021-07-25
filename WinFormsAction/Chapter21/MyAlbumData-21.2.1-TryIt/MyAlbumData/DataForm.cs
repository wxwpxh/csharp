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
			SetupGrid();
		}

		private void SetupGrid()
		{
			gridPhotoAlbum.SuspendLayout();
			gridPhotoAlbum.AutoGenerateColumns = false;
			gridPhotoAlbum.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

			DataGridViewImageColumn thumbCol = new DataGridViewImageColumn();
			thumbCol.DataPropertyName = "Image";
			thumbCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
			thumbCol.Name = "Image";
			thumbCol.Width = 50;

			DataGridViewColumn sizeCol = new DataGridViewTextBoxColumn();
			SizeColumnIndex = sizeCol.Index;
			sizeCol.DataPropertyName = "Image";
			sizeCol.Name = "Image Size";

			DataGridViewColumn captionCol = new DataGridViewTextBoxColumn();
			captionCol.DataPropertyName = "Caption";
			captionCol.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			captionCol.Name = "Caption";

			DataGridViewColumn takenCol = new DataGridViewTextBoxColumn();
			takenCol.DataPropertyName = "DateTaken";
			takenCol.Name = "Date Taken";

			DataGridViewColumn pgCol = new DataGridViewTextBoxColumn();
			pgCol.DataPropertyName = "Photographer";
			pgCol.Name = "Photographer";

			DataGridViewTextBoxColumn fileCol = new DataGridViewTextBoxColumn();
			fileCol.DataPropertyName = "FileName";
			fileCol.Name = "File Name";

			gridPhotoAlbum.Columns.AddRange(new DataGridViewColumn[] {
												thumbCol,
												sizeCol,
												captionCol,
												takenCol,
												pgCol,
												fileCol});

			gridPhotoAlbum.ResumeLayout();
		}

		protected override void OnLoad(EventArgs e)
		{
			Version ver = new Version(Application.ProductVersion);
			Text = String.Format("MyAlbumData {0:#}.{1:#} Try It", ver.Major, ver.Minor);

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

		private int _sizeColumnIndex = -1;
		private int SizeColumnIndex
		{
			get { return _sizeColumnIndex; }
			set { _sizeColumnIndex = value; }
		}

		private void gridPhotoAlbum_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			// Record the Image Size index for posterity
			if (SizeColumnIndex < 0)
				SizeColumnIndex = gridPhotoAlbum.Columns["Image Size"].Index;
			
			// Don't care unless this is the size column
			if (e.ColumnIndex == SizeColumnIndex)
			{
				DataGridViewColumn col = gridPhotoAlbum.Columns[SizeColumnIndex];
				Photograph p = Manager.Album[e.RowIndex];

				// Assign the desired cell value,
				// and indicate we've handled the conversion.
				e.Value = String.Format("{0} x {1}", p.Image.Width, p.Image.Height);
				e.FormattingApplied = true;
			}
		}

	}
}