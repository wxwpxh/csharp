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
			this.components = new System.ComponentModel.Container();
			this.pbxPhoto = new System.Windows.Forms.PictureBox();
			this.ctxMenuPhoto = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuImage = new System.Windows.Forms.ToolStripMenuItem();
			this.menuImageScale = new System.Windows.Forms.ToolStripMenuItem();
			this.menuImageStretch = new System.Windows.Forms.ToolStripMenuItem();
			this.menuImageActual = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFileLoad = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuView = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
			this.ctxMenuPhoto.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbxPhoto
			// 
			this.pbxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbxPhoto.ContextMenuStrip = this.ctxMenuPhoto;
			this.pbxPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbxPhoto.Location = new System.Drawing.Point(0, 24);
			this.pbxPhoto.Name = "pbxPhoto";
			this.pbxPhoto.Size = new System.Drawing.Size(292, 242);
			this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxPhoto.TabIndex = 1;
			this.pbxPhoto.TabStop = false;
			// 
			// ctxMenuPhoto
			// 
			this.ctxMenuPhoto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImage});
			this.ctxMenuPhoto.Name = "ctxMenuPhoto";
			this.ctxMenuPhoto.Size = new System.Drawing.Size(153, 48);
			// 
			// menuImage
			// 
			this.menuImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImageScale,
            this.menuImageStretch,
            this.menuImageActual});
			this.menuImage.Name = "menuImage";
			this.menuImage.Size = new System.Drawing.Size(152, 22);
			this.menuImage.Text = "&Image";
			this.menuImage.DropDownOpening += new System.EventHandler(this.menuImage_DropDownOpening);
			this.menuImage.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuImage_DropDownItemClicked);
			// 
			// menuImageScale
			// 
			this.menuImageScale.Checked = true;
			this.menuImageScale.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuImageScale.Name = "menuImageScale";
			this.menuImageScale.Size = new System.Drawing.Size(152, 22);
			this.menuImageScale.Tag = "Zoom";
			this.menuImageScale.Text = "&Scale to Fit";
			// 
			// menuImageStretch
			// 
			this.menuImageStretch.Name = "menuImageStretch";
			this.menuImageStretch.Size = new System.Drawing.Size(152, 22);
			this.menuImageStretch.Tag = "StretchImage";
			this.menuImageStretch.Text = "S&tretch to Fit";
			// 
			// menuImageActual
			// 
			this.menuImageActual.Name = "menuImageActual";
			this.menuImageActual.Size = new System.Drawing.Size(152, 22);
			this.menuImageActual.Tag = "Normal";
			this.menuImageActual.Text = "&Actual Size";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuView});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(292, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuFile
			// 
			this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileLoad,
            this.toolStripMenuItem1,
            this.menuFileExit});
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new System.Drawing.Size(35, 20);
			this.menuFile.Text = "&File";
			// 
			// menuFileLoad
			// 
			this.menuFileLoad.Name = "menuFileLoad";
			this.menuFileLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
			this.menuFileLoad.Size = new System.Drawing.Size(145, 22);
			this.menuFileLoad.Text = "&Load";
			this.menuFileLoad.Click += new System.EventHandler(this.menuFileLoad_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(142, 6);
			// 
			// menuFileExit
			// 
			this.menuFileExit.Name = "menuFileExit";
			this.menuFileExit.Size = new System.Drawing.Size(145, 22);
			this.menuFileExit.Text = "E&xit";
			this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
			// 
			// menuView
			// 
			this.menuView.Name = "menuView";
			this.menuView.Size = new System.Drawing.Size(41, 20);
			this.menuView.Text = "&View";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.pbxPhoto);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "MyPhotos";
			((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
			this.ctxMenuPhoto.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pbxPhoto;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuFile;
		private System.Windows.Forms.ToolStripMenuItem menuFileLoad;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem menuFileExit;
		private System.Windows.Forms.ContextMenuStrip ctxMenuPhoto;
		private System.Windows.Forms.ToolStripMenuItem menuImage;
		private System.Windows.Forms.ToolStripMenuItem menuImageScale;
		private System.Windows.Forms.ToolStripMenuItem menuImageStretch;
		private System.Windows.Forms.ToolStripMenuItem menuImageActual;
		private System.Windows.Forms.ToolStripMenuItem menuView;
	}
}

