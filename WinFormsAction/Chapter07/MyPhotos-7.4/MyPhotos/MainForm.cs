using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Manning.MyPhotoAlbum;
using Manning.MyPhotoControls;

namespace MyPhotos
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			NewAlbum();
			menuView.DropDown = ctxMenuPhoto;
		}

		private AlbumManager _manager;
		private AlbumManager Manager
		{
			get { return _manager; }
			set { _manager = value; }
		}

		private PixelDialog _dlgPixel = null;
		private PixelDialog PixelForm
		{
			get { return _dlgPixel; }
			set { _dlgPixel = value; }
		}

		private void SetTitleBar()
		{
			Version ver = new Version(Application.ProductVersion);
			string name = Manager.FullName;
			Text = String.Format("{2} - MyPhotos {0:0}.{1:0}",
				ver.Major, ver.Minor,
				String.IsNullOrEmpty(name) ? "Untitled" : name);
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Title = "Open Photo";
			dlg.Filter = "jpg files (*.jpg)|*.jpg"
				+ "|All files (*.*)|*.*";
			
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				try
				{
					pbxPhoto.Image = new Bitmap(dlg.OpenFile());
				}
				catch (ArgumentException ex)
				{
					// Handle exception
					MessageBox.Show("Unable to load file: " + ex.Message);
					pbxPhoto.Image = null;
				}
			}
			
			dlg.Dispose();
		}

		private void menuFileExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void menuImage_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			ProcessImageClick(e);
		}

		private void ProcessImageClick(ToolStripItemClickedEventArgs e)
		{
			ToolStripItem item = e.ClickedItem;
			string enumVal = item.Tag as string;
			if (enumVal != null)
			{
				pbxPhoto.SizeMode = (PictureBoxSizeMode)
				Enum.Parse(typeof(PictureBoxSizeMode),
				enumVal);
			}
		}

		private void menuImage_DropDownOpening(object sender, EventArgs e)
		{
			ProcessImageOpening(sender as ToolStripDropDownItem);
		}

		private void ProcessImageOpening(ToolStripDropDownItem parent)
		{
			if (parent != null)
			{
				string enumVal = pbxPhoto.SizeMode.ToString();
				foreach (ToolStripMenuItem item in parent.DropDownItems)
				{
					item.Enabled = (pbxPhoto.Image != null);
					item.Checked = item.Tag.Equals(enumVal);
				}
			}
		}

		private void SetStatusStrip()
		{
			if (pbxPhoto.Image != null)
			{
				statusInfo.Text = Manager.Current.Caption;
				statusImageSize.Text = String.Format("{0:#}x{1:#}",
					pbxPhoto.Image.Width, pbxPhoto.Image.Height);
				statusAlbumPos.Text = String.Format(" {0:0}/{1:0}",
					Manager.Index + 1, Manager.Album.Count);
			}
			else
			{
				statusInfo.Text = null;
				statusImageSize.Text = null;
				statusAlbumPos.Text = null;
			}
		}

		private void DisplayAlbum()
		{
			pbxPhoto.Image = Manager.CurrentImage;
			SetStatusStrip();
			SetTitleBar();

			Point p = pbxPhoto.PointToClient(Form.MousePosition);
			UpdatePixelDialog(p.X, p.Y);
		}

		private void menuFileNew_Click(object sender, EventArgs e)
		{
			NewAlbum();
		}

		private void NewAlbum()
		{
			if (Manager == null || SaveAndCloseAlbum())
			{
				// Album closed, create a new one
				Manager = new AlbumManager();
				DisplayAlbum();
			}
		}

		private void menuFileOpen_Click(object sender, EventArgs e)
		{
			// Allow user to select a new album
			OpenFileDialog dlg = new OpenFileDialog();

			dlg.Title = "Open Album";
			dlg.Filter = "Album files (*.abm)|*.abm|"
				+ "All files (*.*)|*.*";
			dlg.InitialDirectory = AlbumManager.DefaultPath;
			dlg.RestoreDirectory = true;

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				string path = dlg.FileName;

				// Close any existing album
				if (!SaveAndCloseAlbum())
					return; // Close canceled
				
				try
				{
					// Open the new album
					Manager = new AlbumManager(path);
				}
				catch (AlbumStorageException aex)
				{
					string msg = String.Format(
						"Unable to open album file {0}\n({1})",
						path, aex.Message);
					MessageBox.Show(msg, "Unable to Open");
					Manager = new AlbumManager();
				}

				DisplayAlbum();
			}

			dlg.Dispose();
		}

		private void SaveAlbum(string name)
		{
			try
			{
				Manager.Save(name, true);
			}
			catch (AlbumStorageException aex)
			{
				string msg = String.Format(
					"Unable to save album {0} ({1})\n\n"
					+ "Do you wish to save the album "
					+ "under an alternate name?",
					name, aex.Message);
				DialogResult result = MessageBox.Show(msg,
					"Unable to Save",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Error,
					MessageBoxDefaultButton.Button2);

				if (result == DialogResult.Yes)
					SaveAsAlbum();
			}
		}

		private void SaveAlbum()
		{
			if (String.IsNullOrEmpty(Manager.FullName))
				SaveAsAlbum(); // Force user to select name
			else
			{
				// Save the album under the existing name
				SaveAlbum(Manager.FullName);
			}
		}

		private bool SaveAndCloseAlbum()
		{
			if (Manager.Album.HasChanged)
			{
				// Offer to save the current album
				string msg;
				if (String.IsNullOrEmpty(Manager.FullName))
					msg = "Do you wish to save your changes?";
				else
					msg = String.Format("Do you wish to "
						+ "save your changes to \n{0}?",
					Manager.FullName);

				DialogResult result = MessageBox.Show(this, msg,
					"Save Changes?",
					MessageBoxButtons.YesNoCancel,
					MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
					SaveAlbum();
				else if (result == DialogResult.Cancel)
					return false; // do not close
			}
			// Close the album and return true
			if (Manager.Album != null)
				Manager.Album.Dispose();

			Manager = new AlbumManager();
			SetTitleBar();
			return true;
		}

		private void menuFileSave_Click(object sender, EventArgs e)
		{
			SaveAlbum();
		}

		private void menuFileSaveAs_Click(object sender, EventArgs e)
		{
			SaveAsAlbum();
		}

		private void SaveAsAlbum()
		{
			SaveFileDialog dlg = new SaveFileDialog();

			dlg.Title = "Save Album";
			dlg.DefaultExt = "abm";
			dlg.Filter = "Album files (*.abm)|*.abm|"
				+ "All files|*.*";
			dlg.InitialDirectory = AlbumManager.DefaultPath;
			dlg.RestoreDirectory = true;
			
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				SaveAlbum(dlg.FileName);
				// Update title bar to include new name
				SetTitleBar();
			}

			dlg.Dispose();
		}

		private void menuEditAdd_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();

			dlg.Title = "Add Photos";
			dlg.Multiselect = true;
			dlg.Filter = "Image Files (JPEG, GIF, BMP, etc.)|"
				+ "*.jpg;*.jpeg;*.gif;*.bmp;"
				+ "*.tif;*.tiff;*.png|"
				+ "JPEG files (*.jpg;*.jpeg)|*.jpg;*.jpeg|"
				+ "GIF files (*.gif)|*.gif|"
				+ "BMP files (*.bmp)|*.bmp|"
				+ "TIFF files (*.tif;*.tiff)|*.tif;*.tiff|"
				+ "PNG files (*.png)|*.png|"
				+ "All files (*.*)|*.*";
			dlg.InitialDirectory = Environment.CurrentDirectory;
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				string[] files = dlg.FileNames;
				int index = 0;

				foreach (string s in files)
				{
					Photograph photo = new Photograph(s);

					// Add the file (if not already present)
					index = Manager.Album.IndexOf(photo);
					if (index < 0)
						Manager.Album.Add(photo);
					else
						photo.Dispose(); // photo already there
				}
				Manager.Index = Manager.Album.Count - 1;
			}

			dlg.Dispose();
			DisplayAlbum();
		}

		private void menuEditRemove_Click(object sender, EventArgs e)
		{
			if (Manager.Album.Count > 0)
			{
				Manager.Album.RemoveAt(Manager.Index);
				DisplayAlbum();
			}
		}

		private void menuNext_Click(object sender, EventArgs e)
		{
			if (Manager.Index < Manager.Album.Count - 1)
			{
				Manager.Index++;
				DisplayAlbum();
			}
		}

		private void menuPrevious_Click(object sender, EventArgs e)
		{
			if (Manager.Index > 0)
			{
				Manager.Index--;
				DisplayAlbum();
			}
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			if (SaveAndCloseAlbum() == false)
				e.Cancel = true;
			else
				e.Cancel = false;
			base.OnFormClosing(e);
		}

		private void menuPixelData_Click(object sender, EventArgs e)
		{
			if (PixelForm == null || PixelForm.IsDisposed)
			{
				PixelForm = new PixelDialog();
				PixelForm.Owner = this;
			}

			PixelForm.Show();
			Point p = pbxPhoto.PointToClient(Form.MousePosition);
			UpdatePixelDialog(p.X, p.Y);
		}

		private void UpdatePixelDialog(int x, int y)
		{
			if (PixelForm != null && PixelForm.Visible)
			{
				Bitmap bmp = Manager.CurrentImage;
				PixelForm.Text = (Manager.Current == null
					? "Pixel Data" : Manager.Current.Caption);
				if (bmp == null || !pbxPhoto.DisplayRectangle.Contains(x, y))
					PixelForm.ClearPixelData();
				else
					PixelForm.UpdatePixelData(x, y, bmp,
						pbxPhoto.DisplayRectangle,
						new Rectangle(0, 0, bmp.Width, bmp.Height),
						pbxPhoto.SizeMode);
			}
		}

		private void pbxPhoto_MouseMove(object sender, MouseEventArgs e)
		{
			UpdatePixelDialog(e.X, e.Y);
		}

		private void ctxMenuPhoto_Opening(object sender, CancelEventArgs e)
		{
			menuNext.Enabled = (Manager.Index < Manager.Album.Count - 1);
			menuPrevious.Enabled = (Manager.Index > 0);
		}

	}
}