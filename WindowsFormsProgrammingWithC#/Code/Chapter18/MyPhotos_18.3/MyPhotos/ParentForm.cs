using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using Manning.MyPhotoAlbum;

namespace MyPhotos
{
	/// <summary>
	/// Summary description for ParentForm.
	/// </summary>
	public class ParentForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuFile;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuNew;
		private System.Windows.Forms.MenuItem menuExit;
		private System.Windows.Forms.MenuItem menuOpen;
		private System.Windows.Forms.ImageList imageListParent;
		private System.Windows.Forms.ToolBar toolBarParent;
		private System.Windows.Forms.ToolBarButton tbbNew;
		private System.Windows.Forms.ToolBarButton tbbOpen;
		private System.Windows.Forms.ToolBarButton tbbSave;
		private System.Windows.Forms.ToolBarButton tbbPrev;
		private System.Windows.Forms.ToolBarButton tbbSep;
		private System.Windows.Forms.ToolBarButton tbbNext;
		private System.Windows.Forms.MenuItem menuWindow;
		private System.Windows.Forms.MenuItem menuArrange;
		private System.Windows.Forms.MenuItem menuCascade;
		private System.Windows.Forms.MenuItem menuTileHorizontal;
		private System.Windows.Forms.MenuItem menuTileVertical;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuPageSetup;
		private System.Windows.Forms.MenuItem menuPrintPreview;
		private System.Windows.Forms.MenuItem menuPrint;
		private System.Drawing.Printing.PrintDocument printDoc;
		private System.ComponentModel.IContainer components;

