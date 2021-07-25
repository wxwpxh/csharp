namespace MyPhotos
{
	partial class SlideShowDialog
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
			this.btnPrev = new System.Windows.Forms.Button();
			this.trackAlbum = new System.Windows.Forms.TrackBar();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.pbxSlide = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.trackAlbum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxSlide)).BeginInit();
			this.SuspendLayout();
			// 
			// btnPrev
			// 
			this.btnPrev.Location = new System.Drawing.Point(13, 204);
			this.btnPrev.Name = "btnPrev";
			this.btnPrev.Size = new System.Drawing.Size(30, 23);
			this.btnPrev.TabIndex = 2;
			this.btnPrev.UseVisualStyleBackColor = true;
			this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
			// 
			// trackAlbum
			// 
			this.trackAlbum.Location = new System.Drawing.Point(49, 204);
			this.trackAlbum.Name = "trackAlbum";
			this.trackAlbum.Size = new System.Drawing.Size(195, 45);
			this.trackAlbum.TabIndex = 3;
			this.trackAlbum.ValueChanged += new System.EventHandler(this.trackAlbum_ValueChanged);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(250, 204);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(30, 23);
			this.btnNext.TabIndex = 4;
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(12, 251);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "&Start";
			this.btnStart.UseVisualStyleBackColor = true;
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(205, 251);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "&Close";
			this.btnClose.UseVisualStyleBackColor = true;
			// 
			// pbxSlide
			// 
			this.pbxSlide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbxSlide.Location = new System.Drawing.Point(12, 12);
			this.pbxSlide.Name = "pbxSlide";
			this.pbxSlide.Size = new System.Drawing.Size(268, 186);
			this.pbxSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxSlide.TabIndex = 0;
			this.pbxSlide.TabStop = false;
			// 
			// SlideShowDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 286);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.trackAlbum);
			this.Controls.Add(this.btnPrev);
			this.Controls.Add(this.pbxSlide);
			this.Name = "SlideShowDialog";
			this.Text = "SlideShowDialog";
			((System.ComponentModel.ISupportInitialize)(this.trackAlbum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxSlide)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pbxSlide;
		private System.Windows.Forms.Button btnPrev;
		private System.Windows.Forms.TrackBar trackAlbum;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnClose;
	}
}