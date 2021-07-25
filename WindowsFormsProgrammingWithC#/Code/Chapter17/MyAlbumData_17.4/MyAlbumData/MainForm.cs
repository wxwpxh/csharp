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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tcMain;
		private System.Windows.Forms.TabPage tabAlbum;
		private System.Windows.Forms.DataGrid gridPhotoAlbum;
		private System.Windows.Forms.TabPage tabPhoto;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtFileName;
		private System.Windows.Forms.TextBox txtCaption;
		private System.Windows.Forms.TextBox txtPhotographer;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.PictureBox pboxPhoto;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnPrev;
		private System.Windows.Forms.DateTimePicker dtpDateTaken;
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
			this.label1 = new System.Windows.Forms.Label();
			this.tcMain = new System.Windows.Forms.TabControl();
			this.tabAlbum = new System.Windows.Forms.TabPage();
			this.gridPhotoAlbum = new System.Windows.Forms.DataGrid();
			this.tabPhoto = new System.Windows.Forms.TabPage();
			this.dtpDateTaken = new System.Windows.Forms.DateTimePicker();
			this.btnPrev = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.pboxPhoto = new System.Windows.Forms.PictureBox();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.txtPhotographer = new System.Windows.Forms.TextBox();
			this.txtCaption = new System.Windows.Forms.TextBox();
			this.txtFileName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tcMain.SuspendLayout();
			this.tabAlbum.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridPhotoAlbum)).BeginInit();
			this.tabPhoto.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmbxAlbum
			// 
			this.cmbxAlbum.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.cmbxAlbum.Location = new System.Drawing.Point(72, 8);
			this.cmbxAlbum.Name = "cmbxAlbum";
			this.cmbxAlbum.Size = new System.Drawing.Size(224, 21);
			this.cmbxAlbum.TabIndex = 1;
			this.cmbxAlbum.Text = "comboBox1";
			this.cmbxAlbum.SelectedIndexChanged += new System.EventHandler(this.cmbxAlbum_SelectedIndexChanged);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.btnClose.Location = new System.Drawing.Point(352, 294);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "&Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Album:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tcMain
			// 
			this.tcMain.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tcMain.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.tabAlbum,
																				 this.tabPhoto});
			this.tcMain.Location = new System.Drawing.Point(8, 40);
			this.tcMain.Name = "tcMain";
			this.tcMain.SelectedIndex = 0;
			this.tcMain.Size = new System.Drawing.Size(424, 250);
			this.tcMain.TabIndex = 0;
			// 
			// tabAlbum
			// 
			this.tabAlbum.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.gridPhotoAlbum});
			this.tabAlbum.Location = new System.Drawing.Point(4, 22);
			this.tabAlbum.Name = "tabAlbum";
			this.tabAlbum.Size = new System.Drawing.Size(416, 224);
			this.tabAlbum.TabIndex = 0;
			this.tabAlbum.Text = "Album";
			// 
			// gridPhotoAlbum
			// 
			this.gridPhotoAlbum.DataMember = "";
			this.gridPhotoAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridPhotoAlbum.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.gridPhotoAlbum.Name = "gridPhotoAlbum";
			this.gridPhotoAlbum.Size = new System.Drawing.Size(416, 224);
			this.gridPhotoAlbum.TabIndex = 0;
			// 
			// tabPhoto
			// 
			this.tabPhoto.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.dtpDateTaken,
																				   this.btnPrev,
																				   this.btnNext,
																				   this.pboxPhoto,
																				   this.txtNotes,
																				   this.txtPhotographer,
																				   this.txtCaption,
																				   this.txtFileName,
																				   this.label6,
																				   this.label5,
																				   this.label4,
																				   this.label3,
																				   this.label2});
			this.tabPhoto.Location = new System.Drawing.Point(4, 22);
			this.tabPhoto.Name = "tabPhoto";
			this.tabPhoto.Size = new System.Drawing.Size(416, 224);
			this.tabPhoto.TabIndex = 1;
			this.tabPhoto.Text = "Photo";
			// 
			// dtpDateTaken
			// 
			this.dtpDateTaken.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.dtpDateTaken.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDateTaken.Location = new System.Drawing.Point(264, 110);
			this.dtpDateTaken.Name = "dtpDateTaken";
			this.dtpDateTaken.Size = new System.Drawing.Size(136, 20);
			this.dtpDateTaken.TabIndex = 7;
			this.dtpDateTaken.Value = new System.DateTime(2001, 8, 1, 0, 0, 0, 0);
			// 
			// btnPrev
			// 
			this.btnPrev.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.btnPrev.Location = new System.Drawing.Point(16, 184);
			this.btnPrev.Name = "btnPrev";
			this.btnPrev.Size = new System.Drawing.Size(64, 23);
			this.btnPrev.TabIndex = 10;
			this.btnPrev.Text = "Pre&v";
			this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
			// 
			// btnNext
			// 
			this.btnNext.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.btnNext.Location = new System.Drawing.Point(96, 184);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(64, 23);
			this.btnNext.TabIndex = 11;
			this.btnNext.Text = "Nex&t";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// pboxPhoto
			// 
			this.pboxPhoto.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.pboxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pboxPhoto.Location = new System.Drawing.Point(16, 48);
			this.pboxPhoto.Name = "pboxPhoto";
			this.pboxPhoto.Size = new System.Drawing.Size(144, 120);
			this.pboxPhoto.TabIndex = 10;
			this.pboxPhoto.TabStop = false;
			this.pboxPhoto.Paint += new System.Windows.Forms.PaintEventHandler(this.pboxPhoto_Paint);
			// 
			// txtNotes
			// 
			this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.txtNotes.Location = new System.Drawing.Point(192, 160);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Size = new System.Drawing.Size(208, 56);
			this.txtNotes.TabIndex = 9;
			this.txtNotes.Text = "";
			// 
			// txtPhotographer
			// 
			this.txtPhotographer.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.txtPhotographer.Location = new System.Drawing.Point(264, 78);
			this.txtPhotographer.Name = "txtPhotographer";
			this.txtPhotographer.Size = new System.Drawing.Size(136, 20);
			this.txtPhotographer.TabIndex = 5;
			this.txtPhotographer.Text = "";
			// 
			// txtCaption
			// 
			this.txtCaption.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.txtCaption.Location = new System.Drawing.Point(264, 46);
			this.txtCaption.Name = "txtCaption";
			this.txtCaption.Size = new System.Drawing.Size(136, 20);
			this.txtCaption.TabIndex = 3;
			this.txtCaption.Text = "";
			// 
			// txtFileName
			// 
			this.txtFileName.Location = new System.Drawing.Point(88, 16);
			this.txtFileName.Name = "txtFileName";
			this.txtFileName.ReadOnly = true;
			this.txtFileName.Size = new System.Drawing.Size(312, 20);
			this.txtFileName.TabIndex = 1;
			this.txtFileName.Text = "";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.label6.Location = new System.Drawing.Point(184, 144);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 16);
			this.label6.TabIndex = 8;
			this.label6.Text = "Note&s:";
			// 
			// label5
			// 
			this.label5.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.label5.Location = new System.Drawing.Point(184, 112);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 16);
			this.label5.TabIndex = 6;
			this.label5.Text = "&Date Taken: ";
			// 
			// label4
			// 
			this.label4.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.label4.Location = new System.Drawing.Point(184, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "&Photographer: ";
			// 
			// label3
			// 
			this.label3.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.label3.Location = new System.Drawing.Point(184, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Captio&n";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "&File Name: ";
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(442, 323);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.tcMain,
																		  this.label1,
																		  this.btnClose,
																		  this.cmbxAlbum});
			this.Name = "MainForm";
			this.Text = "MyAlbumData";
			this.tcMain.ResumeLayout(false);
			this.tabAlbum.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridPhotoAlbum)).EndInit();
			this.tabPhoto.ResumeLayout(false);
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

			_album = new PhotoAlbum();

			cmbxAlbum.DataSource = Directory.GetFiles(PhotoAlbum.DefaultDir, "*.abm");

			// Table style for PhotoAlbum data source
			DataGridTableStyle albumStyle = new DataGridTableStyle();
			albumStyle.MappingName = "PhotoAlbum";
			albumStyle.AlternatingBackColor = Color.LightGray;
			albumStyle.RowHeaderWidth = 15;

			// Column styles for PhotoAlbum source
			DataGridColumnStyle captionCol = new DataGridTextBoxColumn();
			captionCol.MappingName = "Caption";
			captionCol.HeaderText = "Caption";
			captionCol.Width = 100;

			DataGridColumnStyle validCol = new DataGridBoolColumn();
			validCol.MappingName = "IsImageValid";
			validCol.HeaderText = "Valid?";
			validCol.ReadOnly = true;
			validCol.Width = 30;

			DataGridTextBoxColumn dateCol = new DataGridTextBoxColumn();
			dateCol.MappingName = "DateTaken";
			dateCol.HeaderText = "Date Taken";
			dateCol.Alignment = HorizontalAlignment.Center;
			dateCol.Format = "d";
			dateCol.Width = 80;

			DataGridColumnStyle photographerCol = new DataGridTextBoxColumn();
			photographerCol.MappingName ="Photographer";
			photographerCol.HeaderText = "Photographer";
			photographerCol.Width = 100;

			DataGridColumnStyle fileNameCol = new DataGridTextBoxColumn();
			fileNameCol.MappingName = "FileName";
			fileNameCol.HeaderText = "Image File Name";
			fileNameCol.ReadOnly = true;
			fileNameCol.Width = 200;

			// Add the column styles to the table style
			albumStyle.GridColumnStyles.AddRange(new DataGridColumnStyle[] {
											  captionCol,
											  validCol,
											  dateCol,
											  photographerCol,
											  fileNameCol
										  });

			// Assign the table style to the data grid
			gridPhotoAlbum.TableStyles.Add(albumStyle);

			// Bind data for the Photo tab
			txtFileName.DataBindings.Add("Text", _album, "FileName");
			txtCaption.DataBindings.Add("Text", _album, "Caption");
			txtPhotographer.DataBindings.Add("Text", _album, "Photographer");
			dtpDateTaken.DataBindings.Add("Value", _album, "DateTaken");
			txtNotes.DataBindings.Add("Text", _album, "Notes");
			pboxPhoto.DataBindings.Add("Tag", _album, "Image");

			gridPhotoAlbum.SetDataBinding(_album, null);
		}

		private void cmbxAlbum_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string albumFile = cmbxAlbum.SelectedItem.ToString();

			if (_album != null)
			{
				SaveChanges();
				_album.Dispose();
			}

			_album.Clear();
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

			// Required to prevent binding exception
			if (_album.Count == 0)
				_album.Add(new Photograph(""));

			// Refresh the Photo tab controls
			BindingManagerBase bm = this.BindingContext[_album];
			CurrencyManager cm = bm as CurrencyManager;
			if (cm != null)
				cm.Refresh();

			EnablePhotoButtons(bm);
		}

		private void SaveChanges()
		{
			if (_album.HasEdits)
			{
				DialogResult result = MessageBox.Show(
					"Do you wish to save your changes "
					+ "to the album \'" + _album.Title
					+ "\'?",
					"Save Changes?",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
					_album.Save();
			}
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			// Complete any in-progress edits
			BindingManagerBase bm = BindingContext[_album];
			if (bm != null)
				bm.EndCurrentEdit();

			SaveChanges();
			base.OnClosing(e);
		}

		private void EnablePhotoButtons(BindingManagerBase bm)
		{
			btnNext.Enabled = (bm.Position < _album.Count - 1);
			btnPrev.Enabled = (bm.Position > 0);

			// Force image to repaint
			pboxPhoto.Invalidate();
		}

		private void btnNext_Click(object sender, System.EventArgs e)
		{
			BindingManagerBase bm = BindingContext[_album];
			if ((bm != null) && (bm.Position < bm.Count - 1))
			{
				bm.Position ++;
			}

			EnablePhotoButtons(bm);
		}

		private void btnPrev_Click(object sender, System.EventArgs e)
		{
			BindingManagerBase bm = BindingContext[_album];
			if ((bm != null) && (bm.Position > 0))
				bm.Position --;

			EnablePhotoButtons(bm);
		}

		private void pboxPhoto_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Bitmap image = pboxPhoto.Tag as Bitmap;
			if (image == null)
			{
				// No image, just clear the graphics
				e.Graphics.Clear(SystemColors.Control);
				return;
			}

			// Load the current photo
			BindingManagerBase bm = BindingContext[_album];
			Photograph photo = bm.Current as Photograph;

			Rectangle r = pboxPhoto.ClientRectangle;
			if (photo == null) 
			{
				// Something is wrong, just draw the image
				e.Graphics.DrawImage(image, r);
			}

			// Paint the image with a proper aspect ratio
			e.Graphics.DrawImage(image, photo.ScaleToFit(r));
		}


		// end of MainForm
	}
}
