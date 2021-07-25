using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

using Manning.MyPhotoAlbum;

namespace MyPhotos
{
	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuFile;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuExit;
		private System.Windows.Forms.MenuItem menuView;
		private System.Windows.Forms.MenuItem menuImage;
		private System.Windows.Forms.MenuItem menuStretch;
		private System.Windows.Forms.MenuItem menuActual;		
		private System.Windows.Forms.ContextMenu ctxtMenuView;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel sbpnlFileName;
		private System.Windows.Forms.StatusBarPanel sbpnlImageSize;
		private System.Windows.Forms.StatusBarPanel sbpnlImagePercent;
		private System.Windows.Forms.MenuItem menuNew;
		private System.Windows.Forms.MenuItem menuOpen;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuSave;
		private System.Windows.Forms.MenuItem menuSaveAs;
		private System.Windows.Forms.MenuItem menuEdit;
		private System.Windows.Forms.MenuItem menuAdd;
		private System.Windows.Forms.MenuItem menuRemove;
		private System.Windows.Forms.StatusBarPanel sbpnlFileIndex;
		private System.Windows.Forms.MenuItem menuNext;
		private System.Windows.Forms.MenuItem menuPrevious;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuScale;
		private System.Windows.Forms.Panel pnlPhoto;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuCaption;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MainForm()
		{
			// Required for Windows Form Designer support
			InitializeComponent();

			// Other initialization
			menuNew_Click(this, EventArgs.Empty);
			DefineContextMenu();
			_album = new PhotoAlbum();
		}

		protected PhotoAlbum _album;
		protected bool _bAlbumChanged = false;

