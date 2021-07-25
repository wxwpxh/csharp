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
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ParentForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ParentForm));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuFile = new System.Windows.Forms.MenuItem();
			this.menuNew = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuExit = new System.Windows.Forms.MenuItem();
			this.menuOpen = new System.Windows.Forms.MenuItem();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuFile});
			// 
			// menuFile
			// 
			this.menuFile.Index = 0;
			this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuNew,
																					 this.menuOpen,
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
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.MergeType = System.Windows.Forms.MenuMerge.Remove;
			this.menuItem3.Text = "-";
			// 
			// menuExit
			// 
			this.menuExit.Index = 3;
			this.menuExit.MergeOrder = 7;
			this.menuExit.Text = "E&xit";
			this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
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
			// ParentForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(592, 373);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Menu = this.mainMenu1;
			this.Name = "ParentForm";
			this.Text = "ParentForm";

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


		// end of ParentForm
	}
}
