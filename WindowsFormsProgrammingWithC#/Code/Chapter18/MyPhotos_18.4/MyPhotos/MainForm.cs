using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Drawing.Printing;

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
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuPixelData;
		private System.Windows.Forms.MenuItem menuPhotoProp;
		private System.Windows.Forms.MenuItem menuAlbumProp;
		private System.Windows.Forms.ToolBar toolBarMain;
		private System.Windows.Forms.ImageList imageListToolBar;
		private System.Windows.Forms.ToolBarButton tbbNew;
		private System.Windows.Forms.ToolBarButton tbbOpen;
		private System.Windows.Forms.ToolBarButton tbbSave;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton tbbPrevious;
		private System.Windows.Forms.ToolBarButton tbbNext;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton tbbImage;
		private System.Windows.Forms.ContextMenu ctxtMenuView;
		private System.Windows.Forms.ContextMenu ctxtMenuImage;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton tbbPixelData;
		private System.Windows.Forms.MenuItem menuSlideShow;
		private System.ComponentModel.IContainer components;

		public MainForm()
		{
			// Required for Windows Form Designer support
			InitializeComponent();

			// Other initialization
			menuNew_Click(this, EventArgs.Empty);
			DefineContextMenu();
			InitToolBarButtons();
		}

		public MainForm(string albumFile)
			: this()
		{
			_album = new PhotoAlbum();
			_album.Open(albumFile);
			SetTitleBar();
		}

		protected PhotoAlbum _album;
		protected bool _bAlbumChanged = false;

		private PixelDlg _dlgPixel = null;
		private int _nPixelDlgIndex;
		private bool ctrlKeyHeld = false;

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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
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
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuPhotoProp = new System.Windows.Forms.MenuItem();
			this.menuAlbumProp = new System.Windows.Forms.MenuItem();
			this.menuView = new System.Windows.Forms.MenuItem();
			this.menuImage = new System.Windows.Forms.MenuItem();
			this.menuScale = new System.Windows.Forms.MenuItem();
			this.menuStretch = new System.Windows.Forms.MenuItem();
			this.menuActual = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuNext = new System.Windows.Forms.MenuItem();
			this.menuPrevious = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuPixelData = new System.Windows.Forms.MenuItem();
			this.menuSlideShow = new System.Windows.Forms.MenuItem();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.sbpnlFileName = new System.Windows.Forms.StatusBarPanel();
			this.sbpnlImageSize = new System.Windows.Forms.StatusBarPanel();
			this.sbpnlFileIndex = new System.Windows.Forms.StatusBarPanel();
			this.sbpnlImagePercent = new System.Windows.Forms.StatusBarPanel();
			this.pnlPhoto = new System.Windows.Forms.Panel();
			this.toolBarMain = new System.Windows.Forms.ToolBar();
			this.tbbNew = new System.Windows.Forms.ToolBarButton();
			this.tbbOpen = new System.Windows.Forms.ToolBarButton();
			this.tbbSave = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.tbbPrevious = new System.Windows.Forms.ToolBarButton();
			this.tbbNext = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.tbbImage = new System.Windows.Forms.ToolBarButton();
			this.ctxtMenuImage = new System.Windows.Forms.ContextMenu();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.tbbPixelData = new System.Windows.Forms.ToolBarButton();
			this.imageListToolBar = new System.Windows.Forms.ImageList(this.components);
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
			this.menuFile.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
			this.menuFile.Text = "&File";
			// 
			// menuNew
			// 
			this.menuNew.Index = 0;
			this.menuNew.MergeType = System.Windows.Forms.MenuMerge.Remove;
			this.menuNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
			this.menuNew.Text = "&New";
			this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
			// 
			// menuOpen
			// 
			this.menuOpen.Index = 1;
			this.menuOpen.MergeOrder = 1;
			this.menuOpen.MergeType = System.Windows.Forms.MenuMerge.Remove;
			this.menuOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.menuOpen.Text = "&Open";
			this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 2;
			this.menuItem1.MergeOrder = 3;
			this.menuItem1.Text = "-";
			// 
			// menuSave
			// 
			this.menuSave.Index = 3;
			this.menuSave.MergeOrder = 4;
			this.menuSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.menuSave.Text = "&Save";
			this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
			// 
			// menuSaveAs
			// 
			this.menuSaveAs.Index = 4;
			this.menuSaveAs.MergeOrder = 5;
			this.menuSaveAs.Text = "Save &As";
			this.menuSaveAs.Click += new System.EventHandler(this.menuSaveAs_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 5;
			this.menuItem4.MergeOrder = 6;
			this.menuItem4.Text = "-";
			// 
			// menuExit
			// 
			this.menuExit.Index = 6;
			this.menuExit.MergeOrder = 2;
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
																					 this.menuPhotoProp,
																					 this.menuAlbumProp});
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
			// menuItem2
			// 
			this.menuItem2.Index = 2;
			this.menuItem2.Text = "-";
			// 
			// menuPhotoProp
			// 
			this.menuPhotoProp.Enabled = false;
			this.menuPhotoProp.Index = 3;
			this.menuPhotoProp.Text = "&Photo Properties...";
			this.menuPhotoProp.Click += new System.EventHandler(this.menuPhotoProp_Click);
			// 
			// menuAlbumProp
			// 
			this.menuAlbumProp.Index = 4;
			this.menuAlbumProp.Text = "A&lbum Properties...";
			this.menuAlbumProp.Click += new System.EventHandler(this.menuAlbumProp_Click);
			// 
			// menuView
			// 
			this.menuView.Index = 2;
			this.menuView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuImage,
																					 this.menuItem5,
																					 this.menuNext,
																					 this.menuPrevious,
																					 this.menuItem3,
																					 this.menuPixelData,
																					 this.menuSlideShow});
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
			// menuItem3
			// 
			this.menuItem3.Index = 4;
			this.menuItem3.Text = "-";
			// 
			// menuPixelData
			// 
			this.menuPixelData.Index = 5;
			this.menuPixelData.Text = "Pi&xel Data...";
			this.menuPixelData.Click += new System.EventHandler(this.menuPixelData_Click);
			// 
			// menuSlideShow
			// 
			this.menuSlideShow.Index = 6;
			this.menuSlideShow.Text = "&Slide Show...";
			this.menuSlideShow.Click += new System.EventHandler(this.menuSlideShow_Click);
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
			this.pnlPhoto.AllowDrop = true;
			this.pnlPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlPhoto.Location = new System.Drawing.Point(0, 25);
			this.pnlPhoto.Name = "pnlPhoto";
			this.pnlPhoto.Size = new System.Drawing.Size(292, 226);
			this.pnlPhoto.TabIndex = 3;
			this.pnlPhoto.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlPhoto_DragEnter);
			this.pnlPhoto.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPhoto_Paint);
			this.pnlPhoto.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlPhoto_DragDrop);
			this.pnlPhoto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlPhoto_MouseMove);
			this.pnlPhoto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlPhoto_MouseDown);
			// 
			// toolBarMain
			// 
			this.toolBarMain.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						   this.tbbNew,
																						   this.tbbOpen,
																						   this.tbbSave,
																						   this.toolBarButton1,
																						   this.tbbPrevious,
																						   this.tbbNext,
																						   this.toolBarButton2,
																						   this.tbbImage,
																						   this.toolBarButton3,
																						   this.tbbPixelData});
			this.toolBarMain.ButtonSize = new System.Drawing.Size(16, 16);
			this.toolBarMain.DropDownArrows = true;
			this.toolBarMain.ImageList = this.imageListToolBar;
			this.toolBarMain.Name = "toolBarMain";
			this.toolBarMain.ShowToolTips = true;
			this.toolBarMain.Size = new System.Drawing.Size(292, 25);
			this.toolBarMain.TabIndex = 4;
			this.toolBarMain.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarMain.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarMain_ButtonClick);
			// 
			// tbbNew
			// 
			this.tbbNew.ImageIndex = 0;
			this.tbbNew.ToolTipText = "Create album";
			// 
			// tbbOpen
			// 
			this.tbbOpen.ImageIndex = 1;
			this.tbbOpen.ToolTipText = "Open album";
			// 
			// tbbSave
			// 
			this.tbbSave.ImageIndex = 2;
			this.tbbSave.ToolTipText = "Save album";
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbPrevious
			// 
			this.tbbPrevious.ImageIndex = 3;
			this.tbbPrevious.ToolTipText = "Previous image";
			// 
			// tbbNext
			// 
			this.tbbNext.ImageIndex = 4;
			this.tbbNext.ToolTipText = "Next image";
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbImage
			// 
			this.tbbImage.DropDownMenu = this.ctxtMenuImage;
			this.tbbImage.ImageIndex = 5;
			this.tbbImage.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.tbbImage.ToolTipText = "Set display mode";
			// 
			// ctxtMenuImage
			// 
			this.ctxtMenuImage.Popup += new System.EventHandler(this.menuImage_Popup);
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbPixelData
			// 
			this.tbbPixelData.ImageIndex = 6;
			this.tbbPixelData.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.tbbPixelData.ToolTipText = "Show pixel data";
			// 
			// imageListToolBar
			// 
			this.imageListToolBar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageListToolBar.ImageSize = new System.Drawing.Size(16, 16);
			this.imageListToolBar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListToolBar.ImageStream")));
			this.imageListToolBar.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.ContextMenu = this.ctxtMenuView;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.pnlPhoto,
																		  this.toolBarMain,
																		  this.statusBar1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
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
			if (sender is Menu)
			{
				bool bImageLoaded = ( _album.Count > 0 );
				Menu miParent = (Menu)sender;

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
				ctxtMenuView.MenuItems.Add(mi.Index, mi.CloneMenu());
			}

			// Copy the Image menu into ctxtMenuImage
			foreach (MenuItem mi in menuImage.MenuItems)
			{
				ctxtMenuImage.MenuItems.Add(mi.Index, mi.CloneMenu());
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
				sbpnlFileName.Text = _album.CurrentDisplayText;
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
			// Update PixelDlg if photo has changed
			if ((_dlgPixel != null) && (_nPixelDlgIndex != _album.CurrentPosition))
			{
				_nPixelDlgIndex = _album.CurrentPosition;
				Point p = pnlPhoto.PointToClient(Form.MousePosition);
				UpdatePixelData(p.X, p.Y);
			}

			// Paint the current photo, if any
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

		private void menuEdit_Popup(object sender, System.EventArgs e)
		{
			menuPhotoProp.Enabled = (_album.Count > 0);
		}

		private void menuPixelData_Click(object sender, System.EventArgs e)
		{
			if (_dlgPixel == null || _dlgPixel.IsDisposed)
			{
				_dlgPixel = PixelDlg.GlobalDialog;
			}

			_nPixelDlgIndex = _album.CurrentPosition;
			Point p = pnlPhoto.PointToClient(Form.MousePosition);
			UpdatePixelData(p.X, p.Y);
			AssignPixelToggle(true);

			_dlgPixel.Show();
		}

		protected void UpdatePixelData(int xPos, int yPos)
		{
			if (IsMdiChild)
				_dlgPixel = PixelDlg.GlobalDialog;

			if (_dlgPixel == null || !_dlgPixel.Visible)
				return;

			Photograph photo = _album.CurrentPhoto;
			Rectangle r = pnlPhoto.ClientRectangle;
			if (photo == null || !(r.Contains(xPos,yPos)))
			{
				_dlgPixel.Text = ((photo == null) ? " " : photo.Caption);
				_dlgPixel.XVal = 0;
				_dlgPixel.YVal = 0;
				_dlgPixel.RedVal = 0;
				_dlgPixel.GreenVal = 0;
				_dlgPixel.BlueVal = 0;
				_dlgPixel.Update();
				return;
			}

			_dlgPixel.Text = photo.Caption;

			// Calc x and y position in the photo
			int x = 0, y = 0;
			Bitmap bmp = photo.Image;
			switch (this._selectedMode)
			{
				case DisplayMode.ActualSize:
					// Panel coords equal image coords
					x = xPos;
					y = yPos;
					break;

				case DisplayMode.StretchToFit:
					// Translate panel coords to image
					x = xPos * bmp.Width / r.Width;
					y = yPos * bmp.Height / r.Height;
					break;

				case DisplayMode.ScaleToFit:
					// Determine image rectangle.
					Rectangle r2 = photo.ScaleToFit(r);

					if (!r2.Contains(xPos, yPos))
						return;    // Mouse outside image

					// Translate r2 coords to image
					x = (xPos - r2.Left) * bmp.Width / r2.Width;
					y = (yPos - r2.Top) * bmp.Height / r2.Height;
					break;
			}

			// Extract color at calculated location
			Color c = bmp.GetPixel(x, y);

			// Update PixelDlg with new values
			_dlgPixel.XVal = x;
			_dlgPixel.YVal = y;
			_dlgPixel.RedVal = c.R;
			_dlgPixel.GreenVal = c.G;
			_dlgPixel.BlueVal = c.B;
			_dlgPixel.Update();
		}

		private void pnlPhoto_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			UpdatePixelData(e.X, e.Y);
		}

		private void menuPhotoProp_Click(object sender, System.EventArgs e)
		{
			if (_album.CurrentPhoto == null)
				return;

			using (PhotoEditDlg dlg = new PhotoEditDlg(_album))
			{
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					_bAlbumChanged = dlg.HasChanged;
					if (_bAlbumChanged)
					{
						// Redraw to pick up any changes
						this.Invalidate();
					}
				}
			}
		}

		private void menuAlbumProp_Click(object sender, System.EventArgs e)
		{
			using (AlbumEditDlg dlg = new AlbumEditDlg(_album))
			{
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					// Update window with changes
					this._bAlbumChanged = true;
					SetTitleBar();
					this.Invalidate();
				}
			}
		}

		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			switch (e.KeyChar)
			{
				case '+':
					e.Handled = true;
					menuNext.PerformClick();
					break;

				case '-':
					e.Handled = true;
					menuPrevious.PerformClick();
					break;

				default:  // do nothing
					break;
			}

			base.OnKeyPress(e);
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.PageUp:
					e.Handled = true;
					menuPrevious.PerformClick();
					break;

				case Keys.PageDown:
					e.Handled = true;
					menuNext.PerformClick();
					break;

				case Keys.ControlKey:
					ctrlKeyHeld = true;
					pnlPhoto.Cursor = Cursors.SizeWE;
					this.ContextMenu = null;
					break;

				default: // do nothing
					break;
			}

			base.OnKeyDown(e);
		}

		protected override void OnKeyUp(KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.ControlKey:
					ReleaseControlKey();
					break;

				default:	// do nothing
					break;
			}

			base.OnKeyUp(e);
		}

		private void pnlPhoto_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (ctrlKeyHeld)
			{
				switch (e.Button)
				{
					case MouseButtons.Left:
						menuPrevious.PerformClick();
						break;

					case MouseButtons.Right:
						menuNext.PerformClick();
						break;

					default: // do nothing
						break;
				}
			}
			else
			{
				// Initiate drag and drop for this image
				Photograph photo = _album.CurrentPhoto;
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

					// Initiate drag and drop
					pnlPhoto.DoDragDrop(data, DragDropEffects.Copy);
				}
			}
		}

		private void ReleaseControlKey()
		{
			ctrlKeyHeld = false;
			pnlPhoto.Cursor = Cursors.Default;
			this.ContextMenu = ctxtMenuView;
		}

		protected override void OnDeactivate(EventArgs e)
		{
			if (ctrlKeyHeld)
				ReleaseControlKey();

			base.OnDeactivate(e);
		}

		protected override void OnMenuStart(EventArgs e)
		{
			if (ctrlKeyHeld)
				ReleaseControlKey();

			base.OnMenuStart(e);
		}

		private void InitToolBarButtons()	
		{
			tbbNew.Tag = menuNew;
			tbbOpen.Tag = menuOpen;
			tbbSave.Tag = menuSave;

			tbbPrevious.Tag = menuPrevious;
			tbbNext.Tag = menuNext;
		}

		private void toolBarMain_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			MenuItem mi = e.Button.Tag as MenuItem;
			if (mi != null)
				mi.PerformClick();

			// Handle Pixel Data button
			if (e.Button == tbbPixelData)
			{
				if (e.Button.Pushed)
				{
					// Display pixel dialog
					menuPixelData.PerformClick();
				}
				else if (this._dlgPixel != null && _dlgPixel.Visible)
				{
					// Hide pixel dialog
					_dlgPixel.Hide();
				}

				// Update the button settings
				AssignPixelToggle(e.Button.Pushed);
			}
		}

		protected void AssignPixelToggle(bool push)
		{
			tbbPixelData.Pushed = push;
			if (push)
			{
				tbbPixelData.ImageIndex = 7;
				tbbPixelData.ToolTipText = "Hide pixel data";
			}
			else
			{
				tbbPixelData.ImageIndex = 6;
				tbbPixelData.ToolTipText = "Show pixel data";
			}
		}

		protected override void OnActivated(EventArgs e)
		{
			// Update toggle button if required
			if (_dlgPixel == null || _dlgPixel.IsDisposed)
				AssignPixelToggle(false);
			else
				AssignPixelToggle(_dlgPixel.Visible);

			base.OnActivated(e);
		}

		protected override void OnLoad(EventArgs e)
		{
			if (IsMdiChild)
			{
				menuExit.Text = "&Close";
				toolBarMain.Visible = false;

				base.OnLoad(e);
			}
		}

		internal void ClickSaveMenu()
		{
			menuSave.PerformClick();
		}

		internal void ClickPreviousMenu()
		{
			menuPrevious.PerformClick();
		}

		internal void ClickNextMenu()
		{
			menuNext.PerformClick();
		}

		public string AlbumFile
		{
			get { return _album.FileName; }
		}

		public string AlbumTitle
		{
			get { return _album.Title; }
		}

		protected override void OnLeave(EventArgs e)
		{
			if (IsMdiChild && ctrlKeyHeld)
				ReleaseControlKey();

			base.OnLeave(e);
		}

		public void PrintCurrentImage(PrintPageEventArgs e)
		{
			Photograph photo = _album.CurrentPhoto;
			if (photo == null)
			{
				// nothing to print, so abort
				e.Cancel = true;
				return;
			}
			// Establish some useful shortcuts
			float leftMargin = e.MarginBounds.Left;
			float rightMargin = e.MarginBounds.Right;
			float topMargin = e.MarginBounds.Top;
			float bottomMargin = e.MarginBounds.Bottom;
			float printableWidth = e.MarginBounds.Width;
			float printableHeight = e.MarginBounds.Height;
			Graphics g = e.Graphics;

			Font printFont = new Font("Times New Roman", 11);
			float fontHeight = printFont.GetHeight(g);
			float spaceWidth = g.MeasureString(" ", printFont).Width;

			// Draw image in box 75% of shortest side
			float imageBoxLength;
			float xPos = leftMargin;
			float yPos = topMargin + fontHeight;
			if (printableWidth < printableHeight)
			{
				imageBoxLength = printableWidth * 75/100;
				yPos += imageBoxLength;
			}
			else
			{
				imageBoxLength = printableHeight * 75/100;
				xPos += imageBoxLength + spaceWidth;
			}

			// Draw image at start of the page
			Rectangle imageBox = new Rectangle((int)leftMargin + 1,
				(int)topMargin + 1,
				(int)imageBoxLength,
				(int)imageBoxLength);
			g.DrawImage(photo.Image, photo.ScaleToFit(imageBox));

			// Determine rectangle for text
			RectangleF printArea = new RectangleF(xPos, yPos,
				rightMargin - xPos,
				bottomMargin - yPos);

			PrintTextString(g, printFont,
				"FileName:", photo.FileName,
				ref printArea);
			PrintTextString(g, printFont,
				"Caption:", photo.Caption,
				ref printArea);
			PrintTextString(g, printFont,
				"Photographer:", photo.Photographer,
				ref printArea);
			PrintTextString(g, printFont,
				"Notes:", photo.Notes,
				ref printArea);
		}

		protected void PrintTextString(
			Graphics g,
			Font printFont,
			string name,
			string text,
			ref RectangleF printArea)
		{
			// Establish some useful shortcuts
			float leftMargin = printArea.Left;
			float rightMargin = printArea.Right;
			float topMargin = printArea.Top;
			float bottomMargin = printArea.Bottom;

			float fontHeight = printFont.GetHeight(g);
			float xPos = printArea.Left;
			float yPos = topMargin + fontHeight;

			float spaceWidth = g.MeasureString(" ", printFont).Width;
			float nameWidth = g.MeasureString(name, printFont).Width;

			if (!printArea.Contains(xPos + nameWidth, yPos))
			{
				// Does not fit, so abort
				return;
			}

			g.DrawString(name, printFont, Brushes.Black, new PointF(xPos, yPos));
			leftMargin += nameWidth + spaceWidth;
			xPos = leftMargin;

			// Draw text, use multi-lines if necessary
			string[] words = text.Split(" \r\t\n\0".ToCharArray());
			foreach (string word in words)
			{
				float wordWidth = g.MeasureString(word, printFont).Width;
				if (wordWidth == 0.0)
					continue;

				if (xPos + wordWidth > rightMargin)
				{
					// Start a new line
					xPos = leftMargin;
					yPos += fontHeight;
					if (yPos > bottomMargin)
					{
						// no more page, abort foreach loop
						break;
					}
				}

				g.DrawString(word, printFont,
					Brushes.Black,
					new PointF(xPos, yPos));
				xPos += wordWidth;
			}

			// Adjust print area based on drawn text
			printArea.Y = yPos;
			printArea.Height = bottomMargin - yPos;  
		}

		private void menuSlideShow_Click(object sender, System.EventArgs e)
		{
			using (SlideShowForm f = new SlideShowForm(_album))
			{
				// Display slide show as modal dialog
				f.ShowDialog();
			}
		}

		private void pnlPhoto_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}

		private void pnlPhoto_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
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
					index = _album.IndexOf(photo);
					if (index < 0)
					{
						index = _album.Add(photo);
						_bAlbumChanged = true;
					}
				}
			}

			if (index >= 0)
			{
				// Show the last image added
				_album.CurrentPosition = index;
				Invalidate();
			}
		}



		// end of MainForm class
	}
}
