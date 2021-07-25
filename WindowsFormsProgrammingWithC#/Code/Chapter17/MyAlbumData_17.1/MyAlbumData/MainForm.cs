using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

using Manning.MyPhotoAlbum;


namespace MyAlbumData
{
	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ComboBox cmbxAlbum;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.DataGrid gridPhotoAlbum;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

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

		private PhotoAlbum _album;

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
			this.cmbxAlbum = new System.Windows.Forms.ComboBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.gridPhotoAlbum = new System.Windows.Forms.DataGrid();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gridPhotoAlbum)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbxAlbum
			// 
			this.cmbxAlbum.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.cmbxAlbum.Location = new System.Drawing.Point(72, 8);
			this.cmbxAlbum.Name = "cmbxAlbum";
			this.cmbxAlbum.Size = new System.Drawing.Size(224, 21);
			this.cmbxAlbum.TabIndex = 0;
			this.cmbxAlbum.Text = "comboBox1";
			this.cmbxAlbum.SelectedIndexChanged += new System.EventHandler(this.cmbxAlbum_SelectedIndexChanged);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.btnClose.Location = new System.Drawing.Point(352, 244);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "&Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// gridPhotoAlbum
			// 
			this.gridPhotoAlbum.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.gridPhotoAlbum.DataMember = "";
			this.gridPhotoAlbum.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.gridPhotoAlbum.Location = new System.Drawing.Point(8, 40);
			this.gridPhotoAlbum.Name = "gridPhotoAlbum";
			this.gridPhotoAlbum.Size = new System.Drawing.Size(424, 196);
			this.gridPhotoAlbum.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "&Album:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(442, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label1,
																		  this.gridPhotoAlbum,
																		  this.btnClose,
																		  this.cmbxAlbum});
			this.Name = "MainForm";
			this.Text = "MyAlbumData";
			((System.ComponentModel.ISupportInitialize)(this.gridPhotoAlbum)).EndInit();
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

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		protected override void OnLoad(EventArgs e)
		{
			Version ver = new Version(Application.ProductVersion);
			Text = String.Format("MyAlbumData {0:#}.{1:#}", ver.Major, ver.Minor);

			cmbxAlbum.DataSource = Directory.GetFiles(PhotoAlbum.DefaultDir, "*.abm");
		}

		private void cmbxAlbum_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string albumFile = cmbxAlbum.SelectedItem.ToString();

			if (_album != null)
				_album.Dispose();

			_album = new PhotoAlbum();
			try
			{
				_album.Open(albumFile);
				gridPhotoAlbum.CaptionText = _album.Title;
			}

			catch (Exception)
			{
				_album.Clear();
				gridPhotoAlbum.CaptionText = "Unable to open album";
			}

			gridPhotoAlbum.SetDataBinding(_album, null);
		}

		// end of MainForm
	}
}
