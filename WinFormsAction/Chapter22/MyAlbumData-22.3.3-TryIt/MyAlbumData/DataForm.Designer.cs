namespace MyAlbumData
{
	partial class DataForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.comboAlbum = new System.Windows.Forms.ComboBox();
			this.gridPhotoAlbum = new System.Windows.Forms.DataGridView();
			this.btnClose = new System.Windows.Forms.Button();
			this.tcMain = new System.Windows.Forms.TabControl();
			this.pageAlbum = new System.Windows.Forms.TabPage();
			this.pagePhoto = new System.Windows.Forms.TabPage();
			this.dtpDateTaken = new System.Windows.Forms.DateTimePicker();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPhotographer = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCaption = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.pbxPhoto = new System.Windows.Forms.PictureBox();
			this.txtFileName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.bsAlbum = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.gridPhotoAlbum)).BeginInit();
			this.tcMain.SuspendLayout();
			this.pageAlbum.SuspendLayout();
			this.pagePhoto.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsAlbum)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Album:";
			// 
			// comboAlbum
			// 
			this.comboAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.comboAlbum.DropDownWidth = 500;
			this.comboAlbum.FormattingEnabled = true;
			this.comboAlbum.Location = new System.Drawing.Point(57, 6);
			this.comboAlbum.Name = "comboAlbum";
			this.comboAlbum.Size = new System.Drawing.Size(263, 21);
			this.comboAlbum.TabIndex = 1;
			this.comboAlbum.SelectionChangeCommitted += new System.EventHandler(this.comboAlbum_SelectionChangeCommitted);
			// 
			// gridPhotoAlbum
			// 
			this.gridPhotoAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridPhotoAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridPhotoAlbum.Location = new System.Drawing.Point(3, 3);
			this.gridPhotoAlbum.Name = "gridPhotoAlbum";
			this.gridPhotoAlbum.Size = new System.Drawing.Size(404, 160);
			this.gridPhotoAlbum.TabIndex = 2;
			this.gridPhotoAlbum.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridPhotoAlbum_CellMouseDown);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Location = new System.Drawing.Point(355, 231);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "&Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// tcMain
			// 
			this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tcMain.Controls.Add(this.pageAlbum);
			this.tcMain.Controls.Add(this.pagePhoto);
			this.tcMain.Location = new System.Drawing.Point(12, 33);
			this.tcMain.Name = "tcMain";
			this.tcMain.SelectedIndex = 0;
			this.tcMain.Size = new System.Drawing.Size(418, 192);
			this.tcMain.TabIndex = 4;
			// 
			// pageAlbum
			// 
			this.pageAlbum.Controls.Add(this.gridPhotoAlbum);
			this.pageAlbum.Location = new System.Drawing.Point(4, 22);
			this.pageAlbum.Name = "pageAlbum";
			this.pageAlbum.Padding = new System.Windows.Forms.Padding(3);
			this.pageAlbum.Size = new System.Drawing.Size(410, 166);
			this.pageAlbum.TabIndex = 0;
			this.pageAlbum.Text = "Album";
			this.pageAlbum.UseVisualStyleBackColor = true;
			// 
			// pagePhoto
			// 
			this.pagePhoto.Controls.Add(this.dtpDateTaken);
			this.pagePhoto.Controls.Add(this.txtNotes);
			this.pagePhoto.Controls.Add(this.label6);
			this.pagePhoto.Controls.Add(this.label5);
			this.pagePhoto.Controls.Add(this.txtPhotographer);
			this.pagePhoto.Controls.Add(this.label4);
			this.pagePhoto.Controls.Add(this.txtCaption);
			this.pagePhoto.Controls.Add(this.label3);
			this.pagePhoto.Controls.Add(this.btnNext);
			this.pagePhoto.Controls.Add(this.btnPrevious);
			this.pagePhoto.Controls.Add(this.pbxPhoto);
			this.pagePhoto.Controls.Add(this.txtFileName);
			this.pagePhoto.Controls.Add(this.label2);
			this.pagePhoto.Location = new System.Drawing.Point(4, 22);
			this.pagePhoto.Name = "pagePhoto";
			this.pagePhoto.Padding = new System.Windows.Forms.Padding(3);
			this.pagePhoto.Size = new System.Drawing.Size(410, 166);
			this.pagePhoto.TabIndex = 1;
			this.pagePhoto.Text = "Photo";
			this.pagePhoto.UseVisualStyleBackColor = true;
			// 
			// dtpDateTaken
			// 
			this.dtpDateTaken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpDateTaken.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDateTaken.Location = new System.Drawing.Point(220, 84);
			this.dtpDateTaken.Name = "dtpDateTaken";
			this.dtpDateTaken.Size = new System.Drawing.Size(184, 20);
			this.dtpDateTaken.TabIndex = 7;
			// 
			// txtNotes
			// 
			this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtNotes.Location = new System.Drawing.Point(150, 127);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Size = new System.Drawing.Size(254, 33);
			this.txtNotes.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(147, 111);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(38, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "&Notes:";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(147, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "&Date Taken:";
			// 
			// txtPhotographer
			// 
			this.txtPhotographer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPhotographer.Location = new System.Drawing.Point(220, 58);
			this.txtPhotographer.Name = "txtPhotographer";
			this.txtPhotographer.Size = new System.Drawing.Size(184, 20);
			this.txtPhotographer.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(147, 61);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "&Photographer:";
			// 
			// txtCaption
			// 
			this.txtCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCaption.Location = new System.Drawing.Point(220, 32);
			this.txtCaption.Name = "txtCaption";
			this.txtCaption.Size = new System.Drawing.Size(184, 20);
			this.txtCaption.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(147, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "&Caption:";
			// 
			// btnNext
			// 
			this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNext.Location = new System.Drawing.Point(77, 137);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(64, 23);
			this.btnNext.TabIndex = 11;
			this.btnNext.Text = "Nex&t";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPrevious.Location = new System.Drawing.Point(9, 137);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(64, 23);
			this.btnPrevious.TabIndex = 10;
			this.btnPrevious.Text = "Pre&vious";
			this.btnPrevious.UseVisualStyleBackColor = true;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// pbxPhoto
			// 
			this.pbxPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pbxPhoto.Location = new System.Drawing.Point(9, 32);
			this.pbxPhoto.Name = "pbxPhoto";
			this.pbxPhoto.Size = new System.Drawing.Size(132, 99);
			this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxPhoto.TabIndex = 2;
			this.pbxPhoto.TabStop = false;
			// 
			// txtFileName
			// 
			this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtFileName.Location = new System.Drawing.Point(66, 6);
			this.txtFileName.Name = "txtFileName";
			this.txtFileName.ReadOnly = true;
			this.txtFileName.Size = new System.Drawing.Size(338, 20);
			this.txtFileName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "&FileName:";
			// 
			// bsAlbum
			// 
			this.bsAlbum.CurrentChanged += new System.EventHandler(this.bsAlbum_CurrentChanged);
			// 
			// DataForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(442, 266);
			this.Controls.Add(this.tcMain);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.comboAlbum);
			this.Controls.Add(this.label1);
			this.Name = "DataForm";
			this.Text = "MyAlbumData";
			((System.ComponentModel.ISupportInitialize)(this.gridPhotoAlbum)).EndInit();
			this.tcMain.ResumeLayout(false);
			this.pageAlbum.ResumeLayout(false);
			this.pagePhoto.ResumeLayout(false);
			this.pagePhoto.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsAlbum)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboAlbum;
		private System.Windows.Forms.DataGridView gridPhotoAlbum;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.TabControl tcMain;
		private System.Windows.Forms.TabPage pageAlbum;
		private System.Windows.Forms.TabPage pagePhoto;
		private System.Windows.Forms.TextBox txtFileName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtPhotographer;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCaption;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.PictureBox pbxPhoto;
		private System.Windows.Forms.DateTimePicker dtpDateTaken;
		private System.Windows.Forms.BindingSource bsAlbum;
	}
}

