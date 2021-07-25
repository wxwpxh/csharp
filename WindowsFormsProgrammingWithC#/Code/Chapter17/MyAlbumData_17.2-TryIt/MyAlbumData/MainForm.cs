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
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.DataGrid gridPhotoAlbum;
		private System.Windows.Forms.Button btnBack;
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
		private AlbumCollection _collection;

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
			this.btnClose = new System.Windows.Forms.Button();
			this.gridPhotoAlbum = new System.Windows.Forms.DataGrid();
			this.btnBack = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridPhotoAlbum)).BeginInit();
			this.SuspendLayout();
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
			this.gridPhotoAlbum.Location = new System.Drawing.Point(8, 8);
			this.gridPhotoAlbum.Name = "gridPhotoAlbum";
			this.gridPhotoAlbum.Size = new System.Drawing.Size(424, 224);
			this.gridPhotoAlbum.TabIndex = 1;
			this.gridPhotoAlbum.DoubleClick += new System.EventHandler(this.gridPhotoAlbum_DoubleClick);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(16, 244);
			this.btnBack.Name = "btnBack";
			this.btnBack.TabIndex = 3;
			this.btnBack.Text = "&Back";
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(442, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnBack,
																		  this.gridPhotoAlbum,
																		  this.btnClose});
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

			// Table style for PhotoAlbum data source
			DataGridTableStyle albumStyle = new DataGridTableStyle();
			albumStyle.MappingName = "PhotoAlbum";
			albumStyle.AlternatingBackColor = Color.LightGray;
			albumStyle.RowHeaderWidth = 15;

			// Table style for AlbumCollection data source
			DataGridTableStyle collectionStyle = new DataGridTableStyle();
			collectionStyle.MappingName = "AlbumCollection";
			collectionStyle.AlternatingBackColor = Color.LightBlue; // just to be different

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

			// Add the PhotoAlbum column styles to the table style
			albumStyle.GridColumnStyles.AddRange(new DataGridColumnStyle[] {
											  captionCol,
											  validCol,
											  dateCol,
											  photographerCol,
											  fileNameCol
										  });

			// Column styles for AlbumCollection source
			DataGridColumnStyle titleCol = new DataGridTextBoxColumn();
			titleCol.MappingName = "Title";
			titleCol.HeaderText = "Title";
			titleCol.Width = 100;

			DataGridColumnStyle countCol = new DataGridTextBoxColumn();
			countCol.MappingName = "Count";
			countCol.HeaderText = "Count";
			countCol.Alignment = HorizontalAlignment.Center;
			countCol.Width = 40;

			DataGridColumnStyle positionCol = new DataGridTextBoxColumn();
			positionCol.MappingName = "CurrentPosition";
			positionCol.HeaderText = "Position";
			positionCol.Alignment = HorizontalAlignment.Center;
			positionCol.Width = 50;

			DataGridColumnStyle albumNameCol = new DataGridTextBoxColumn();
			albumNameCol.MappingName = "FileName";
			albumNameCol.HeaderText = "File Name";
			albumNameCol.Width = 200;

			// Add the AlbumCollection column styles to the table style
			collectionStyle.GridColumnStyles.AddRange(new DataGridColumnStyle[] {
																			   titleCol,
																			   countCol,
																			   positionCol,
																			   albumNameCol
																		   });
			// Assign the table style to the data grid
			gridPhotoAlbum.TableStyles.AddRange(new DataGridTableStyle[] {
																			 albumStyle,
																			 collectionStyle
																		 });

			_album = null;
			_collection = new AlbumCollection();
			gridPhotoAlbum.SetDataBinding(_collection, null);

			btnBack.Visible = false;
		}

		private void gridPhotoAlbum_DoubleClick(object sender, System.EventArgs e)
		{
			int index = gridPhotoAlbum.CurrentRowIndex;
			if (_album == null && index >=0 && index < _collection.Count)
			{
				// Display the grid for the selected album
				_album = _collection[index];
				gridPhotoAlbum.SetDataBinding(_album, null);
				btnBack.Visible = true;
			}
		}

		private void btnBack_Click(object sender, System.EventArgs e)
		{
			_album = null;
			gridPhotoAlbum.SetDataBinding(_collection, null);
			btnBack.Visible = false;
		}

		// end of MainForm
	}
}
