namespace Manning.MyPhotoControls
{
	partial class AlbumEditDialog
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtAlbumFile = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbtnDateTaken = new System.Windows.Forms.RadioButton();
			this.rbtnCaption = new System.Windows.Forms.RadioButton();
			this.rbtnFileName = new System.Windows.Forms.RadioButton();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtTitle);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtAlbumFile);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Size = new System.Drawing.Size(268, 71);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Album &File:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtAlbumFile
			// 
			this.txtAlbumFile.Location = new System.Drawing.Point(79, 10);
			this.txtAlbumFile.Name = "txtAlbumFile";
			this.txtAlbumFile.ReadOnly = true;
			this.txtAlbumFile.Size = new System.Drawing.Size(184, 20);
			this.txtAlbumFile.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(43, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "&Title:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(79, 40);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(184, 20);
			this.txtTitle.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbtnDateTaken);
			this.groupBox1.Controls.Add(this.rbtnCaption);
			this.groupBox1.Controls.Add(this.rbtnFileName);
			this.groupBox1.Location = new System.Drawing.Point(12, 89);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(268, 48);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Phot&o Description";
			// 
			// rbtnDateTaken
			// 
			this.rbtnDateTaken.AutoSize = true;
			this.rbtnDateTaken.Location = new System.Drawing.Point(175, 19);
			this.rbtnDateTaken.Name = "rbtnDateTaken";
			this.rbtnDateTaken.Size = new System.Drawing.Size(82, 17);
			this.rbtnDateTaken.TabIndex = 2;
			this.rbtnDateTaken.TabStop = true;
			this.rbtnDateTaken.Text = "&Date Taken";
			this.rbtnDateTaken.UseVisualStyleBackColor = true;
			// 
			// rbtnCaption
			// 
			this.rbtnCaption.AutoSize = true;
			this.rbtnCaption.Location = new System.Drawing.Point(104, 19);
			this.rbtnCaption.Name = "rbtnCaption";
			this.rbtnCaption.Size = new System.Drawing.Size(61, 17);
			this.rbtnCaption.TabIndex = 1;
			this.rbtnCaption.TabStop = true;
			this.rbtnCaption.Text = "&Caption";
			this.rbtnCaption.UseVisualStyleBackColor = true;
			// 
			// rbtnFileName
			// 
			this.rbtnFileName.AutoSize = true;
			this.rbtnFileName.Location = new System.Drawing.Point(24, 19);
			this.rbtnFileName.Name = "rbtnFileName";
			this.rbtnFileName.Size = new System.Drawing.Size(70, 17);
			this.rbtnFileName.TabIndex = 0;
			this.rbtnFileName.TabStop = true;
			this.rbtnFileName.Text = "File &name";
			this.rbtnFileName.UseVisualStyleBackColor = true;
			// 
			// AlbumEditDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.groupBox1);
			this.Name = "AlbumEditDialog";
			this.Text = "Album Properties";
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAlbumFile;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbtnDateTaken;
		private System.Windows.Forms.RadioButton rbtnCaption;
		private System.Windows.Forms.RadioButton rbtnFileName;
	}
}