		/// <summary>
		/// Mode settings for the View->Image
		/// submenu.  The order and values here
		/// must correspond to the index of
		/// menus in the Image submenu.
		/// </summary>
		private enum DisplayMode
		{
			ScaleToFit = 0,
			StretchToFit = 1,
			ActualSize = 2
		}
		private DisplayMode _selectedMode = DisplayMode.ScaleToFit;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ctxtMenuView = new System.Windows.Forms.ContextMenu();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuFile = new System.Windows.Forms.MenuItem();
			this.menuNew = new System.Windows.Forms.MenuItem();
			this.menuOpen = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuSave = new System.Windows.Forms.MenuItem();
			this.menuSaveAs = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuExit = new System.Windows.Forms.MenuItem();
			this.menuEdit = new System.Windows.Forms.MenuItem();
			this.menuAdd = new System.Windows.Forms.MenuItem();
			this.menuRemove = new System.Windows.Forms.MenuItem();
			this.menuView = new System.Windows.Forms.MenuItem();
			this.menuImage = new System.Windows.Forms.MenuItem();
			this.menuScale = new System.Windows.Forms.MenuItem();
			this.menuStretch = new System.Windows.Forms.MenuItem();
			this.menuActual = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuNext = new System.Windows.Forms.MenuItem();
			this.menuPrevious = new System.Windows.Forms.MenuItem();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.sbpnlFileName = new System.Windows.Forms.StatusBarPanel();
			this.sbpnlImageSize = new System.Windows.Forms.StatusBarPanel();
			this.sbpnlFileIndex = new System.Windows.Forms.StatusBarPanel();
			this.sbpnlImagePercent = new System.Windows.Forms.StatusBarPanel();
			this.pnlPhoto = new System.Windows.Forms.Panel();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuCaption = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.sbpnlFileName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sbpnlImageSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sbpnlFileIndex)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sbpnlImagePercent)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuFile,
																					  this.menuEdit,
																					  this.menuView});
			// 
			// menuFile
			// 
			this.menuFile.Index = 0;
			this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuNew,
																					 this.menuOpen,
																					 this.menuItem1,
																					 this.menuSave,
																					 this.menuSaveAs,
																					 this.menuItem4,
																					 this.menuExit});
			this.menuFile.Text = "&File";
			// 
			// menuNew
			// 
			this.menuNew.Index = 0;
			this.menuNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
			this.menuNew.Text = "&New";
			this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
			// 
			// menuOpen
			// 
			this.menuOpen.Index = 1;
			this.menuOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.menuOpen.Text = "&Open";
			this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 2;
			this.menuItem1.Text = "-";
			// 
			// menuSave
			// 
			this.menuSave.Index = 3;
			this.menuSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.menuSave.Text = "&Save";
			this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
			// 
			// menuSaveAs
			// 
			this.menuSaveAs.Index = 4;
			this.menuSaveAs.Text = "Save &As";
			this.menuSaveAs.Click += new System.EventHandler(this.menuSaveAs_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 5;
			this.menuItem4.Text = "-";
			// 
			// menuExit
			// 
			this.menuExit.Index = 6;
			this.menuExit.Text = "E&xit";
			this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
			// 
			// menuEdit
			// 
			this.menuEdit.Index = 1;
			this.menuEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuAdd,
																					 this.menuRemove,
																					 this.menuItem2,
																					 this.menuCaption});
			this.menuEdit.Text = "&Edit";
			this.menuEdit.Popup += new System.EventHandler(this.menuEdit_Popup);
			// 
			// menuAdd
			// 
			this.menuAdd.Index = 0;
			this.menuAdd.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
			this.menuAdd.Text = "&Add";
			this.menuAdd.Click += new System.EventHandler(this.menuAdd_Click);
			// 
			// menuRemove
			// 
			this.menuRemove.Index = 1;
			this.menuRemove.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
			this.menuRemove.Text = "&Remove";
			this.menuRemove.Click += new System.EventHandler(this.menuRemove_Click);
			// 
			// menuView
			// 
			this.menuView.Index = 2;
			this.menuView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuImage,
																					 this.menuItem5,
																					 this.menuNext,
																					 this.menuPrevious});
			this.menuView.Text = "&View";
			// 
			// menuImage
			// 
			this.menuImage.Index = 0;
			this.menuImage.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuScale,
																					  this.menuStretch,
																					  this.menuActual});
			this.menuImage.Text = "&Image";
			this.menuImage.Popup += new System.EventHandler(this.menuImage_Popup);
			// 
			// menuScale
			// 
			this.menuScale.Index = 0;
			this.menuScale.Text = "&Scale to Fit";
			this.menuScale.Click += new System.EventHandler(this.menuImage_ChildClick);
			// 
			// menuStretch
			// 
			this.menuStretch.Index = 1;
			this.menuStretch.Text = "S&tretch to Fit";
			this.menuStretch.Click += new System.EventHandler(this.menuImage_ChildClick);
			// 
			// menuActual
			// 
			this.menuActual.Index = 2;
			this.menuActual.Text = "&Actual Size";
			this.menuActual.Click += new System.EventHandler(this.menuImage_ChildClick);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.Text = "-";
			// 
			// menuNext
			// 
			this.menuNext.Index = 2;
			this.menuNext.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftN;
			this.menuNext.Text = "&Next";
			this.menuNext.Click += new System.EventHandler(this.menuNext_Click);
			// 
			// menuPrevious
			// 
			this.menuPrevious.Index = 3;
			this.menuPrevious.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftP;
			this.menuPrevious.Text = "&Prev";
			this.menuPrevious.Click += new System.EventHandler(this.menuPrevious_Click);
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 251);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						  this.sbpnlFileName,
																						  this.sbpnlImageSize,
																						  this.sbpnlFileIndex,
																						  this.sbpnlImagePercent});
			this.statusBar1.Size = new System.Drawing.Size(292, 22);
			this.statusBar1.TabIndex = 2;
			this.statusBar1.Text = "Ready";
			this.statusBar1.DrawItem += new System.Windows.Forms.StatusBarDrawItemEventHandler(this.statusBar1_DrawItem);
			// 
			// sbpnlFileName
			// 
			this.sbpnlFileName.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.sbpnlFileName.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
			this.sbpnlFileName.Text = "statusBarPanel1";
			this.sbpnlFileName.ToolTipText = "ImageFileName";
			// 
			// sbpnlImageSize
			// 
			this.sbpnlImageSize.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
			this.sbpnlImageSize.Text = "statusBarPanel2";
			this.sbpnlImageSize.ToolTipText = "ImageSize";
			this.sbpnlImageSize.Width = 97;
			// 
			// sbpnlFileIndex
			// 
			this.sbpnlFileIndex.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
			this.sbpnlFileIndex.Text = "statusBarPanel1";
			this.sbpnlFileIndex.ToolTipText = "Image Index";
			this.sbpnlFileIndex.Width = 97;
			// 
			// sbpnlImagePercent
			// 
			this.sbpnlImagePercent.Style = System.Windows.Forms.StatusBarPanelStyle.OwnerDraw;
			this.sbpnlImagePercent.Text = "statusBarPanel3";
			this.sbpnlImagePercent.ToolTipText = "Percent of Image Shown";
			this.sbpnlImagePercent.Width = 75;
			// 
			// pnlPhoto
			// 
			this.pnlPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlPhoto.Name = "pnlPhoto";
			this.pnlPhoto.Size = new System.Drawing.Size(292, 251);
			this.pnlPhoto.TabIndex = 3;
			this.pnlPhoto.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPhoto_Paint);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 2;
			this.menuItem2.Text = "-";
			// 
			// menuCaption
			// 
			this.menuCaption.Enabled = false;
			this.menuCaption.Index = 3;
			this.menuCaption.Text = "&Caption...";
			this.menuCaption.Click += new System.EventHandler(this.menuCaption_Click);
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.ContextMenu = this.ctxtMenuView;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.pnlPhoto,
																		  this.statusBar1});
			this.Menu = this.mainMenu1;
			this.MinimumSize = new System.Drawing.Size(200, 200);
			this.Name = "MainForm";
			this.Text = "MyPhotos";
			((System.ComponentModel.ISupportInitialize)(this.sbpnlFileName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sbpnlImageSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sbpnlFileIndex)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sbpnlImagePercent)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}

		private void menuExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		protected void menuImage_Popup (object sender, System.EventArgs e)
		{
			if (sender is MenuItem)
			{
				bool bImageLoaded = ( _album.Count > 0 );
				MenuItem miParent = (MenuItem)sender;

				foreach (MenuItem mi in miParent.MenuItems)
				{
					mi.Enabled = bImageLoaded;
					mi.Checked = (this._selectedMode == (DisplayMode)mi.Index);
				}
			}
		}

		protected void menuImage_ChildClick (object sender, System.EventArgs e)
		{
			if (sender is MenuItem)
			{
				MenuItem mi = (MenuItem)sender;

				_selectedMode = (DisplayMode) mi.Index;
				switch (_selectedMode)                                  
				{
					default:
					case DisplayMode.ScaleToFit:
					case DisplayMode.StretchToFit:
						// Display entire image in window
						SetStyle(ControlStyles.ResizeRedraw, true);
						pnlPhoto.AutoScroll = false;
						pnlPhoto.Invalidate();
						break;

					case DisplayMode.ActualSize:
						// Display image at actual size.
						SetStyle(ControlStyles.ResizeRedraw, false);
						pnlPhoto.AutoScroll = true;
						pnlPhoto.Invalidate();
						break;
				}

				statusBar1.Invalidate();
			}
		}

		private void DefineContextMenu()
		{
			// Copy the View menu into ctxtMenuView
			foreach (MenuItem mi in menuView.MenuItems)
			{
				ctxtMenuView.MenuItems.Add
					(mi.Index, mi.CloneMenu());
			}
		}

		private void statusBar1_DrawItem(object sender, System.Windows.Forms.StatusBarDrawItemEventArgs sbdevent)
		{
			if (sbdevent.Panel == sbpnlImagePercent)
			{
				// Calculate the percent of the image shown
				int percent = 100;
				if (this._selectedMode == DisplayMode.ActualSize)
				{
					Photograph photo = _album.CurrentPhoto;

					Rectangle dr = pnlPhoto.ClientRectangle;
					int imgWidth = photo.Image.Width;
					int imgHeight = photo.Image.Height;
					percent = 100 * Math.Min(dr.Width, imgWidth)
						* Math.Min(dr.Height, imgHeight) / (imgWidth * imgHeight);						
				}

				// Calculate the rectangle to fill
				Rectangle fillRect = sbdevent.Bounds;
				fillRect.Width = sbdevent.Bounds.Width * percent / 100;

				// Draw the rectangle in the panel
				sbdevent.Graphics.FillRectangle(Brushes.SlateGray, fillRect);

				// Draw the text on top of the rectangle
				sbdevent.Graphics.DrawString(percent.ToString() + "%",
					sbdevent.Font,
					Brushes.White,
					sbdevent.Bounds);
			}
		}

		private void menuAdd_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();

			dlg.Title = "Add Photos";
			dlg.Multiselect = true;
			dlg.Filter
				= "Image Files (JPEG, GIF, BMP, etc.)|"
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

				statusBar1.ShowPanels = false;
				statusBar1.Text
					= String.Format("Loading {0} Files",
					files.Length);

				int index = 0;
				foreach (string s in files)
				{
					Photograph photo = new Photograph(s);

					// Add the file (if not already present)
					index = _album.IndexOf(photo);
					if (index < 0)
					{
						index = _album.Add(photo);
						_bAlbumChanged = true;
					}
				}

				dlg.Dispose();
				this.Invalidate();
			}
		}

		private void menuRemove_Click(object sender, System.EventArgs e)
		{
			if (_album.Count > 0)
			{
				_album.RemoveAt(_album.CurrentPosition);
				_bAlbumChanged = true;
			}

			this.Invalidate();
		}

		private void menuNext_Click(object sender, System.EventArgs e)
		{
			if (_album.CurrentNext())
			{
				this.Invalidate();
			}
		}

		private void menuPrevious_Click(object sender, System.EventArgs e)
		{
			if (_album.CurrentPrev())
			{
				this.Invalidate();
			}
		}

		private void SetTitleBar()
		{
			Version ver = new Version(Application.ProductVersion);

			if (_album.FileName == null)
			{
				this.Text = String.Format("MyPhotos {0:#}.{1:#}", ver.Major, ver.Minor);
			}
			else 
			{
				string baseFile = Path.GetFileNameWithoutExtension(_album.FileName);
				this.Text = String.Format("{0} - MyPhotos {1:#}.{2:#}",
					baseFile, ver.Major, ver.Minor);
			}
		}

		private void menuNew_Click(object sender, System.EventArgs e)
		{
			if (this.CloseCurrentAlbum() == true) 
			{
				// Make sure the window is redrawn
				this.Invalidate();
			}
		}

		private void menuSaveAs_Click(object sender, System.EventArgs e)
		{
			SaveFileDialog dlg = new SaveFileDialog();

			dlg.Title = "Save Album";
			dlg.DefaultExt = "abm";
			dlg.Filter = "Album files (*.abm)|*.abm|"
				+ "All files|*.*";
			dlg.InitialDirectory = PhotoAlbum.DefaultDir;
			dlg.RestoreDirectory = true;

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				// Record the new album name
				_album.FileName = dlg.FileName;

				// Use Save handler to store the album
				menuSave_Click(sender, e);

				// Update the title bar to include the new name
				SetTitleBar();
			}

			dlg.Dispose();
		}

		private void menuSave_Click(object sender, System.EventArgs e)
		{
			if (_album.FileName == null)
			{
				// Need to select an album file
				menuSaveAs_Click(sender, e);
			}
			else
			{
				try
				{
					// Save the album in the current file
					_album.Save();
					_bAlbumChanged = false;
				}
				catch (Exception ex)
				{
					string msg = "Unable to save file {0}"
						+ " - {1}\nWould you like to save"
						+ " the album in an alternate file?";
					DialogResult result = MessageBox.Show(this,
						String.Format(msg, _album.FileName, ex.Message),
						"Save Album Error",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Error,
						MessageBoxDefaultButton.Button2);
					if (result == DialogResult.Yes)
					{
						menuSaveAs_Click(sender, e);
					}
				}
			}
		}

		private void menuOpen_Click(object sender, System.EventArgs e)
		{
			// Save the existing album, if necessary
			if (this.CloseCurrentAlbum() == false)
			{
				// Cancel this operation
				return;
			}

			// Allow user to select a new album
			OpenFileDialog dlg = new OpenFileDialog();

			dlg.Title = "Open Album";
			dlg.Filter = "Album files (*.abm)|*.abm|"
				+ "All files (*.*)|*.*";
			dlg.InitialDirectory = PhotoAlbum.DefaultDir;
			dlg.RestoreDirectory = true;

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				try
				{
					// Open the new album
					_album.Open(dlg.FileName);

					_album.FileName = dlg.FileName;
					_bAlbumChanged = false;
					this.Invalidate();
				}
				catch (Exception ex)
				{
					MessageBox.Show(this,
						"Unable to open file " + dlg.FileName + "\n (" + ex.Message + ")",
						"Open Album Error",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				}
			}

			dlg.Dispose();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			if (_album.Count > 0)
			{
				// Paint the current image
				Photograph photo = _album.CurrentPhoto;

				// Update the status bar.
				sbpnlFileName.Text = photo.Caption;
				sbpnlImageSize.Text = String.Format("{0} x {1}",
					photo.Image.Width,
					photo.Image.Height);
				sbpnlFileIndex.Text = String.Format("{0}/{1}",					
					_album.CurrentPosition+1,
					_album.Count);
				statusBar1.ShowPanels = true;
			}
			else
			{
				// Indicate the album is empty
				e.Graphics.Clear(SystemColors.Control);

				statusBar1.Text = "No Photos in Album";
				statusBar1.ShowPanels = false;
			}

			base.OnPaint(e);
			pnlPhoto.Invalidate();
			statusBar1.Invalidate();
		}

		private void pnlPhoto_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			if (_album.Count > 0)
			{
				Photograph photo = _album.CurrentPhoto;
				Graphics g = e.Graphics;

				switch (_selectedMode)
				{
					default:
					case DisplayMode.ScaleToFit:
						// Preserve aspect ratio of image
						g.DrawImage(photo.Image, photo.ScaleToFit(pnlPhoto.DisplayRectangle));
						break;

					case DisplayMode.StretchToFit:
						// Fill entire window with the image
						g.DrawImage(photo.Image, pnlPhoto.DisplayRectangle);
						break;

					case DisplayMode.ActualSize:
						// Draw appropriate portion of image
						g.DrawImage(photo.Image,
							pnlPhoto.AutoScrollPosition.X,
							pnlPhoto.AutoScrollPosition.Y,
							photo.Image.Width,
							photo.Image.Height);
						pnlPhoto.AutoScrollMinSize = photo.Image.Size;
						break;
				}
			}
			else
			{
				// No image to paint
				e.Graphics.Clear(SystemColors.Control);
			}
		}

		protected bool CloseCurrentAlbum()
		{
			if (_bAlbumChanged)
			{
				// Offer to save the current album
				string msg;
				if (_album.FileName == null)
					msg = "Do you want to save the "
						+ "current album?";
				else
					msg = String.Format("Do you want to "
						+ "save your changes to \n{0}?",
						_album.FileName);

				DialogResult result
					= MessageBox.Show(this, msg,
					"Save Current Album?",
					MessageBoxButtons.YesNoCancel,
					MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
					menuSave_Click(this,EventArgs.Empty);
				else if (result == DialogResult.Cancel)
				{
					// Do not close the album
					return false;
				}
			}

			// Close the album and return true
			if (_album != null)
				_album.Dispose();
			_album = new PhotoAlbum();
			SetTitleBar();
			_bAlbumChanged = false;
			return true;
		}

		protected override void OnClosing(CancelEventArgs ce)
		{
			if (this.CloseCurrentAlbum() == false)
				ce.Cancel = true;
			else
				ce.Cancel = false;

			base.OnClosing(ce);
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			CaptionDlg dlg = new CaptionDlg();

			dlg.ShowDialog();
		}

		private void menuEdit_Popup(object sender, System.EventArgs e)
		{
			menuCaption.Enabled = (_album.Count > 0);
		}

		private void menuCaption_Click(object sender, System.EventArgs e)
		{
			Photograph photo = _album.CurrentPhoto;
			if (photo == null)
				return;    // no current photo

			using (CaptionDlg dlg = new CaptionDlg())
			{
				dlg.ImageLabel = photo.FileName;
				dlg.Caption = photo.Caption;

				if (dlg.ShowDialog() == DialogResult.OK)
				{
					photo.Caption = dlg.Caption;
					this._bAlbumChanged = true;

					sbpnlFileName.Text = photo.Caption;
					statusBar1.Invalidate();
				}
			}
		}

		// end of MainForm class
	}
}
