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
			((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(12, 12);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(75, 23);
			this.btnLoad.TabIndex = 0;
			this.btnLoad.Text = "&Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// pbxPhoto
			// 
			this.pbxPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pbxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbxPhoto.Location = new System.Drawing.Point(12, 41);
			this.pbxPhoto.Name = "pbxPhoto";
			this.pbxPhoto.Size = new System.Drawing.Size(268, 213);
			this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxPhoto.TabIndex = 1;
			this.pbxPhoto.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.pbxPhoto);
			this.Controls.Add(this.btnLoad);
			this.Name = "MainForm";
			this.Text = "MyPhotos";
			((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.PictureBox pbxPhoto;
	}
}

