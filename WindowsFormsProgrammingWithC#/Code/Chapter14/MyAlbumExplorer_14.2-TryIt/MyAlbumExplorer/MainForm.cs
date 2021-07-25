using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

using Manning.MyPhotoAlbum;

namespace MyAlbumExplorer
{
	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuFile;
		private System.Windows.Forms.MenuItem menuEdit;
		private System.Windows.Forms.MenuItem menuView;
		private System.Windows.Forms.MenuItem menuLargeIcons;
		private System.Windows.Forms.MenuItem menuSmallIcons;
		private System.Windows.Forms.MenuItem menuList;
		private System.Windows.Forms.MenuItem menuDetails;
		private System.Windows.Forms.MenuItem menuExit;
		private System.Windows.Forms.ListView listViewMain;
		private System.Windows.Forms.ImageList imageListLarge;
		private System.Windows.Forms.ImageList imageListSmall;
		private System.ComponentModel.IContainer components;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private const int PhotoIndex = 0;
		private const int AlbumIndex = 1;
		private const int ErrorIndex = 2;

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
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuFile = new System.Windows.Forms.MenuItem();
			this.menuExit = new System.Windows.Forms.MenuItem();
			this.menuEdit = new System.Windows.Forms.MenuItem();
			this.menuView = new System.Windows.Forms.MenuItem();
			this.menuLargeIcons = new System.Windows.Forms.MenuItem();
			this.menuSmallIcons = new System.Windows.Forms.MenuItem();
			this.menuList = new System.Windows.Forms.MenuItem();
			this.menuDetails = new System.Windows.Forms.MenuItem();
			this.listViewMain = new System.Windows.Forms.ListView();
			this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
			this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
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
																					 this.menuExit});
			this.menuFile.Text = "&File";
			// 
			// menuExit
			// 
			this.menuExit.Index = 0;
			this.menuExit.Text = "E&xit";
			this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
			// 
			// menuEdit
			// 
			this.menuEdit.Index = 1;
			this.menuEdit.Text = "&Edit";
			// 
			// menuView
			// 
			this.menuView.Index = 2;
			this.menuView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuLargeIcons,
																					 this.menuSmallIcons,
																					 this.menuList,
																					 this.menuDetails});
			this.menuView.Text = "&View";
			this.menuView.Popup += new System.EventHandler(this.menuView_Popup);
			// 
			// menuLargeIcons
			// 
			this.menuLargeIcons.Checked = true;
			this.menuLargeIcons.Index = 0;
			this.menuLargeIcons.RadioCheck = true;
			this.menuLargeIcons.Text = "Lar&ge Icons";
			this.menuLargeIcons.Click += new System.EventHandler(this.menuLargeIcons_Click);
			// 
			// menuSmallIcons
			// 
			this.menuSmallIcons.Index = 1;
			this.menuSmallIcons.RadioCheck = true;
			this.menuSmallIcons.Text = "S&mall Icons";
			this.menuSmallIcons.Click += new System.EventHandler(this.menuSmallIcons_Click);
			// 
			// menuList
			// 
			this.menuList.Index = 2;
			this.menuList.RadioCheck = true;
			this.menuList.Text = "&List";
			this.menuList.Click += new System.EventHandler(this.menuList_Click);
			// 
			// menuDetails
			// 
			this.menuDetails.Index = 3;
			this.menuDetails.RadioCheck = true;
			this.menuDetails.Text = "&Details";
			this.menuDetails.Click += new System.EventHandler(this.menuDetails_Click);
			// 
			// listViewMain
			// 
			this.listViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewMain.LargeImageList = this.imageListLarge;
			this.listViewMain.Name = "listViewMain";
			this.listViewMain.Size = new System.Drawing.Size(392, 253);
			this.listViewMain.SmallImageList = this.imageListSmall;
			this.listViewMain.TabIndex = 0;
			// 
			// imageListLarge
			// 
			this.imageListLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageListLarge.ImageSize = new System.Drawing.Size(32, 32);
			this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
			this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// imageListSmall
			// 
			this.imageListSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageListSmall.ImageSize = new System.Drawing.Size(16, 16);
			this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
			this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(392, 253);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.listViewMain});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu1;
			this.Name = "MainForm";
			this.Text = "MyAlbumExplorer";
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

		protected override void OnLoad(EventArgs e)
		{
			// Assign title bar
			Version v = new Version(Application.ProductVersion);
			this.Text = String.Format("MyAlbumExplorer {0:#}.{1:#}", v.Major, v.Minor);

			LoadAlbumData(PhotoAlbum.DefaultDir);
		}

		private void menuView_Popup(object sender, System.EventArgs e)
		{
			View v = listViewMain.View;
			menuLargeIcons.Checked = (v == View.LargeIcon);
			menuSmallIcons.Checked = (v == View.SmallIcon);
			menuList.Checked = (v == View.List);
			menuDetails.Checked = (v == View.Details);
		}

		private void menuLargeIcons_Click(object sender, System.EventArgs e)
		{
			listViewMain.View = View.LargeIcon;
		}

		private void menuSmallIcons_Click(object sender, System.EventArgs e)
		{
			listViewMain.View = View.SmallIcon;
		}

		private void menuList_Click(object sender, System.EventArgs e)
		{
			listViewMain.View = View.List;
		}

		private void menuDetails_Click(object sender, System.EventArgs e)
		{
			listViewMain.View = View.Details;
		}

		private PhotoAlbum OpenAlbum(string fileName)
		{
			PhotoAlbum album = new PhotoAlbum();

			try
			{
				album.Open(fileName);
			}
			catch (Exception)
			{
				return null;
			}

			return album;
		}

		private void LoadAlbumData(string dir)
		{
			string[] albumFiles = Directory.GetFiles(dir, "*.abm");
			foreach (string s in albumFiles)
			{
				// Retrieve the information for this album
				PhotoAlbum.AlbumInfo info = PhotoAlbum.GetInfo(s);

				// Create a new list view item
				ListViewItem item = new ListViewItem();

				item.Text = Path.GetFileNameWithoutExtension(s);
				if (info.IsValid)
					item.ImageIndex = MainForm.AlbumIndex;
				else
					item.ImageIndex = MainForm.ErrorIndex;

				listViewMain.Items.Add(item);
			}
		}

		private void menuExit_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		// end of MainForm
	}
}
