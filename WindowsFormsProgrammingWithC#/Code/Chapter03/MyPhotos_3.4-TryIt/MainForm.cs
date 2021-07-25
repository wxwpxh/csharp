using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

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
		private System.Windows.Forms.MenuItem menuLoad;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuExit;
		private System.Windows.Forms.MenuItem menuView;
		private System.Windows.Forms.MenuItem menuImage;
		private System.Windows.Forms.MenuItem menuStretch;
		private System.Windows.Forms.MenuItem menuActual;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		/// <summary>
		/// Mode settings for the View->Image submenu.
		/// The order here must correspond to the order
		/// of menus in the submenu.
		/// </summary>
		private PictureBoxSizeMode[] modeMenuArray
			= {
				  PictureBoxSizeMode.StretchImage,
				  PictureBoxSizeMode.Normal,
				  PictureBoxSizeMode.CenterImage
			  };
		private System.Windows.Forms.MenuItem menuCounter;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuCenter;

		private int nSelectedImageMode = 0;

		public MainForm()
		{
			// Required for Windows Form Designer support
			InitializeComponent();

			// Set the application title bar
			Version ver = new Version(Application.ProductVersion);
			this.Text = String.Format("MyPhotos {0:#}.{1:#}", ver.Major, ver.Minor);
		}

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
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuFile = new System.Windows.Forms.MenuItem();
			this.menuLoad = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuExit = new System.Windows.Forms.MenuItem();
			this.menuView = new System.Windows.Forms.MenuItem();
			this.menuImage = new System.Windows.Forms.MenuItem();
			this.menuStretch = new System.Windows.Forms.MenuItem();
			this.menuActual = new System.Windows.Forms.MenuItem();
			this.menuCounter = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuCenter = new System.Windows.Forms.MenuItem();
			this.SuspendLayout();
			// 
			// pbxPhoto
			// 
			this.pbxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
																					  this.menuView});
			// 
			// menuFile
			// 
			this.menuFile.Index = 0;
			this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuLoad,
																					 this.menuItem1,
																					 this.menuExit});
			this.menuFile.Text = "&File";
			// 
			// menuLoad
			// 
			this.menuLoad.Index = 0;
			this.menuLoad.Shortcut = System.Windows.Forms.Shortcut.CtrlL;
			this.menuLoad.Text = "&Load";
			this.menuLoad.Click += new System.EventHandler(this.menuLoad_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 1;
			this.menuItem1.Text = "-";
			// 
			// menuExit
			// 
			this.menuExit.Index = 2;
			this.menuExit.Text = "E&xit";
			this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
			// 
			// menuView
			// 
			this.menuView.Index = 1;
			this.menuView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuImage,
																					 this.menuCounter});
			this.menuView.Text = "&View";
			// 
			// menuImage
			// 
			this.menuImage.Index = 0;
			this.menuImage.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuStretch,
																					  this.menuActual,
																					  this.menuCenter});
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
			// menuCounter
			// 
			this.menuCounter.Index = 1;
			this.menuCounter.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.menuItem2});
			this.menuCounter.Text = "&Counter";
			this.menuCounter.Popup += new System.EventHandler(this.menuCounter_Popup);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "Popup";
			// 
			// menuCenter
			// 
			this.menuCenter.Index = 2;
			this.menuCenter.Text = "&Center Image";
			this.menuCenter.Click += new System.EventHandler(this.menuImage_ChildClick);
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.pbxPhoto});
			this.Menu = this.mainMenu1;
			this.MinimumSize = new System.Drawing.Size(200, 200);
			this.Name = "MainForm";
			this.Text = "MyPhotos";
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
					pbxPhoto.Image = new Bitmap(dlg.OpenFile());
				}
				catch (Exception ex)
				{
					// Handle exception
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

		static int popupCount = 0;
		private void menuCounter_Popup(object sender, System.EventArgs e)
		{
			++ popupCount;
			MenuItem mi = new MenuItem();
			mi.Text = "Count " + popupCount.ToString();
			menuCounter.MenuItems.Add(mi);
		}

		// end of MainForm class
	}
}
