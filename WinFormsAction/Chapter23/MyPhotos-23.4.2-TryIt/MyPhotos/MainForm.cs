using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Manning.MyPhotoAlbum;
using Manning.MyPhotoControls;
using MyPhotos.Properties;

namespace MyPhotos
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			NewAlbum();
			menuView.DropDown = ctxMenuPhoto;
			flybyProvider.SetFlybyText( menuFileSave, "Save the current album");
		}

		public MainForm(string path, string pwd)
			: this()
		{
			// Caller must deal with any exception
			Manager = new AlbumManager(path, pwd);
		}

		private const int WM_KEYDOWN = 0x100;

		private AlbumManager _manager;
		internal AlbumManager Manager
		{
			get { return _manager; }
			set
			{
				_manager = value;
				AssignSelectDropDown();
			}
		}

		private PixelDialog _dlgPixel = null;
		private PixelDialog PixelForm
		{
			get { return _dlgPixel; }
			set { _dlgPixel = value; }
		}

		internal ToolStrip MainToolStrip
		{
			get { return toolStripMain; }
		}

		public string AlbumPath
		{
			get { return Manager.FullName; }
		}

		public string AlbumTitle
		{
			get { return Manager.Album.Title; }
		}

		private void SetTitleBar()
		{
			Version ver = new Version(Application.ProductVersion);
			string name = Manager.ShortName;
			Text = String.Format("{2} - MyPhotos {0:0}.{1:0}",
				ver.Major, ver.Minor,
				String.IsNullOrEmpty(name) ? "Untitled" : name);
		}

		protected override void OnLoad(EventArgs e)
		{
			// Set up toolStripMain
			tsbNew.Tag = menuFileNew;
			tsbOpen.Tag = menuFileOpen;
			tsbSave.Tag = menuFileSave;
			tsbPrint.Tag = menuFilePrint;
			tsbCut.Tag = menuEditCut;
			tsbCopy.Tag = menuEditCopy;
			tsbPaste.Tag = menuEditPaste;
			tsbHelp.Tag = menuHelpAbout;
			tsbPrevious.Tag = menuPrevious;
			tsbNext.Tag = menuNext;

			toolStripMain.ImageList = imageListArrows;
			tsbPrevious.ImageIndex = 1;
			tsbNext.ImageIndex = 0;

			// Set up toolStripDialogs
			tsbAlbumProps.Tag = menuAlbumProps;
			tsbPhotoProps.Tag = menuPhotoProps;
			tsbPixelData.Tag = tsbPixelData.Image;

			// Set up toolStripImages
			tsdImage.DropDown = menuImage.DropDown;

			// Adjust form if MDI child
			if (IsMdiChild)
			{
				menuStrip1.Visible = false;
				toolStripMain.Visible = false;
				DisplayAlbum();
			}

			pbxPhoto.AllowDrop = true;

			base.OnLoad(e);
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

		internal void DisplayAlbum()
		{
			pbxPhoto.Image = Manager.CurrentImage;
			SetStatusStrip();
			SetTitleBar();

			// Assign index as last photo displayed
			Settings.Default.LastPhotoIndex = Manager.Index;

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
			string path = null;
			string password = null;
			if (AlbumController.OpenAlbumDialog(ref path, ref password))
			{
				// Close any existing album
				if (!SaveAndCloseAlbum())
					return; // Close canceled
				
				try
				{
					// Open the new album
					Manager = new AlbumManager(path, password);
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
			DialogResult result = AlbumController.AskForSave(Manager);

			if (result == DialogResult.Yes)
				SaveAlbum();
			else if (result == DialogResult.Cancel)
				return false; // do not close

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
			string path = null;
			if (AlbumController.SaveAlbumDialog(ref path))
			{
				// Save the album under the new name
				SaveAlbum(path);

				// Update title bar to include new name
				SetTitleBar();
			}
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

		private void ctxMenuPhoto_Opening(object sender, CancelEventArgs e)
		{
			menuNext.Enabled = (Manager.Index < Manager.Album.Count - 1);
			menuPrevious.Enabled = (Manager.Index > 0);

			menuPhotoProps.Enabled = (Manager.Current != null);
			menuAlbumProps.Enabled = (Manager.Album != null);
			menuSlideShow.Enabled = (Manager.Album != null && Manager.Album.Count > 0);
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
				PixelForm = PixelDialog.GlobalInstance;
				PixelForm.Owner = this;
			}

			PixelForm.Show();
			Point p = pbxPhoto.PointToClient(Form.MousePosition);
			UpdatePixelDialog(p.X, p.Y);
			UpdatePixelButton(true);
		}

		private void UpdatePixelDialog(int x, int y)
		{
			if (IsMdiChild)
				PixelForm = PixelDialog.GlobalInstance;

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

		private void menuPhotoProps_Click(object sender, EventArgs e)
		{
			if (Manager.Current == null)
				return;
			
			using (PhotoEditDialog dlg = new PhotoEditDialog(Manager))
			{
				if (dlg.ShowDialog() == DialogResult.OK)
					DisplayAlbum();
			}
		}

		private void menuAlbumProps_Click(object sender, EventArgs e)
		{
			if (Manager.Album == null)
				return;

			using (AlbumEditDialog dlg = new AlbumEditDialog(Manager))
			{
				if (dlg.ShowDialog() == DialogResult.OK)
					DisplayAlbum();
			}
		}

		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			switch (e.KeyChar)
			{
				case '+':
					menuNext.PerformClick();
					e.Handled = true;
					break;

				case '-':
					menuPrevious.PerformClick();
					e.Handled = true;
					break;
			}

			// Invoke the base method
			base.OnKeyPress(e);
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.PageUp:
					menuPrevious.PerformClick();
					e.Handled = true;
					break;

				case Keys.PageDown:
					menuNext.PerformClick();
					e.Handled = true;
					break;
			}

			base.OnKeyDown(e);
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (msg.Msg == WM_KEYDOWN)
			{
				switch (keyData)
				{
					case Keys.Tab:
						menuNext.PerformClick();
						return true;
					case Keys.Shift | Keys.Tab:
						menuPrevious.PerformClick();
						return true;
				}
			}
			
			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void menuSlideShow_Click(object sender, EventArgs e)
		{
			using (SlideShowDialog dlg = new SlideShowDialog(Manager))
			{
				dlg.ShowDialog();
			}
		}

		private void tbs_Click(object sender, EventArgs e)
		{
			// Ensure sender is a menu item
			ToolStripItem item = sender as ToolStripItem;
			if (item != null)
			{
				ToolStripMenuItem mi = item.Tag as ToolStripMenuItem;
				if (mi != null)
					mi.PerformClick();
			}
		}

		private void tsbPixelData_Click(object sender, EventArgs e)
		{
			Form f = PixelForm;
			if (f == null || f.IsDisposed || !f.Visible)
				menuPixelData.PerformClick();
			else
				f.Hide();

			UpdatePixelButton(PixelForm.Visible);
		}

		private void UpdatePixelButton(bool visible)
		{
			tsbPixelData.Checked = visible;
			if (visible)
				tsbPixelData.Image = tsbPixelData2.Image;
			else
				tsbPixelData.Image = (Image)tsbPixelData.Tag;
		}

		protected override void OnActivated(EventArgs e)
		{
			if (_dlgPixel != null)
				UpdatePixelButton(_dlgPixel.Visible);

			base.OnActivated(e);
		}

		private void AssignSelectDropDown()
		{
			ToolStripDropDown drop = new ToolStripDropDown();
			PhotoAlbum a = Manager.Album;
			for (int i = 0; i < a.Count; i++)
			{
				PictureBox box = new PictureBox();
				box.SizeMode = PictureBoxSizeMode.Zoom;
				box.Image = a[i].Image;
				box.Dock = DockStyle.Fill;

				ToolStripControlHost host = new ToolStripControlHost(box);
				host.AutoSize = false;
				host.Size = new Size(tssSelect.Width, tssSelect.Width);
				host.Tag = i;

				host.Click += delegate(object o, EventArgs e)
				{
					int x = (int)(o as ToolStripItem).Tag;
					Manager.Index = x;
					drop.Close();
					DisplayAlbum();
				};
				drop.Items.Add(host);
			}

			if (drop.Items.Count > 0)
			{
				tssSelect.DropDown = drop;
				tssSelect.DefaultItem = drop.Items[0];
			}
		}

		protected override void OnEnter(EventArgs e)
		{
			if (IsMdiChild)
				UpdatePixelButton(PixelDialog.GlobalInstance.Visible);

			base.OnEnter(e);
		}

		private void menuFilePageSetup_Click(object sender, EventArgs e)
		{
			PrintSupport.PageSetup();
		}

		private void menuFilePrint_Click(object sender, EventArgs e)
		{
			PrintSupport.Print();
		}

		private void menuFilePrintPreview_Click(object sender, EventArgs e)
		{
			PrintSupport.PrintPreview();
		}

		private void pbxPhoto_MouseDown(object sender, MouseEventArgs e)
		{
			// Prepare image for drag-and-drop
			Photograph photo = Manager.Current;
			if (photo != null)
			{
				// Create object for encapsulating data
				DataObject data = new DataObject();

				// Construct string array for FileDrop
				string[] fileArray = new string[1];
				fileArray[0] = photo.FileName;
				data.SetData(DataFormats.FileDrop, fileArray);

				// Use the caption for the text format
				data.SetData(DataFormats.Text, photo.Caption);

				// Initiate drag-and-drop
				pbxPhoto.DoDragDrop(data, DragDropEffects.Copy);
			}
		}

		private void pbxPhoto_DragEnter(object sender, DragEventArgs e)
		{
			// Allow file drops only
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}

		private void pbxPhoto_DragDrop(object sender, DragEventArgs e)
		{
			// Get the object data for the drop
			object obj = e.Data.GetData(DataFormats.FileDrop);
			Array files = obj as Array;
			int index = -1;
			foreach (object o in files)
			{
				string s = o as string;
				if (s != null)
				{
					Photograph photo = new Photograph(s);
					// Add the file (if not present)
					index = Manager.Album.IndexOf(photo);
					if (index < 0)
					{
						Manager.Album.Add(photo);
						index = Manager.Album.Count - 1;
					}
				}
			}

			if (index >= 0)
			{
				Manager.Index = index;
				DisplayAlbum();
			}
		}

		private void menuHelpAbout_Click(object sender, EventArgs e)
		{
			using (AboutBox dlg = new AboutBox())
			{
				dlg.IsMdiApplication = IsMdiChild;
				dlg.AboutText = String.Format(
					"MyPhotos Application, Version {0}\n"
					+ "Sample for \"Windows Forms in "
					+ "Action\" by Erik Brown\n"
					+ "Copyright Manning Publications Co.",
					Application.ProductVersion);

				dlg.Owner = this;
				dlg.Icon = this.Icon;
				dlg.ShowDialog();
			}
		}

	}
}