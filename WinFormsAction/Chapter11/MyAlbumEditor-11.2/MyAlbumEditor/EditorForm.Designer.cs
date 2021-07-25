namespace MyAlbumEditor
{
	partial class EditorForm
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
			this.grpAlbums = new System.Windows.Forms.GroupBox();
			this.btnOpen = new System.Windows.Forms.Button();
			this.grpPhotos = new System.Windows.Forms.GroupBox();
			this.lstPhotos = new System.Windows.Forms.ListBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnAlbumProps = new System.Windows.Forms.Button();
			this.btnPhotoProps = new System.Windows.Forms.Button();
			this.grpAlbums.SuspendLayout();
			this.grpPhotos.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpAlbums
			// 
			this.grpAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpAlbums.Controls.Add(this.btnAlbumProps);
			this.grpAlbums.Controls.Add(this.btnOpen);
			this.grpAlbums.Location = new System.Drawing.Point(12, 12);
			this.grpAlbums.Name = "grpAlbums";
			this.grpAlbums.Size = new System.Drawing.Size(368, 50);
			this.grpAlbums.TabIndex = 0;
			this.grpAlbums.TabStop = false;
			this.grpAlbums.Text = "&Albums";
			// 
			// btnOpen
			// 
			this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpen.Location = new System.Drawing.Point(206, 14);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(75, 23);
			this.btnOpen.TabIndex = 0;
			this.btnOpen.Text = "&Open";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// grpPhotos
			// 
			this.grpPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpPhotos.Controls.Add(this.btnPhotoProps);
			this.grpPhotos.Controls.Add(this.lstPhotos);
			this.grpPhotos.Enabled = false;
			this.grpPhotos.Location = new System.Drawing.Point(12, 68);
			this.grpPhotos.Name = "grpPhotos";
			this.grpPhotos.Size = new System.Drawing.Size(368, 157);
			this.grpPhotos.TabIndex = 0;
			this.grpPhotos.TabStop = false;
			this.grpPhotos.Text = "&Photographs";
			// 
			// lstPhotos
			// 
			this.lstPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lstPhotos.FormattingEnabled = true;
			this.lstPhotos.HorizontalScrollbar = true;
			this.lstPhotos.Location = new System.Drawing.Point(6, 19);
			this.lstPhotos.Name = "lstPhotos";
			this.lstPhotos.Size = new System.Drawing.Size(275, 121);
			this.lstPhotos.TabIndex = 0;
			this.lstPhotos.DoubleClick += new System.EventHandler(this.lstPhotos_DoubleClick);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnClose.Location = new System.Drawing.Point(155, 231);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "&Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnAlbumProps
			// 
			this.btnAlbumProps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAlbumProps.Enabled = false;
			this.btnAlbumProps.Location = new System.Drawing.Point(287, 14);
			this.btnAlbumProps.Name = "btnAlbumProps";
			this.btnAlbumProps.Size = new System.Drawing.Size(75, 23);
			this.btnAlbumProps.TabIndex = 1;
			this.btnAlbumProps.Text = "Propertie&s";
			this.btnAlbumProps.UseVisualStyleBackColor = true;
			this.btnAlbumProps.Click += new System.EventHandler(this.btnAlbumProps_Click);
			// 
			// btnPhotoProps
			// 
			this.btnPhotoProps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPhotoProps.Location = new System.Drawing.Point(287, 19);
			this.btnPhotoProps.Name = "btnPhotoProps";
			this.btnPhotoProps.Size = new System.Drawing.Size(75, 23);
			this.btnPhotoProps.TabIndex = 2;
			this.btnPhotoProps.Text = "Properti&es";
			this.btnPhotoProps.UseVisualStyleBackColor = true;
			this.btnPhotoProps.Click += new System.EventHandler(this.btnPhotoProps_Click);
			// 
			// EditorForm
			// 
			this.AcceptButton = this.btnClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(392, 266);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.grpPhotos);
			this.Controls.Add(this.grpAlbums);
			this.Name = "EditorForm";
			this.Text = "MyAlbumEditor";
			this.grpAlbums.ResumeLayout(false);
			this.grpPhotos.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpAlbums;
		private System.Windows.Forms.GroupBox grpPhotos;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.ListBox lstPhotos;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnAlbumProps;
		private System.Windows.Forms.Button btnPhotoProps;
	}
}

