using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Manning.MyPhotoAlbum;

namespace MyPhotos
{
	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pbxPhoto;
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

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MainForm()
		{
			// Required for Windows Form Designer support
			InitializeComponent();

			// Set the application title bar
			Version ver = new Version(Application.ProductVersion);
			this.Text = String.Format("MyPhotos {0:#}.{1:#}", ver.Major, ver.Minor);

			DefineContextMenu();
			_album = new PhotoAlbum();
		}

		protected PhotoAlbum _album;
		protected bool _bAlbumChanged = false;

		/// <summary>
		/// Mode settings for the View->Image submenu.
		/// The order here must correspond to the order
		/// of menus in the submenu.
		/// </summary>
		private PictureBoxSizeMode[] modeMenuArray
			= {
				  PictureBoxSizeMode.StretchImage,
				  PictureBoxSizeMode.Normal
			  };
		private int nSelectedImageMode = 0;


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
			this.pbxPhoto = new System.Windows.Forms.PictureBox();
			this.ctxtMenuView = new System.Windows.Forms.ContextMenu();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuFile = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuExit = new System.Windows.Forms.MenuItem();
			this.menuView = new System.Windows.Forms.MenuItem();
			this.menuImage = new System.Windows.Forms.MenuItem();
			this.menuStretch = new System.Windows.Forms.MenuItem();
			this.menuActual = new System.Windows.Forms.MenuItem();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.sbpnlFileName = new System.Windows.Forms.StatusBarPanel();
			this.sbpnlImageSize = new System.Windows.Forms.StatusBarPanel();
			this.sbpnlImagePercent = new System.Windows.Forms.StatusBarPanel();
			this.menuNew = new System.Windows.Forms.MenuItem();
			this.menuOpen = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuSave = new System.Windows.Forms.MenuItem();
			this.menuSaveAs = new System.Windows.Forms.MenuItem();
			this.menuEdit = new System.Windows.Forms.MenuItem();
			this.menuAdd = new System.Windows.Forms.MenuItem();
			this.menuRemove = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.sbpnlFileName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sbpnlImageSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sbpnlImagePercent)).BeginInit();
			this.SuspendLayout();
			// 
			// pbxPhoto
			// 
			this.pbxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbxPhoto.ContextMenu = this.ctxtMenuView;
			this.pbxPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbxPhoto.Name = "pbxPhoto";
			this.pbxPhoto.Size = new System.Drawing.Size(292, 273);
			this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbxPhoto.TabIndex = 1;
			this.pbxPhoto.TabStop = false;
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
			// menuItem1
			// 
			this.menuItem1.Index = 2;
			this.menuItem1.Text = "-";
			// 
			// menuExit
			// 
			this.menuExit.Index = 6;
			this.menuExit.Text = "E&xit";
			this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
			// 
			// menuView
			// 
			this.menuView.Index = 2;
			this.menuView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuImage});
			this.menuView.Text = "&View";
			// 
			// menuImage
			// 
			this.menuImage.Index = 0;
			this.menuImage.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuStretch,
																					  this.menuActual});
			this.menuImage.Text = "&Image";
			this.menuImage.Popup += new System.EventHandler(this.menuImage_Popup);
			// 
			// menuStretch
			// 
			this.menuStretch.Index = 0;
			this.menuStretch.Text = "S&tretch to Fit";
			this.menuStretch.Click += new System.EventHandler(this.menuImage_ChildClick);
			// 
			// menuActual
			// 
			this.menuActual.Index = 1;
			this.menuActual.Text = "&Actual Size";
			this.menuActual.Click += new System.EventHandler(this.menuImage_ChildClick);
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 251);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						  this.sbpnlFileName,
																						  this.sbpnlImageSize,
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
			// sbpnlImagePercent
			// 
			this.sbpnlImagePercent.Style = System.Windows.Forms.StatusBarPanelStyle.OwnerDraw;
			this.sbpnlImagePercent.Text = "statusBarPanel3";
			this.sbpnlImagePercent.ToolTipText = "Percent of Image Shown";
			this.sbpnlImagePercent.Width = 75;
			// 
			// menuNew
			// 
			this.menuNew.Index = 0;
			this.menuNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
			this.menuNew.Text = "&New";
			// 
			// menuOpen
			// 
			this.menuOpen.Index = 1;
			this.menuOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.menuOpen.Text = "&Open";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 5;
			this.menuItem4.Text = "-";
			// 
			// menuSave
			// 
			this.menuSave.Index = 3;
			this.menuSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.menuSave.Text = "&Save";
			// 
			// menuSaveAs
			// 
			this.menuSaveAs.Index = 4;
			this.menuSaveAs.Text = "Save &As";
			// 
			// menuEdit
			// 
			this.menuEdit.Index = 1;
			this.menuEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuAdd,
																					 this.menuRemove});
			this.menuEdit.Text = "&Edit";
			// 
			// menuAdd
			// 
			this.menuAdd.Index = 0;
			this.menuAdd.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
			this.menuAdd.Text = "&Add";
			// 
			// menuRemove
			// 
			this.menuRemove.Index = 1;
			this.menuRemove.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
			this.menuRemove.Text = "&Remove";
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.statusBar1,
																		  this.pbxPhoto});
			this.Menu = this.mainMenu1;
			this.MinimumSize = new System.Drawing.Size(200, 200);
			this.Name = "MainForm";
			this.Text = "MyPhotos";
			((System.ComponentModel.ISupportInitialize)(this.sbpnlFileName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sbpnlImageSize)).EndInit();
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

		private void menuLoad_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();

			dlg.Title = "Open Photo";
			dlg.Filter = "jpg files (*.jpg)|*.jpg"
				+ "|All files (*.*)|*.*";

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				try
				{
					statusBar1.ShowPanels = false;
					statusBar1.Text = "Loading " + dlg.FileName;
					
					pbxPhoto.Image = new Bitmap(dlg.OpenFile());
					
					statusBar1.Text = "Loaded " + dlg.FileName;
					this.sbpnlFileName.Text = dlg.FileName;
					this.sbpnlImageSize.Text = String.Format("{0:#} x {1:#}",
						pbxPhoto.Image.Width, pbxPhoto.Image.Height);
					statusBar1.ShowPanels = true;
				}
				catch (Exception ex)
				{
					// Handle exception
					statusBar1.Text = "Unable to load " + dlg.FileName;
					MessageBox.Show("Unable to load file: " + ex.Message);
				}
			}

			dlg.Dispose();		
		}

		private void menuExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void menuImage_ChildClick(object sender, System.EventArgs e)
		{
			if (sender is MenuItem)
			{
				MenuItem mi = (MenuItem)sender;

				nSelectedImageMode = mi.Index;
				pbxPhoto.SizeMode = modeMenuArray[mi.Index];

				pbxPhoto.Invalidate();  
				statusBar1.Invalidate();
			}
		}

		private void menuImage_Popup(object sender, System.EventArgs e)
		{
			if (sender is MenuItem) 
			{
				bool bImageLoaded = (pbxPhoto.Image != null);
				foreach (MenuItem mi in ((MenuItem)sender).MenuItems)
				{
					mi.Enabled = bImageLoaded;
					mi.Checked = (this.nSelectedImageMode == mi.Index);
				}
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
				if (pbxPhoto.SizeMode != PictureBoxSizeMode.StretchImage)
				{
					Rectangle dr = pbxPhoto.ClientRectangle;
					int imgWidth = pbxPhoto.Image.Width;
					int imgHeight = pbxPhoto.Image.Height;
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

		// end of MainForm class
	}
}
