namespace MyPhotos
{
	partial class MainForm
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.btnLoad2 = new System.Windows.Forms.Button();
            this.pbxPhoto2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(16, 14);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 27);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxPhoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbxPhoto.Location = new System.Drawing.Point(0, 0);
            this.pbxPhoto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(389, 130);
            this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPhoto.TabIndex = 1;
            this.pbxPhoto.TabStop = false;
            this.pbxPhoto.Click += new System.EventHandler(this.pbxPhoto_Click);
            // 
            // btnLoad2
            // 
            this.btnLoad2.Location = new System.Drawing.Point(124, 14);
            this.btnLoad2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoad2.Name = "btnLoad2";
            this.btnLoad2.Size = new System.Drawing.Size(100, 27);
            this.btnLoad2.TabIndex = 2;
            this.btnLoad2.Text = "L&oad2";
            this.btnLoad2.UseVisualStyleBackColor = true;
            this.btnLoad2.Click += new System.EventHandler(this.btnLoad2_Click);
            // 
            // pbxPhoto2
            // 
            this.pbxPhoto2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxPhoto2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxPhoto2.Location = new System.Drawing.Point(0, 130);
            this.pbxPhoto2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbxPhoto2.Name = "pbxPhoto2";
            this.pbxPhoto2.Size = new System.Drawing.Size(389, 177);
            this.pbxPhoto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPhoto2.TabIndex = 3;
            this.pbxPhoto2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 307);
            this.Controls.Add(this.pbxPhoto2);
            this.Controls.Add(this.btnLoad2);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pbxPhoto);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "MyPhotos";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto2)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.PictureBox pbxPhoto;
		private System.Windows.Forms.Button btnLoad2;
		private System.Windows.Forms.PictureBox pbxPhoto2;
	}
}

