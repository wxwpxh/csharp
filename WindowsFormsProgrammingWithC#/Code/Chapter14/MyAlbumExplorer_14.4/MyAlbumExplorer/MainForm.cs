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
		private System.Windows.Forms.ColumnHeader columnName;
		private System.Windows.Forms.ColumnHeader columnTitle;
		private System.Windows.Forms.ColumnHeader columnPassword;
		private System.Windows.Forms.ColumnHeader columnSize;
		private System.Windows.Forms.MenuItem menuProperties;
		private System.Windows.Forms.MenuItem menuEditLabel;
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

		private const int AlbumNameColumn = 0;
		private const int AlbumTitleColumn = 1;
		private const int AlbumPwdColumn = 2;
		private const int AlbumSizeColumn = 3;

		private MyListViewComparer _comparer;

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
			this.menuEditLabel = new System.Windows.Forms.MenuItem();
			this.menuProperties = new System.Windows.Forms.MenuItem();
			this.menuView = new System.Windows.Forms.MenuItem();
			this.menuLargeIcons = new System.Windows.Forms.MenuItem();
			this.menuSmallIcons = new System.Windows.Forms.MenuItem();
			this.menuList = new System.Windows.Forms.MenuItem();
			this.menuDetails = new System.Windows.Forms.MenuItem();
			this.listViewMain = new System.Windows.Forms.ListView();
			this.columnName = new System.Windows.Forms.ColumnHeader();
			this.columnTitle = new System.Windows.Forms.ColumnHeader();
			this.columnPassword = new System.Windows.Forms.ColumnHeader();
			this.columnSize = new System.Windows.Forms.ColumnHeader();
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
			this.menuEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuEditLabel,
																					 this.menuProperties});
			this.menuEdit.Text = "&Edit";
			// 
			// menuEditLabel
			// 
			this.menuEditLabel.Index = 0;
			this.menuEditLabel.Text = "&Name";
			this.menuEditLabel.Click += new System.EventHandler(this.menuEditLabel_Click);
			// 
			// menuProperties
			// 
			this.menuProperties.Index = 1;
			this.menuProperties.Text = "&Properties...";
			this.menuProperties.Click += new System.EventHandler(this.menuProperties_Click);
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
			this.listViewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						   this.columnName,
																						   this.columnTitle,
																						   this.columnPassword,
																						   this.columnSize});
			this.listViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewMain.LabelEdit = true;
			this.listViewMain.LargeImageList = this.imageListLarge;
			this.listViewMain.Name = "listViewMain";
			this.listViewMain.Size = new System.Drawing.Size(392, 253);
			this.listViewMain.SmallImageList = this.imageListSmall;
			this.listViewMain.TabIndex = 0;
			this.listViewMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewMain_KeyDown);
			this.listViewMain.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listViewMain_AfterLabelEdit);
			this.listViewMain.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewMain_ColumnClick);
			// 
			// columnName
			// 
			this.columnName.Text = "Name";
			this.columnName.Width = 80;
			// 
			// columnTitle
			// 
			this.columnTitle.Text = "Title";
			this.columnTitle.Width = 100;
			// 
			// columnPassword
			// 
			this.columnPassword.Text = "Pwd";
			this.columnPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnPassword.Width = 40;
			// 
			// columnSize
			// 
			this.columnSize.Text = "Size";
			this.columnSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnSize.Width = 40;
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
			// Define the list view comparer
			_comparer = new MyListViewComparer(listViewMain);
			listViewMain.ListViewItemSorter = _comparer;
			listViewMain.Sorting = SortOrder.Ascending;

			// Assign title bar
			Version v = new Version(Application.ProductVersion);
			this.Text = String.Format("MyAlbumExplorer {0:#}.{1:#}", v.Major, v.Minor);

			// Load the default album data
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
				// See if we can open this album
				PhotoAlbum album = OpenAlbum(s);

				// Create a new list view item
				ListViewItem item = new ListViewItem();

				item.Text = Path.GetFileNameWithoutExtension(s);
				if (album != null)
				{
					item.Tag = album.FileName;
					item.ImageIndex = MainForm.AlbumIndex;

					// Add the subitems
					item.SubItems.Add(album.Title);
					bool hasPwd = (album.Password != null)
						&& (album.Password.Length > 0);
					item.SubItems.Add(hasPwd ? "y" : "n");
					item.SubItems.Add(album.Count.ToString());
				}
				else
				{
					item.ImageIndex = MainForm.ErrorIndex;
					item.SubItems.Add(item.Text);
					item.SubItems.Add("?");
					item.SubItems.Add("0");
				}

				listViewMain.Items.Add(item);
			}
		}

		private void menuExit_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void listViewMain_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
		{
			SortOrder prevOrder = listViewMain.Sorting;
			listViewMain.Sorting = SortOrder.None;
		
			if (e.Column == _comparer.SortColumn)
			{
				// Switch the sorting order
				if (prevOrder == SortOrder.Ascending)
					listViewMain.Sorting = SortOrder.Descending;
				else
					listViewMain.Sorting = SortOrder.Ascending;
			}
			else
			{
				// Define new sort column and reset order
				_comparer.SortColumn = e.Column;
				listViewMain.Sorting = SortOrder.Ascending;
			}
		}

		private void menuProperties_Click(object sender, System.EventArgs e)
		{
			if (listViewMain.SelectedItems.Count <= 0)
				return;

			ListViewItem item = listViewMain.SelectedItems[0];
			DisplayAlbumProperties(item);
		}
		
		private void DisplayAlbumProperties(ListViewItem item)
		{
			string fileName = item.Tag as string;

			PhotoAlbum album = null;
			if (fileName != null)
				album = this.OpenAlbum(fileName);

			if (album == null)
			{
				MessageBox.Show("The properties for this album cannot be displayed.");
				return;
			}

			using (AlbumEditDlg dlg = new AlbumEditDlg(album))
			{
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					// Save changes made by the user
					try
					{
						album.Save();
					}
					catch (Exception)
					{
						MessageBox.Show("Unable to save changes to album.");
						return;
					}

					// Update subitem settings
					item.SubItems[MainForm.AlbumTitleColumn].Text = album.Title;
					bool hasPwd = (album.Password != null) && (album.Password.Length > 0);
					item.SubItems[MainForm.AlbumPwdColumn].Text = (hasPwd ? "y" : "n");
				}
			}
			album.Dispose();
		}

		private void menuEditLabel_Click(object sender, System.EventArgs e)
		{
			if (listViewMain.SelectedItems.Count == 1)
				listViewMain.SelectedItems[0].BeginEdit();
		}

		private void listViewMain_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F2)
			{
				if (listViewMain.SelectedItems.Count == 1)
				{
					listViewMain.SelectedItems[0].
						BeginEdit();
					e.Handled = true;
				}
			}
		}

		private void listViewMain_AfterLabelEdit(object sender, System.Windows.Forms.LabelEditEventArgs e)
		{
			if (e.Label == null)
			{
				// Edit cancelled by the user
				e.CancelEdit = true;
				return;
			}
		
			ListViewItem item = listViewMain.Items[e.Item];
			
			if (UpdateAlbumName(e.Label, item) == false)
				e.CancelEdit = true;
		}
		private bool UpdateAlbumName(string newName, ListViewItem item)
		{
			string fileName = item.Tag as string;
			string newFileName = RenameFile(fileName, newName, ".abm");

			if (newFileName == null)
			{
				MessageBox.Show("Unable to rename album to this name.");
				return false;
			}

			// Update Tag property
			item.Tag = newFileName;
			return true;
		}

		private string RenameFile(string origFile, string newBase, string ext)
		{
			string fileName = Path.GetDirectoryName(origFile) + "\\" + newBase;
			string newFile = Path.ChangeExtension(fileName, ext);

			try
			{
				File.Move(origFile, newFile);
				return newFile;
			}

			catch (Exception)
			{
				// An error occurred
				return null;
			}
		}

		#region MyListViewComparer class
		private class MyListViewComparer : IComparer
		{

			// Associate a ListView with the class
			private ListView _listView;
			public MyListViewComparer(ListView lv)
			{
				_listView = lv;
			}																								
			public ListView ListView
			{
				get { return _listView; }
			}
																								
			// Track the current sorting column
			private int _sortColumn = 0;
			public int SortColumn
			{
				get { return _sortColumn; }
				set { _sortColumn = value; }
			}
																								
			// Compare method implementation
			public int Compare(object a, object b)
			{
				// Throws exception if not list items
				ListViewItem item1 = (ListViewItem)a;
				ListViewItem item2 = (ListViewItem)b;
																																		 
				// Account for current sorting order
				if (ListView.Sorting
					== SortOrder.Descending)
				{
					ListViewItem tmp = item1;
					item1 = item2;
					item2 = tmp;
				}																																																																			  

				// Handle nonDetails case
				if (ListView.View != View.Details)
				{
					return CaseInsensitiveComparer.Default.
						Compare(item1.Text, item2.Text);
				}

				return CompareAlbums(item1, item2);
			}

			public int CompareAlbums(ListViewItem item1, ListViewItem item2)
			{
				// Find the subitem instances
				ListViewItem.ListViewSubItem sub1
					= item1.SubItems[SortColumn];
				ListViewItem.ListViewSubItem sub2
					= item2.SubItems[SortColumn];
				// Return value is based on sort column
				switch (SortColumn)
				{
					case MainForm.AlbumNameColumn:
					case MainForm.AlbumTitleColumn:
					case MainForm.AlbumPwdColumn:
					{
						return
							CaseInsensitiveComparer.
							Default.Compare(
							sub1.Text, sub2.Text);
					}
														
					case MainForm.AlbumSizeColumn:
					{
						// Compare using integer values.
						int x1 = Convert.ToInt32(sub1.Text);
						int x2 = Convert.ToInt32(sub2.Text);
						if (x1 < x2)
							return -1;
						else if (x1 == x2)
							return 0;
						else
							return 1;
					}
														
					default:
						throw new IndexOutOfRangeException(
							"unrecognized column index");
				}
			}
            
			// end of MyListViewComparer class
		}
		#endregion

		// end of MainForm
	}
}
