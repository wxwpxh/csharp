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
			this.btnAlbumProps = new System.Windows.Forms.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			this.grpPhotos = new System.Windows.Forms.GroupBox();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnMoveDown = new System.Windows.Forms.Button();
			this.btnMoveUp = new System.Windows.Forms.Button();
			this.btnPhotoProps = new System.Windows.Forms.Button();
			this.lstPhotos = new System.Windows.Forms.ListBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
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
			this.grpPhotos.Controls.Add(this.btnAdd);
			this.grpPhotos.Controls.Add(this.btnRemove);
			this.grpPhotos.Controls.Add(this.btnMoveDown);
			this.grpPhotos.Controls.Add(this.btnMoveUp);
			this.grpPhotos.Controls.Add(this.btnPhotoProps);
			this.grpPhotos.Controls.Add(this.lstPhotos);
			this.grpPhotos.Enabled = false;
			this.grpPhotos.Location = new System.Drawing.Point(12, 68);
			this.grpPhotos.Name = "grpPhotos";
			this.grpPhotos.Size = new System.Drawing.Size(368, 168);
			this.grpPhotos.TabIndex = 0;
			this.grpPhotos.TabStop = false;
			this.grpPhotos.Text = "&Photographs";
			// 
			// btnRemove
			// 
			this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRemove.Location = new System.Drawing.Point(287, 106);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(75, 23);
			this.btnRemove.TabIndex = 5;
			this.btnRemove.Text = "&Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnMoveDown
			// 
			this.btnMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMoveDown.Location = new System.Drawing.Point(287, 48);
			this.btnMoveDown.Name = "btnMoveDown";
			this.btnMoveDown.Size = new System.Drawing.Size(75, 23);
			this.btnMoveDown.TabIndex = 4;
			this.btnMoveDown.Text = "Move &Down";
			this.btnMoveDown.UseVisualStyleBackColor = true;
			this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
			// 
			// btnMoveUp
			// 
			this.btnMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMoveUp.Location = new System.Drawing.Point(287, 19);
			this.btnMoveUp.Name = "btnMoveUp";
			this.btnMoveUp.Size = new System.Drawing.Size(75, 23);
			this.btnMoveUp.TabIndex = 3;
			this.btnMoveUp.Text = "Move &Up";
			this.btnMoveUp.UseVisualStyleBackColor = true;
			this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
			// 
			// btnPhotoProps
			// 
			this.btnPhotoProps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPhotoProps.Location = new System.Drawing.Point(287, 135);
			this.btnPhotoProps.Name = "btnPhotoProps";
			this.btnPhotoProps.Size = new System.Drawing.Size(75, 23);
			this.btnPhotoProps.TabIndex = 2;
			this.btnPhotoProps.Text = "Properti&es";
			this.btnPhotoProps.UseVisualStyleBackColor = true;
			this.btnPhotoProps.Click += new System.EventHandler(this.btnPhotoProps_Click);
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
			this.lstPhotos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstPhotos.Size = new System.Drawing.Size(275, 134);
			this.lstPhotos.TabIndex = 0;
			this.lstPhotos.DoubleClick += new System.EventHandler(this.lstPhotos_DoubleClick);
			this.lstPhotos.SelectedIndexChanged += new System.EventHandler(this.lstPhotos_SelectedIndexChanged);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnClose.Location = new System.Drawing.Point(155, 242);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "&Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.Location = new System.Drawing.Point(287, 77);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "&Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// EditorForm
			// 
			this.AcceptButton = this.btnClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(392, 277);
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
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnMoveDown;
		private System.Windows.Forms.Button btnMoveUp;
		private System.Windows.Forms.Button btnAdd;
	}
}

