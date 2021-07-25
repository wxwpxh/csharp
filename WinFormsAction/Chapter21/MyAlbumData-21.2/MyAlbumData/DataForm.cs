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

			DataGridViewColumn captionCol = new DataGridViewTextBoxColumn();
			captionCol.DataPropertyName = "Caption";
			captionCol.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			captionCol.Name = "Caption";

			DataGridViewColumn takenCol = new DataGridViewTextBoxColumn();
			takenCol.DataPropertyName = "DateTaken";
			takenCol.Name = "Date Taken";

			DataGridViewComboBoxColumn pgCol = new DataGridViewComboBoxColumn();
			pgCol.AutoComplete = true;
			pgCol.DataPropertyName = "Photographer";
			pgCol.MaxDropDownItems = 4;
			pgCol.Name = "Photographer";

			DataGridViewTextBoxColumn fileCol = new DataGridViewTextBoxColumn();
			fileCol.DataPropertyName = "FileName";
			fileCol.Name = "File Name";

			gridPhotoAlbum.Columns.AddRange(new DataGridViewColumn[] {
												thumbCol,
												captionCol,
												takenCol,
												pgCol,
												fileCol});

			gridPhotoAlbum.ResumeLayout();
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
			SetComboColumnDataSource();
		}

		private void SetComboColumnDataSource()
		{
			DataGridViewComboBoxColumn pgCol
				= gridPhotoAlbum.Columns["Photographer"] as DataGridViewComboBoxColumn;
			if (pgCol != null)
				pgCol.DataSource = Manager.Photographers;
		}

		private void gridPhotoAlbum_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				ContextMenuStrip menu = new ContextMenuStrip();
				ToolStripItem item = menu.Items.Add("Edit...");
				item.Tag = gridPhotoAlbum.Rows[e.RowIndex];
				item.Click += new EventHandler(editMenu_Click);
				menu.Show(MousePosition);
			}
		}

		private void editMenu_Click(object sender, EventArgs e)
		{
			ToolStripItem item = sender as ToolStripItem;
			if (item != null && item.Tag is DataGridViewRow)
			{
				DataGridViewRow row = item.Tag as DataGridViewRow;
				Photograph photo = row.DataBoundItem as Photograph;
				using (PhotoEditDialog dlg = new PhotoEditDialog(photo))
				{
					if (dlg.ShowDialog() == DialogResult.OK && photo.HasChanged)
					{
						SetComboColumnDataSource();
					}
				}
			}
		}

	}
}