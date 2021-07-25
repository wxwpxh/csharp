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
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.PictureBox pbxPhoto;
		private System.Windows.Forms.PictureBox pbxPhoto2;
		private System.Windows.Forms.Button btnLoad2;
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
			this.btnLoad = new System.Windows.Forms.Button();
			this.pbxPhoto = new System.Windows.Forms.PictureBox();
			this.pbxPhoto2 = new System.Windows.Forms.PictureBox();
			this.btnLoad2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(8, 8);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.TabIndex = 0;
			this.btnLoad.Text = "&Load";
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// pbxPhoto
			// 
			this.pbxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbxPhoto.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbxPhoto.Name = "pbxPhoto";
			this.pbxPhoto.Size = new System.Drawing.Size(292, 128);
			this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbxPhoto.TabIndex = 1;
			this.pbxPhoto.TabStop = false;
			// 
			// pbxPhoto2
			// 
			this.pbxPhoto2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbxPhoto2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbxPhoto2.Location = new System.Drawing.Point(0, 128);
			this.pbxPhoto2.Name = "pbxPhoto2";
			this.pbxPhoto2.Size = new System.Drawing.Size(292, 145);
			this.pbxPhoto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbxPhoto2.TabIndex = 2;
			this.pbxPhoto2.TabStop = false;
			// 
			// btnLoad2
			// 
			this.btnLoad2.Location = new System.Drawing.Point(8, 136);
			this.btnLoad2.Name = "btnLoad2";
			this.btnLoad2.TabIndex = 3;
			this.btnLoad2.Text = "Loa&d2";
			this.btnLoad2.Click += new System.EventHandler(this.btnLoad2_Click);
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnLoad2,
																		  this.pbxPhoto2,
																		  this.btnLoad,
																		  this.pbxPhoto});
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

		private void btnLoad_Click(object sender, System.EventArgs e)
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
					MessageBox.Show("Unable to load file: " + ex.Message, "Load Error");
				}
			}

			dlg.Dispose();
		}

		private void btnLoad2_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();

			dlg.Title = "Open Photo 2";
			dlg.Filter = "jpg files (*.jpg)|*.jpg"
				+ "|All files (*.*)|*.*";

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				try
				{
					pbxPhoto2.Image= new Bitmap(dlg.OpenFile());
				}
				catch (Exception ex)
				{
					// Handle exception
					MessageBox.Show("Unable to load file: " + ex.Message, "Load2 Error");
				}
			}

			dlg.Dispose();		
		}
	}
}