		public ParentForm()
		{
			// Required for Windows Form Designer support
			InitializeComponent();

			// Initialize tool bar buttons
			tbbNew.Tag = menuNew;
			tbbOpen.Tag = menuOpen;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ParentForm));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuFile = new System.Windows.Forms.MenuItem();
			this.menuNew = new System.Windows.Forms.MenuItem();
			this.menuOpen = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuPageSetup = new System.Windows.Forms.MenuItem();
			this.menuPrintPreview = new System.Windows.Forms.MenuItem();
			this.menuPrint = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuExit = new System.Windows.Forms.MenuItem();
			this.menuWindow = new System.Windows.Forms.MenuItem();
			this.menuArrange = new System.Windows.Forms.MenuItem();
			this.menuCascade = new System.Windows.Forms.MenuItem();
			this.menuTileHorizontal = new System.Windows.Forms.MenuItem();
			this.menuTileVertical = new System.Windows.Forms.MenuItem();
			this.imageListParent = new System.Windows.Forms.ImageList(this.components);
			this.toolBarParent = new System.Windows.Forms.ToolBar();
			this.tbbNew = new System.Windows.Forms.ToolBarButton();
			this.tbbOpen = new System.Windows.Forms.ToolBarButton();
			this.tbbSave = new System.Windows.Forms.ToolBarButton();
			this.tbbSep = new System.Windows.Forms.ToolBarButton();
			this.tbbPrev = new System.Windows.Forms.ToolBarButton();
			this.tbbNext = new System.Windows.Forms.ToolBarButton();
			this.printDoc = new System.Drawing.Printing.PrintDocument();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuFile,
																					  this.menuWindow});
			// 
			// menuFile
			// 
			this.menuFile.Index = 0;
			this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuNew,
																					 this.menuOpen,
																					 this.menuItem1,
																					 this.menuPageSetup,
																					 this.menuPrintPreview,
																					 this.menuPrint,
																					 this.menuItem3,
																					 this.menuExit});
			this.menuFile.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
			this.menuFile.Text = "&File";
			// 
			// menuNew
			// 
			this.menuNew.Index = 0;
			this.menuNew.MergeType = System.Windows.Forms.MenuMerge.Replace;
			this.menuNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
			this.menuNew.Text = "&New";
			this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
			// 
			// menuOpen
			// 
			this.menuOpen.Index = 1;
			this.menuOpen.MergeOrder = 1;
			this.menuOpen.MergeType = System.Windows.Forms.MenuMerge.Replace;
			this.menuOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.menuOpen.Text = "&Open";
			this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 2;
			this.menuItem1.MergeType = System.Windows.Forms.MenuMerge.Remove;
			this.menuItem1.Text = "-";
			// 
			// menuPageSetup
			// 
			this.menuPageSetup.Index = 3;
			this.menuPageSetup.MergeOrder = 7;
			this.menuPageSetup.Text = "Page Set&up...";
			this.menuPageSetup.Click += new System.EventHandler(this.menuPageSetup_Click);
			// 
			// menuPrintPreview
			// 
			this.menuPrintPreview.Index = 4;
			this.menuPrintPreview.MergeOrder = 7;
			this.menuPrintPreview.Text = "Print Pre&view";
			this.menuPrintPreview.Click += new System.EventHandler(this.menuPrintPreview_Click);
			// 
			// menuPrint
			// 
			this.menuPrint.Index = 5;
			this.menuPrint.MergeOrder = 7;
			this.menuPrint.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
			this.menuPrint.Text = "&Print...";
			this.menuPrint.Click += new System.EventHandler(this.menuPrint_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 6;
			this.menuItem3.MergeOrder = 7;
			this.menuItem3.Text = "-";
			// 
			// menuExit
			// 
			this.menuExit.Index = 7;
			this.menuExit.MergeOrder = 7;
			this.menuExit.Text = "E&xit";
			this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
			// 
			// menuWindow
			// 
			this.menuWindow.Index = 1;
			this.menuWindow.MdiList = true;
			this.menuWindow.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuArrange,
																					   this.menuCascade,
																					   this.menuTileHorizontal,
																					   this.menuTileVertical});
			this.menuWindow.MergeOrder = 3;
			this.menuWindow.Text = "&Window";
			// 
			// menuArrange
			// 
			this.menuArrange.Index = 0;
			this.menuArrange.Text = "&Arrange Icons";
			this.menuArrange.Click += new System.EventHandler(this.menuArrange_Click);
			// 
			// menuCascade
			// 
			this.menuCascade.Index = 1;
			this.menuCascade.Text = "&Cascade";
			this.menuCascade.Click += new System.EventHandler(this.menuCascade_Click);
			// 
			// menuTileHorizontal
			// 
			this.menuTileHorizontal.Index = 2;
			this.menuTileHorizontal.Text = "Tile &Horizontal";
			this.menuTileHorizontal.Click += new System.EventHandler(this.menuTileHorizontal_Click);
			// 
			// menuTileVertical
			// 
			this.menuTileVertical.Index = 3;
			this.menuTileVertical.Text = "Tile &Vertical";
			this.menuTileVertical.Click += new System.EventHandler(this.menuTileVertical_Click);
			// 
			// imageListParent
			// 
			this.imageListParent.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageListParent.ImageSize = new System.Drawing.Size(16, 16);
			this.imageListParent.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListParent.ImageStream")));
			this.imageListParent.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// toolBarParent
			// 
			this.toolBarParent.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							 this.tbbNew,
																							 this.tbbOpen,
																							 this.tbbSave,
																							 this.tbbSep,
																							 this.tbbPrev,
																							 this.tbbNext});
			this.toolBarParent.DropDownArrows = true;
			this.toolBarParent.ImageList = this.imageListParent;
			this.toolBarParent.Name = "toolBarParent";
			this.toolBarParent.ShowToolTips = true;
			this.toolBarParent.Size = new System.Drawing.Size(592, 25);
			this.toolBarParent.TabIndex = 1;
			this.toolBarParent.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarParent.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarParent_ButtonClick);
			// 
			// tbbNew
			// 
			this.tbbNew.ImageIndex = 0;
			this.tbbNew.ToolTipText = "New";
			// 
			// tbbOpen
			// 
			this.tbbOpen.ImageIndex = 1;
			this.tbbOpen.ToolTipText = "Open";
			// 
			// tbbSave
			// 
			this.tbbSave.ImageIndex = 2;
			this.tbbSave.ToolTipText = "Save";
			// 
			// tbbSep
			// 
			this.tbbSep.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbPrev
			// 
			this.tbbPrev.ImageIndex = 3;
			this.tbbPrev.ToolTipText = "Previous";
			// 
			// tbbNext
			// 
			this.tbbNext.ImageIndex = 4;
			this.tbbNext.ToolTipText = "Next";
			// 
			// printDoc
			// 
			this.printDoc.DocumentName = "Image Document";
			this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
			// 
			// ParentForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 373);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.toolBarParent});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Menu = this.mainMenu1;
			this.Name = "ParentForm";
			this.Text = "ParentForm";
			this.ResumeLayout(false);

		}
		#endregion

		private void menuExit_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void menuNew_Click(object sender, System.EventArgs e)
		{
			MainForm newChild = new MainForm();
			newChild.MdiParent = this;
			newChild.Show();
		}

		/// <summary>
		/// Entry point for MDI application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new ParentForm());
		}

		private void menuOpen_Click(object sender, System.EventArgs e)
		{
			// Allow user to select a new album
			using (OpenFileDialog dlg = new OpenFileDialog())
			{
				dlg.Title = "Open Album";
				dlg.Filter = "abm files (*.abm)|*.abm|All files (*.*)|*.*";
				dlg.InitialDirectory = PhotoAlbum.DefaultDir;
				dlg.RestoreDirectory = true;

				if (dlg.ShowDialog() == DialogResult.OK)
				{
					try
					{
						// See if album is already open
						foreach (Form f in MdiChildren)
						{
							if (f is MainForm)
							{
								MainForm mf = (MainForm) f;
								if (mf.AlbumFile == dlg.FileName)
								{
									if (mf.WindowState == FormWindowState.Minimized)
									{
										mf.WindowState = FormWindowState.Normal;
									}
									mf.BringToFront();
									return;
								}
							}
						}

						// Open new child window for the album
						MainForm form = new MainForm(dlg.FileName);
						form.MdiParent = this;
						form.Show();
					}
					catch (Exception ex)
					{
						MessageBox.Show(this, "Unable to open file " + dlg.FileName + "\n (" + ex.Message + ")",
							"Open Album Error",
							MessageBoxButtons.OK,
							MessageBoxIcon.Error);
					}
				}
			}
		}

		private void toolBarParent_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			if (e.Button.Tag is MenuItem)
			{
				MenuItem mi = e.Button.Tag as MenuItem;
				mi.PerformClick();
				return;
			}

			// Must be MDI child button
			MainForm child = ActiveMdiChild as MainForm;
			if (child != null)
			{
				if (e.Button == tbbSave)
					child.ClickSaveMenu();
				else if (e.Button == tbbPrev)
					child.ClickPreviousMenu();
				else if (e.Button == tbbNext)
					child.ClickNextMenu();
			}
		}

		protected override void OnLoad(EventArgs e)
		{
			PixelDlg.GlobalMdiParent = this;
			SetTitleBar();

			base.OnLoad(e);
		}

		protected override void OnMdiChildActivate(System.EventArgs e)
		{
			SetTitleBar();
			base.OnMdiChildActivate(e);
		}

		protected void SetTitleBar()
		{
			Version ver = new Version(Application.ProductVersion);

			string titleBar = "{0} - MyPhotos MDI {1:#}.{2:#}";

			if (ActiveMdiChild is MainForm)
			{
				string albumTitle = ((MainForm)ActiveMdiChild).AlbumTitle;
				this.Text = String.Format(titleBar, albumTitle, ver.Major, ver.Minor);
			}
			else if (ActiveMdiChild is PixelDlg)
			{
				this.Text = String.Format(titleBar, "Pixel Data", ver.Major, ver.Minor);
			}
			else
			{
				this.Text = String.Format("MyPhotos MDI {0:#}.{1:#}", ver.Major, ver.Minor);
			}
		}

		private void menuArrange_Click(object sender, System.EventArgs e)
		{
			LayoutMdi(MdiLayout.ArrangeIcons);
		}

		private void menuCascade_Click(object sender, System.EventArgs e)
		{
			LayoutMdi(MdiLayout.Cascade);
		}

		private void menuTileHorizontal_Click(object sender, System.EventArgs e)
		{
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void menuTileVertical_Click(object sender, System.EventArgs e)
		{
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void menuPageSetup_Click(object sender, System.EventArgs e)
		{
			PageSetupDialog dlg = new PageSetupDialog();
			dlg.Document = printDoc;
			dlg.ShowDialog();
		}

		private void menuPrintPreview_Click(object sender, System.EventArgs e)
		{
			PrintPreviewDialog dlg = new PrintPreviewDialog();
			dlg.Document = printDoc;
			dlg.ShowDialog();
		}

		private void menuPrint_Click(object sender, System.EventArgs e)
		{
			PrintDialog dlg = new PrintDialog();
			dlg.Document = printDoc;
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				printDoc.Print();
			}
		}

		private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			MainForm f = ActiveMdiChild as MainForm;
			if (f != null)
				f.PrintCurrentImage(e);
			else
				e.Cancel = true;
		}

		// end of ParentForm
	}
}
