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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.statusInfo = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusImageSize = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusAlbumPos = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusBorder = new System.Windows.Forms.ToolStripDropDownButton();
			this.menuBorderAdjust = new System.Windows.Forms.ToolStripMenuItem();
			this.menuBorderBump = new System.Windows.Forms.ToolStripMenuItem();
			this.menuBorderEtched = new System.Windows.Forms.ToolStripMenuItem();
			this.menuBorderFlat = new System.Windows.Forms.ToolStripMenuItem();
			this.menuBorderRaised = new System.Windows.Forms.ToolStripMenuItem();
			this.menuBorderRaisedInner = new System.Windows.Forms.ToolStripMenuItem();
			this.menuBorderRaisedOuter = new System.Windows.Forms.ToolStripMenuItem();
			this.menuBorderSunken = new System.Windows.Forms.ToolStripMenuItem();
			this.menuBorderSunkenInner = new System.Windows.Forms.ToolStripMenuItem();
			this.menuBorderSunkenOuter = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
			this.ctxMenuPhoto.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbxPhoto
			// 
			this.pbxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbxPhoto.ContextMenuStrip = this.ctxMenuPhoto;
			this.pbxPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbxPhoto.Location = new System.Drawing.Point(0, 24);
			this.pbxPhoto.Name = "pbxPhoto";
			this.pbxPhoto.Size = new System.Drawing.Size(292, 220);
			this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxPhoto.TabIndex = 1;
			this.pbxPhoto.TabStop = false;
			// 
			// ctxMenuPhoto
			// 
			this.ctxMenuPhoto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImage});
			this.ctxMenuPhoto.Name = "ctxMenuPhoto";
			this.ctxMenuPhoto.Size = new System.Drawing.Size(116, 26);
			// 
			// menuImage
			// 
			this.menuImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImageScale,
            this.menuImageStretch,
            this.menuImageActual});
			this.menuImage.Name = "menuImage";
			this.menuImage.Size = new System.Drawing.Size(115, 22);
			this.menuImage.Text = "&Image";
			this.menuImage.DropDownOpening += new System.EventHandler(this.menuImage_DropDownOpening);
			this.menuImage.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuImage_DropDownItemClicked);
			// 
			// menuImageScale
			// 
			this.menuImageScale.Checked = true;
			this.menuImageScale.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuImageScale.Name = "menuImageScale";
			this.menuImageScale.Size = new System.Drawing.Size(148, 22);
			this.menuImageScale.Tag = "Zoom";
			this.menuImageScale.Text = "&Scale to Fit";
			// 
			// menuImageStretch
			// 
			this.menuImageStretch.Name = "menuImageStretch";
			this.menuImageStretch.Size = new System.Drawing.Size(148, 22);
			this.menuImageStretch.Tag = "StretchImage";
			this.menuImageStretch.Text = "S&tretch to Fit";
			// 
			// menuImageActual
			// 
			this.menuImageActual.Name = "menuImageActual";
			this.menuImageActual.Size = new System.Drawing.Size(148, 22);
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
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusInfo,
            this.statusImageSize,
            this.statusBorder,
            this.statusAlbumPos});
			this.statusStrip1.Location = new System.Drawing.Point(0, 244);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.ShowItemToolTips = true;
			this.statusStrip1.Size = new System.Drawing.Size(292, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// statusInfo
			// 
			this.statusInfo.AutoSize = false;
			this.statusInfo.Name = "statusInfo";
			this.statusInfo.Size = new System.Drawing.Size(99, 17);
			this.statusInfo.Spring = true;
			this.statusInfo.Text = "Desc";
			this.statusInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// statusImageSize
			// 
			this.statusImageSize.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
						| System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
						| System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.statusImageSize.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
			this.statusImageSize.Name = "statusImageSize";
			this.statusImageSize.Size = new System.Drawing.Size(40, 17);
			this.statusImageSize.Text = "W x H";
			// 
			// statusAlbumPos
			// 
			this.statusAlbumPos.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
						| System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
						| System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.statusAlbumPos.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
			this.statusAlbumPos.Name = "statusAlbumPos";
			this.statusAlbumPos.Size = new System.Drawing.Size(33, 17);
			this.statusAlbumPos.Text = "1 / 1";
			// 
			// statusBorder
			// 
			this.statusBorder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.statusBorder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBorderAdjust,
            this.menuBorderBump,
            this.menuBorderEtched,
            this.menuBorderFlat,
            this.menuBorderRaised,
            this.menuBorderRaisedInner,
            this.menuBorderRaisedOuter,
            this.menuBorderSunken,
            this.menuBorderSunkenInner,
            this.menuBorderSunkenOuter});
			this.statusBorder.Image = ((System.Drawing.Image)(resources.GetObject("statusBorder.Image")));
			this.statusBorder.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.statusBorder.Name = "statusBorder";
			this.statusBorder.Size = new System.Drawing.Size(74, 20);
			this.statusBorder.Text = "Size Border";
			this.statusBorder.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusBorder_DropDownItemClicked);
			// 
			// menuBorderAdjust
			// 
			this.menuBorderAdjust.Name = "menuBorderAdjust";
			this.menuBorderAdjust.Size = new System.Drawing.Size(152, 22);
			this.menuBorderAdjust.Tag = "";
			this.menuBorderAdjust.Text = "Adjust";
			// 
			// menuBorderBump
			// 
			this.menuBorderBump.Name = "menuBorderBump";
			this.menuBorderBump.Size = new System.Drawing.Size(152, 22);
			this.menuBorderBump.Text = "Bump";
			// 
			// menuBorderEtched
			// 
			this.menuBorderEtched.Name = "menuBorderEtched";
			this.menuBorderEtched.Size = new System.Drawing.Size(152, 22);
			this.menuBorderEtched.Text = "Etched";
			// 
			// menuBorderFlat
			// 
			this.menuBorderFlat.Name = "menuBorderFlat";
			this.menuBorderFlat.Size = new System.Drawing.Size(152, 22);
			this.menuBorderFlat.Text = "Flat";
			// 
			// menuBorderRaised
			// 
			this.menuBorderRaised.Name = "menuBorderRaised";
			this.menuBorderRaised.Size = new System.Drawing.Size(152, 22);
			this.menuBorderRaised.Text = "Raised";
			// 
			// menuBorderRaisedInner
			// 
			this.menuBorderRaisedInner.Name = "menuBorderRaisedInner";
			this.menuBorderRaisedInner.Size = new System.Drawing.Size(152, 22);
			this.menuBorderRaisedInner.Text = "RaisedInner";
			// 
			// menuBorderRaisedOuter
			// 
			this.menuBorderRaisedOuter.Name = "menuBorderRaisedOuter";
			this.menuBorderRaisedOuter.Size = new System.Drawing.Size(152, 22);
			this.menuBorderRaisedOuter.Text = "RaisedOuter";
			// 
			// menuBorderSunken
			// 
			this.menuBorderSunken.Name = "menuBorderSunken";
			this.menuBorderSunken.Size = new System.Drawing.Size(152, 22);
			this.menuBorderSunken.Text = "Sunken";
			// 
			// menuBorderSunkenInner
			// 
			this.menuBorderSunkenInner.Name = "menuBorderSunkenInner";
			this.menuBorderSunkenInner.Size = new System.Drawing.Size(152, 22);
			this.menuBorderSunkenInner.Text = "SunkenInner";
			// 
			// menuBorderSunkenOuter
			// 
			this.menuBorderSunkenOuter.Name = "menuBorderSunkenOuter";
			this.menuBorderSunkenOuter.Size = new System.Drawing.Size(152, 22);
			this.menuBorderSunkenOuter.Text = "SunkenOuter";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.pbxPhoto);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "MyPhotos";
			((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
			this.ctxMenuPhoto.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
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
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel statusInfo;
		private System.Windows.Forms.ToolStripStatusLabel statusImageSize;
		private System.Windows.Forms.ToolStripStatusLabel statusAlbumPos;
		private System.Windows.Forms.ToolStripDropDownButton statusBorder;
		private System.Windows.Forms.ToolStripMenuItem menuBorderAdjust;
		private System.Windows.Forms.ToolStripMenuItem menuBorderBump;
		private System.Windows.Forms.ToolStripMenuItem menuBorderEtched;
		private System.Windows.Forms.ToolStripMenuItem menuBorderFlat;
		private System.Windows.Forms.ToolStripMenuItem menuBorderRaised;
		private System.Windows.Forms.ToolStripMenuItem menuBorderRaisedInner;
		private System.Windows.Forms.ToolStripMenuItem menuBorderRaisedOuter;
		private System.Windows.Forms.ToolStripMenuItem menuBorderSunken;
		private System.Windows.Forms.ToolStripMenuItem menuBorderSunkenInner;
		private System.Windows.Forms.ToolStripMenuItem menuBorderSunkenOuter;
	}
}

