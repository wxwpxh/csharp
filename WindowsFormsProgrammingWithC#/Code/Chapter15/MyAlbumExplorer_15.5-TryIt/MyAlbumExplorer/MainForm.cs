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
		private System.Windows.Forms.MenuItem menuProperties;
		private System.Windows.Forms.MenuItem menuEditLabel;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuAlbums;
		private System.Windows.Forms.MenuItem menuPhotos;
		private System.Windows.Forms.TreeView treeViewMain;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.PictureBox pictureBoxMain;
		private System.Windows.Forms.ContextMenu ctxtMenuTree;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuAddDirectory;
		private System.Windows.Forms.MenuItem menuNodeProperties;
		private System.Windows.Forms.MenuItem menuNodeDelete;
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
		private const int SelectedPhotoIndex = 3;
		private const int SelectedAlbumIndex = 4;
		private const int AlbumDirectoryIndex = 5;

		private const int AlbumNameColumn = 0;
		private const int AlbumTitleColumn = 1;
		private const int AlbumPwdColumn = 2;
		private const int AlbumSizeColumn = 3;

		private const int PhotoCaptionColumn = 0;
		private const int PhotoDateTakenColumn = 1;
		private const int PhotoPhotographerColumn = 2;
		private const int PhotoFileNameColumn = 3;

		private bool _albumsShown = true;
		private PhotoAlbum _album = null;

		private MyListViewComparer _comparer;

		private static Pen borderPen = new Pen(SystemColors.WindowFrame);

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
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuAlbums = new System.Windows.Forms.MenuItem();
			this.menuPhotos = new System.Windows.Forms.MenuItem();
			this.listViewMain = new System.Windows.Forms.ListView();
			this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
			this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
			this.treeViewMain = new System.Windows.Forms.TreeView();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.pictureBoxMain = new System.Windows.Forms.PictureBox();
			this.ctxtMenuTree = new System.Windows.Forms.ContextMenu();
			this.menuAddDirectory = new System.Windows.Forms.MenuItem();
			this.menuNodeProperties = new System.Windows.Forms.MenuItem();
			this.menuNodeDelete = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
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
			// 
			// menuEdit
			// 
			this.menuEdit.Index = 1;
			this.menuEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuEditLabel,
																					 this.menuProperties});
			this.menuEdit.Text = "&Edit";
			this.menuEdit.Popup += new System.EventHandler(this.menuEdit_Popup);
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
			this.menuProperties.Text = "&Properties";
			this.menuProperties.Click += new System.EventHandler(this.menuProperties_Click);
			// 
			// menuView
			// 
			this.menuView.Index = 2;
			this.menuView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuLargeIcons,
																					 this.menuSmallIcons,
																					 this.menuList,
																					 this.menuDetails,
																					 this.menuItem1,
																					 this.menuAlbums,
																					 this.menuPhotos});
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
			// menuItem1
			// 
			this.menuItem1.Index = 4;
			this.menuItem1.Text = "-";
			// 
			// menuAlbums
			// 
			this.menuAlbums.Index = 5;
			this.menuAlbums.Text = "&Albums";
			this.menuAlbums.Click += new System.EventHandler(this.menuAlbums_Click);
			// 
			// menuPhotos
			// 
			this.menuPhotos.Index = 6;
			this.menuPhotos.Text = "&Photos";
			this.menuPhotos.Click += new System.EventHandler(this.menuPhotos_Click);
			// 
			// listViewMain
			// 
			this.listViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewMain.HideSelection = false;
			this.listViewMain.LabelEdit = true;
			this.listViewMain.LargeImageList = this.imageListLarge;
			this.listViewMain.Location = new System.Drawing.Point(124, 0);
			this.listViewMain.Name = "listViewMain";
			this.listViewMain.Size = new System.Drawing.Size(268, 253);
			this.listViewMain.SmallImageList = this.imageListSmall;
			this.listViewMain.TabIndex = 0;
			this.listViewMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewMain_KeyDown);
			this.listViewMain.ItemActivate += new System.EventHandler(this.listViewMain_ItemActivate);
			this.listViewMain.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listViewMain_AfterLabelEdit);
			this.listViewMain.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewMain_ColumnClick);
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
			// treeViewMain
			// 
			this.treeViewMain.ContextMenu = this.ctxtMenuTree;
			this.treeViewMain.Dock = System.Windows.Forms.DockStyle.Left;
			this.treeViewMain.HideSelection = false;
			this.treeViewMain.ImageIndex = 1;
			this.treeViewMain.ImageList = this.imageListSmall;
			this.treeViewMain.LabelEdit = true;
			this.treeViewMain.Name = "treeViewMain";
			this.treeViewMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
																					 new System.Windows.Forms.TreeNode("DefaultAlbums", 5, 5, new System.Windows.Forms.TreeNode[] {
																																													  new System.Windows.Forms.TreeNode("Album 1", new System.Windows.Forms.TreeNode[] {
																																																																		   new System.Windows.Forms.TreeNode("Photo 1", 0, 3)}),
																																													  new System.Windows.Forms.TreeNode("Album 2"),
																																													  new System.Windows.Forms.TreeNode("Album 3")})});
			this.treeViewMain.SelectedImageIndex = 4;
			this.treeViewMain.Size = new System.Drawing.Size(121, 253);
			this.treeViewMain.TabIndex = 1;
			this.treeViewMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeViewMain_KeyDown);
			this.treeViewMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeViewMain_MouseDown);
			this.treeViewMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewMain_AfterSelect);
			this.treeViewMain.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeViewMain_AfterLabelEdit);
			this.treeViewMain.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewMain_BeforeExpand);
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(121, 0);
			this.splitter1.MinExtra = 100;
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 253);
			this.splitter1.TabIndex = 2;
			this.splitter1.TabStop = false;
			// 
			// pictureBoxMain
			// 
			this.pictureBoxMain.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxMain.Location = new System.Drawing.Point(124, 0);
			this.pictureBoxMain.Name = "pictureBoxMain";
			this.pictureBoxMain.Size = new System.Drawing.Size(268, 253);
			this.pictureBoxMain.TabIndex = 3;
			this.pictureBoxMain.TabStop = false;
			this.pictureBoxMain.Visible = false;
			this.pictureBoxMain.Resize += new System.EventHandler(this.pictureBoxMain_Resize);
			this.pictureBoxMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxMain_Paint);
			// 
			// ctxtMenuTree
			// 
			this.ctxtMenuTree.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuAddDirectory,
																						 this.menuItem5,
																						 this.menuNodeProperties,
																						 this.menuNodeDelete});
			this.ctxtMenuTree.Popup += new System.EventHandler(this.ctxtMenuTree_Popup);
			// 
			// menuAddDirectory
			// 
			this.menuAddDirectory.Index = 0;
			this.menuAddDirectory.Text = "&Add Directory...";
			this.menuAddDirectory.Click += new System.EventHandler(this.menuAddDirectory_Click);
			// 
			// menuNodeProperties
			// 
			this.menuNodeProperties.Index = 2;
			this.menuNodeProperties.Text = "&Properties...";
			this.menuNodeProperties.Click += new System.EventHandler(this.menuNodeProperties_Click);
			// 
			// menuNodeDelete
			// 
			this.menuNodeDelete.Index = 3;
			this.menuNodeDelete.Text = "&Delete";
			this.menuNodeDelete.Click += new System.EventHandler(this.menuNodeDelete_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.Text = "-";
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(392, 253);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.pictureBoxMain,
																		  this.listViewMain,
																		  this.splitter1,
																		  this.treeViewMain});
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

			// Initialize the tree and list controls
			InitTreeData();
		}

		private void menuView_Popup(object sender, System.EventArgs e)
		{
			View v = listViewMain.View;
			menuLargeIcons.Checked = (v == View.LargeIcon);
			menuSmallIcons.Checked = (v == View.SmallIcon);
			menuList.Checked = (v == View.List);
			menuDetails.Checked = (v == View.Details);

			if (_albumsShown && listViewMain.SelectedItems.Count > 0)
				menuPhotos.Enabled = true;
			else
				menuPhotos.Enabled = false;
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
			listViewMain.Clear();
			_comparer.CurrentAlbum = null;
			_albumsShown = true;
			if (_album != null)
			{
				_album.Dispose();
				_album = null;
			}

			// Define the columns
			listViewMain.Columns.Add("Name", 80, HorizontalAlignment.Left);
			listViewMain.Columns.Add("Title", 100, HorizontalAlignment.Left);
			listViewMain.Columns.Add("Pwd", 40, HorizontalAlignment.Center);
			listViewMain.Columns.Add("Size", 40, HorizontalAlignment.Right);

			// Load the albums into the control
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
					bool hasPwd = (album.Password != null) && (album.Password.Length > 0);
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
			if (treeViewMain.Focused)
			{
				TreeNode node = treeViewMain.SelectedNode;
				string file = node.Tag as string;
				if (node == null || node.Parent == null || file == null)
					return;    // do nothing

				if (Path.GetExtension(file) == ".abm")
					DisplayAlbumProperties(node);
				else
					DisplayPhotoProperties(node);
			}
			else if (pictureBoxMain.Focused)
			{
				// Display photograph for this image
				TreeNode node = treeViewMain.SelectedNode;
				if (node != null)
					DisplayPhotoProperties(node);
			}
			else if (listViewMain.SelectedItems.Count > 0)
			{
				ListViewItem item = listViewMain.SelectedItems[0];
				if (this._albumsShown)
					DisplayAlbumProperties(item);
				else
					DisplayPhotoProperties(item);
			}
		}

		private void DisplayAlbumProperties(object obj)
		{
			ListViewItem item = obj as ListViewItem;
			TreeNode node = obj as TreeNode;

			// Open the album as appropriate
			PhotoAlbum album = null;
			if (item != null)
			{
				string fileName = item.Tag as string;
				if (fileName != null)
					album = this.OpenAlbum(fileName);
			}
			else if (node != null)
			{
				album = OpenTreeAlbum(node);
			}

			if (album == null)
			{
				MessageBox.Show("The properties for this album cannot be displayed.");
				return;
			}

			using (AlbumEditDlg dlg = new AlbumEditDlg(album))
			{
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					// Save changes made the user
					try
					{
						album.Save();
					}
					catch (Exception)
					{
						MessageBox.Show("Unable to save changes to album.");
						return;
					}

					// Update item settings
					if (item != null)
					{
						item.SubItems[MainForm.AlbumTitleColumn].Text = album.Title;
						bool hasPwd = (album.Password != null) && (album.Password.Length > 0);
						item.SubItems[MainForm.AlbumPwdColumn].Text = (hasPwd ? "y" : "n");
					}
				}
			}

			album.Dispose();
		}

		private void DisplayPhotoProperties(object obj)
		{
			ListViewItem item = obj as ListViewItem;
			TreeNode node = obj as TreeNode;

		    int index = 0;
			if (item != null && (item.Tag is int))
			{
				index = (int)item.Tag;
			}
			else if (node != null)
				index = node.Index;

			_album.CurrentPosition = index;

			using (PhotoEditDlg dlg = new PhotoEditDlg(_album))
			{
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					// Save any changes made
					try
					{
						_album.Save(_album.FileName);
					}
					catch (Exception)
					{
						MessageBox.Show("Unable to save changes to photos in album.");
					}

					// Update the controls with any new settings
					TreeNode baseNode = null;
					if (item != null)
					{
						LoadPhotoData(_album);
						baseNode = treeViewMain.SelectedNode;
					}
					else if (node != null)
					{
						baseNode = node.Parent;
					}

					if (baseNode != null)
					{
						// Update all child labels
						foreach (TreeNode n in baseNode.Nodes)
						{
							n.Text = _album[n.Index].Caption;
						}
					}
				}
			}
		}

		private void menuEditLabel_Click(object sender, System.EventArgs e)
		{
			if (treeViewMain.Focused)
			{
				if (treeViewMain.SelectedNode != null)
					treeViewMain.SelectedNode.BeginEdit();
			}
			else if (listViewMain.SelectedItems.Count > 0)
			{
				listViewMain.SelectedItems[0].BeginEdit();
			}
		}

		private void listViewMain_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F2)
			{
				if (listViewMain.SelectedItems.Count == 1)
				{
					listViewMain.SelectedItems[0].BeginEdit();
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
			if (this._albumsShown)
				e.CancelEdit = !UpdateAlbumName(e.Label, item);
			else 
				e.CancelEdit = !UpdatePhotoCaption(e.Label, item);
		}

		private bool UpdateAlbumName(string newName, object obj)
		{
			ListViewItem item = obj as ListViewItem;
			TreeNode node = obj as TreeNode;

			// Determine the file name
			string fileName = null;
			if (item != null)
			{
				fileName = item.Tag as string;
				node = FindNode(fileName, false);
			}
			else if (node != null)
				fileName = node.Tag as string;

			// Rename the file
			string newFileName = null;
			if (fileName != null)
				newFileName = RenameFile(fileName, newName, ".abm");

			if (newFileName == null)
			{
				MessageBox.Show("Unable to rename album to this name.");
				return false;
			}

			// Update the appropriate Tag property
			if (item != null)
			{
				item.Tag = newFileName;
				if (node != null)
					node.Text = newName;
			}
			else if (node != null)
				node.Tag = newFileName;

			return true;
		}

		private bool UpdatePhotoCaption(string caption, object obj)
		{
			ListViewItem item = obj as ListViewItem;
			TreeNode node = obj as TreeNode;

			// Determine the album index
			int index = -1;
			if (item != null && item.Tag is int)
			{
				index = (int)item.Tag;
				node = FindNode(_album[index].FileName, false);
			}
			else if (node != null)
			{
				index = node.Index;
			}

			if (caption.Length == 0 || index < 0)
			{
				MessageBox.Show("Unable to update caption.");
				return false;
			}

			// Update photograph's caption
			_album[index].Caption = caption;
			if (item != null && node != null)
			{
				// Update node text as well
				node.Text = caption;
			}

			try
			{
				_album.Save();
			}
			catch (Exception)
			{
				MessageBox.Show("Unable to save new caption to album file.");
			}

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

		private void listViewMain_ItemActivate(object sender, System.EventArgs e)
		{
			if (listViewMain.SelectedItems.Count > 0)
			{
				// Find the file path for selected item
				string fileName = null;
				ListViewItem item = listViewMain.SelectedItems[0];
				if (_albumsShown)
				{
					// Get the file for this album
					fileName = item.Tag as string;
				}
				else if (item.Tag is int)
				{
					// Get the index of the photograph
					int index = (int)item.Tag;
					fileName = _album[index].FileName;
				}

				if (fileName == null)
				{
					MessageBox.Show("This item cannot be opened.");
					return;
				}

				// Find tree node with identical path
				TreeNode node = FindNode(fileName, true);
				if (node != null)
				{
					// Select the node to activate it.
					node.EnsureVisible();
					treeViewMain.SelectedNode = node;
				}
			}
		}

		private void LoadPhotoData(PhotoAlbum album)
		{
			listViewMain.Clear();
			if (_album != null && album != _album)
				_album.Dispose();
			_albumsShown = false;
			_album = album;
			_comparer.CurrentAlbum = _album;

			// Define the columns
			listViewMain.Columns.Add("Caption", 100, HorizontalAlignment.Left);
			listViewMain.Columns.Add("Taken", 70, HorizontalAlignment.Center);
			listViewMain.Columns.Add("Photographer", 100, HorizontalAlignment.Left);
			listViewMain.Columns.Add("File Name", 200, HorizontalAlignment.Left);

			// Handle null or empty album
			if (album == null || album.Count == 0)
				return;
			// Load the photo items
			for (int i = 0; i < album.Count; i++)
			{
				Photograph photo = album[i];
				ListViewItem item = new ListViewItem();

				item.Text = photo.Caption;
				item.Tag = i;
				item.ImageIndex = MainForm.PhotoIndex;

				// Add the subitems
				item.SubItems.Add(photo.
					DateTaken.ToShortDateString());
				item.SubItems.Add(photo.Photographer);
				item.SubItems.Add(photo.FileName);

				listViewMain.Items.Add(item);
			}
		}

		private void menuEdit_Popup(object sender, System.EventArgs e)
		{
			if (treeViewMain.Focused) 
			{
				menuProperties.Enabled = (treeViewMain.SelectedNode != null);
				menuEditLabel.Enabled = (treeViewMain.SelectedNode != null);
				menuEditLabel.Text = "&Node";
			}
			else // assume ListView has focus
			{
				menuProperties.Enabled = (listViewMain.SelectedItems.Count == 1);
				menuEditLabel.Enabled = (listViewMain.SelectedItems.Count == 1);
				if (this._albumsShown)
					menuEditLabel.Text = "&Name";
				else
					menuEditLabel.Text = "&Caption";
			}
		}

		private void menuAlbums_Click(object sender, System.EventArgs e)
		{
			// Select Default Albums node
			if (treeViewMain.Nodes.Count > 0)
				treeViewMain.SelectedNode = treeViewMain.Nodes[0];
		}

		private void menuPhotos_Click(object sender, System.EventArgs e)
		{
			// Activate the selected album
			listViewMain_ItemActivate(sender, e);
		}

		private void InitTreeData()
		{
			treeViewMain.BeginUpdate();
			treeViewMain.Nodes.Clear();

			// Create the top-level node
			TreeNode defaultRoot = new TreeNode("Default Albums",
				AlbumDirectoryIndex, AlbumDirectoryIndex);
			defaultRoot.Tag = PhotoAlbum.DefaultDir;
			treeViewMain.Nodes.Add(defaultRoot);
			treeViewMain.SelectedNode = defaultRoot;

			foreach (string s in Directory.GetFiles(PhotoAlbum.DefaultDir, "*.abm"))
			{
				// Create a node for this album
				String baseName = Path.GetFileNameWithoutExtension(s);
				TreeNode albumNode = new TreeNode(baseName,
					new TreeNode[] { new TreeNode("child") });
				albumNode.Tag = s;
				defaultRoot.Nodes.Add(albumNode);
			}

			treeViewMain.EndUpdate();
		}

		private PhotoAlbum OpenTreeAlbum(TreeNode node)
		{
			string s = node.Tag as string;
			PhotoAlbum album = OpenAlbum(s);

			if (album == null)
			{
				// Unable to open album
				node.ImageIndex = ErrorIndex;
				node.SelectedImageIndex = ErrorIndex;
			}
			else
			{
				// Album opened successfully
				node.ImageIndex = AlbumIndex;
				node.SelectedImageIndex = SelectedAlbumIndex;
			}

			return album;
		}

		private void treeViewMain_BeforeExpand(object sender, System.Windows.Forms.TreeViewCancelEventArgs e)
		{
			TreeNode node = e.Node;

			string s = node.Tag as string;
			if (s == null
				|| (Path.GetExtension(s) != ".abm"))
			{
				// Not an album node
				return;
			}

			// Found an album node
			node.Nodes.Clear();
			using (PhotoAlbum album = OpenTreeAlbum(node))
			{
				// Cancel if null or empty album
				if (album == null || album.Count == 0)
				{
					e.Cancel = true;
					return;
				}

				// Add a node for each photo in album
				treeViewMain.BeginUpdate();
				foreach (Photograph p in album)
				{
					// Create a new node for this photo
					TreeNode newNode = new TreeNode(
						album.GetDisplayText(p), MainForm.PhotoIndex, MainForm.SelectedPhotoIndex);
					newNode.Tag = p.FileName;
					node.Nodes.Add(newNode);
				}

				treeViewMain.EndUpdate();
			}
		}

		private void treeViewMain_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			TreeNode node = e.Node;
			string fileName = node.Tag as string;
			if (fileName == null)
				throw new ApplicationException("selected tree node has invalid tag");

			if (node.Parent == null)
			{
				// Top-level node
				LoadAlbumData(fileName);
				DisplayPhoto(null);
			}
			else if (Path.GetExtension(fileName) == ".abm")
			{
				// Album node selected
				PhotoAlbum album = OpenTreeAlbum(node);
				LoadPhotoData(album);
				DisplayPhoto(null);
			}
			else  // must be a photograph
			{
				// Clear the list and display the photo
				listViewMain.Clear();
				DisplayPhoto(node);
			}
		}

		private TreeNode FindNode(string fileName, bool expandNode)
		{
			TreeNode node = treeViewMain.SelectedNode;
			if (node == null)
				return null;

			// Ensure contents of node are available
			if (expandNode)
				node.Expand();

			// Search for a matching node
			foreach (TreeNode n in node.Nodes)
			{
				string nodePath = n.Tag as string;
				if (nodePath == fileName)
				{
					// Found it!
					return n;
				}
			}

			return null;
		}

		private void DisplayPhoto(TreeNode node)
		{
			if (node == null)
			{
				pictureBoxMain.Visible = false;
				listViewMain.Visible = true;
				return;
			}

			// Parent of photo node is album node
			string file = node.Parent.Tag as string;
			if (_album == null || (_album.FileName != file))
			{
				if (_album != null)
					_album.Dispose();

				_album = OpenTreeAlbum(node.Parent);
			}

			if (_album != null)
			{
				// Proper PhotoAlbum is now open
				pictureBoxMain.Tag = _album[node.Index];
				pictureBoxMain.Invalidate();
				pictureBoxMain.Visible = true;
				listViewMain.Visible = false;
			}
		}

		private void pictureBoxMain_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Photograph photo = pictureBoxMain.Tag as Photograph;

			if (photo == null)
			{
				// Something is wrong, give up
				e.Graphics.Clear(pictureBoxMain.BackColor);
				return;
			}

			// Paint the photograph
			Rectangle rect = photo.ScaleToFit(pictureBoxMain.ClientRectangle);
			e.Graphics.DrawImage(photo.Image, rect);
			e.Graphics.DrawRectangle(borderPen, rect);
		}

		private void pictureBoxMain_Resize(object sender, System.EventArgs e)
		{
			// Force the entire control to repaint
			pictureBoxMain.Invalidate();
		}

		private void treeViewMain_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F2)
			{
				if (treeViewMain.SelectedNode != null)
				{
					treeViewMain.SelectedNode.BeginEdit();
					e.Handled = true;
				}
			}
		}

		private void treeViewMain_AfterLabelEdit(object sender, System.Windows.Forms.NodeLabelEditEventArgs e)
		{
			if (e.Label == null)
			{
				// Edit cancelled by the user
				e.CancelEdit = true;
				return;
			}

			// No changes required for root node
			if (e.Node.Parent == null)
				return;

			string fileName = e.Node.Tag as string;
			if (Path.GetExtension(fileName) == ".abm")
				e.CancelEdit = !UpdateAlbumName(e.Label, e.Node);
			else
				e.CancelEdit = !UpdatePhotoCaption(e.Label, e.Node);
		}

		private void menuAddDirectory_Click(object sender, System.EventArgs e)
		{
			// This permits the user to select an album file, and then
			// adds all albums in this directory to the tree.
			using (OpenFileDialog dlg = new OpenFileDialog())
			{
				dlg.Title = "Select Album Directory";
				dlg.Filter = "abm files (*.abm)|*.abm|All Files (*.*)|*.*";
				dlg.InitialDirectory = PhotoAlbum.DefaultDir;

				if (dlg.ShowDialog() == DialogResult.OK)
				{
					try
					{
						// Find the directory
						string albumDir = Path.GetDirectoryName(dlg.FileName);

						// Create a node for this directory
						TreeNode rootNode = new TreeNode(albumDir,
							AlbumDirectoryIndex, AlbumDirectoryIndex);
						rootNode.Tag = albumDir;
						treeViewMain.Nodes.Add(rootNode);
						
						// Add each album in this directory to the tree
						foreach (string s in Directory.GetFiles(albumDir, "*.abm"))
						{
							// Create a node for this album
							String baseName = Path.GetFileNameWithoutExtension(s);
							TreeNode albumNode = new TreeNode(baseName,
								new TreeNode[] { new TreeNode("child") });
							albumNode.Tag = s;
							rootNode.Nodes.Add(albumNode);
						}
					}
					catch (Exception)
					{
						// An error occurred, so just ignore remaining files.
					}
				}
			}
		}

		private Point treePopupPoint;

		private void treeViewMain_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				treePopupPoint = new Point(e.X, e.Y);
			}
		}

		private void menuNodeProperties_Click(object sender, System.EventArgs e)
		{
			TreeNode node = treeViewMain.GetNodeAt(treePopupPoint);

			if (node != null)
			{
				// Select the given node and invoke the properties menu
				treeViewMain.SelectedNode = node;
				menuProperties.PerformClick();
			}
		}

		private void menuNodeDelete_Click(object sender, System.EventArgs e)
		{
			TreeNode node = treeViewMain.GetNodeAt(treePopupPoint);
			if (node == null)
			{
				// Nothing there
				return;
			}

			string fileName = node.Tag as string;
			if (node.Parent == null && fileName == PhotoAlbum.DefaultDir)
			{

				MessageBox.Show("Unable to delete default album directory.");
				return;
			}

			DialogResult result;

			// Suspend layout and select the node to delete.  This ensures that
			// an AfterSelect event will occur when we change the selection below.
			treeViewMain.SuspendLayout();
			treeViewMain.SelectedNode = node;
			if (node.Parent == null)
			{
				result = MessageBox.Show("Do you really wish to remove this album directory from the tree?",
					"Remove Directory", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button2);

				if (result == DialogResult.Yes)
				{
					treeViewMain.SelectedNode = treeViewMain.Nodes[0];

					// Clear the directory node
					node.Nodes.Clear();
					node.Remove();
				}
			}
			else if (Path.GetExtension(fileName) == ".abm")
			{
				result = MessageBox.Show("Do you really wish to permanantly delete this album?",
					"Delete Album", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button2);

				if (result == DialogResult.Yes)
				{
					treeViewMain.SelectedNode = node.Parent;

					// Delete the album node
					File.Delete(fileName);
					node.Nodes.Clear();
					node.Remove();
					
				}
			}
			else  // must be a photograph
			{
				result = MessageBox.Show("Do you really wish to delete this photograph from the album?",
					"Delete Photograph", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button2);

				if (result == DialogResult.Yes)
				{
					// Remove the photo
					TreeNode parentNode = node.Parent;
					PhotoAlbum album = OpenAlbum(parentNode.Tag as string);
					if (album != null)
					{
						album.RemoveAt(node.Index);
						album.Save();
						album.Dispose();

						node.Nodes.Clear();
						node.Remove();

						treeViewMain.SelectedNode = parentNode;
					}
				}			
			}
			treeViewMain.ResumeLayout();
		}

		private void ctxtMenuTree_Popup(object sender, System.EventArgs e)
		{
			TreeNode node = treeViewMain.GetNodeAt(treePopupPoint);

			menuNodeProperties.Enabled = (node != null);
			menuNodeDelete.Enabled = (node != null);
		}


		#region MyListViewComparer class
		private class MyListViewComparer : IComparer
		{
			// Associate a ListView with the class
			private ListView _listView;
			PhotoAlbum _album = null;

			public MyListViewComparer(ListView lv)
			{
				_listView = lv;
			}

			public ListView ListView
			{
				get { return _listView; }
			}

			public PhotoAlbum CurrentAlbum
			{
				get { return _album; }
				set { _album = value; }
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
				if (ListView.Sorting == SortOrder.Descending)
				{
					ListViewItem tmp = item1;
					item1 = item2;
					item2 = tmp;
				}

				// Handle non-Details case
				if (ListView.View != View.Details) 
				{
					return CaseInsensitiveComparer.Default.Compare(item1.Text, item2.Text);
				}

				if (CurrentAlbum == null)
					return CompareAlbums(item1, item2);
				else
					return ComparePhotos(item1, item2);
			}

			public int CompareAlbums(ListViewItem item1, ListViewItem item2)
			{
				// Find the subitem instances
				ListViewItem.ListViewSubItem sub1 = item1.SubItems[SortColumn];
				ListViewItem.ListViewSubItem sub2 = item2.SubItems[SortColumn];

				// Return value is based on sort column
				switch (SortColumn)
				{
					case MainForm.AlbumNameColumn:
					case MainForm.AlbumTitleColumn:
					case MainForm.AlbumPwdColumn:
					{
						return CaseInsensitiveComparer.Default.Compare(sub1.Text, sub2.Text);
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
						throw new IndexOutOfRangeException("unrecognized column index");
				}
			}

			public int ComparePhotos(ListViewItem item1, ListViewItem item2)
			{
				ListViewItem.ListViewSubItem sub1;
				ListViewItem.ListViewSubItem sub2;

				switch (SortColumn)
				{
					case MainForm.PhotoCaptionColumn:
					case MainForm.PhotoPhotographerColumn:
					case MainForm.PhotoFileNameColumn:
						sub1 = item1.SubItems[SortColumn];
						sub2 = item2.SubItems[SortColumn];
						return CaseInsensitiveComparer.Default.Compare(sub1.Text, sub2.Text);

					case MainForm.PhotoDateTakenColumn:
						// Find the indices into the album
						int index1 = (int)item1.Tag;
						int index2 = (int)item2.Tag;

						// Look up the dates for each photo
						DateTime date1 = CurrentAlbum[index1].DateTaken;
						DateTime date2 = CurrentAlbum[index2].DateTaken;

						return DateTime.Compare(date1, date2);

					default:
						throw new IndexOutOfRangeException("unrecognized column index");
				}
			}

			// end of MyListViewComparer
		}
		#endregion

		// end of MainForm
	}
}
