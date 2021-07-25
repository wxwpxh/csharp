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
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.menuNext = new System.Windows.Forms.ToolStripMenuItem();
			this.menuPrevious = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.menuPixelData = new System.Windows.Forms.ToolStripMenuItem();
			this.menuPhotoProps = new System.Windows.Forms.ToolStripMenuItem();
			this.menuAlbumProps = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuFilePrint = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFilePrintPreview = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuEditCut = new System.Windows.Forms.ToolStripMenuItem();
			this.menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuEditAdd = new System.Windows.Forms.ToolStripMenuItem();
			this.menuEditRemove = new System.Windows.Forms.ToolStripMenuItem();
			this.menuView = new System.Windows.Forms.ToolStripMenuItem();
			this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.statusInfo = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusImageSize = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusAlbumPos = new System.Windows.Forms.ToolStripStatusLabel();
			this.flybyProvider = new Manning.MyPhotoControls.FlybyTextProvider(this.components);
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
			this.pbxPhoto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxPhoto_MouseMove);
			// 
			// ctxMenuPhoto
			// 
			this.ctxMenuPhoto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImage,
            this.toolStripMenuItem2,
            this.menuNext,
            this.menuPrevious,
            this.toolStripMenuItem3,
            this.menuPixelData,
            this.menuPhotoProps,
            this.menuAlbumProps});
			this.ctxMenuPhoto.Name = "ctxMenuPhoto";
			this.ctxMenuPhoto.Size = new System.Drawing.Size(195, 148);
			this.ctxMenuPhoto.Opening += new System.ComponentModel.CancelEventHandler(this.ctxMenuPhoto_Opening);
			// 
			// menuImage
			// 
			this.menuImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImageScale,
            this.menuImageStretch,
            this.menuImageActual});
			this.flybyProvider.SetFlybyText(this.menuImage, null);
			this.menuImage.Name = "menuImage";
			this.menuImage.Size = new System.Drawing.Size(194, 22);
			this.menuImage.Text = "&Image";
			this.menuImage.DropDownOpening += new System.EventHandler(this.menuImage_DropDownOpening);
			this.menuImage.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuImage_DropDownItemClicked);
			// 
			// menuImageScale
			// 
			this.menuImageScale.Checked = true;
			this.menuImageScale.CheckState = System.Windows.Forms.CheckState.Checked;
			this.flybyProvider.SetFlybyText(this.menuImageScale, null);
			this.menuImageScale.Name = "menuImageScale";
			this.menuImageScale.Size = new System.Drawing.Size(148, 22);
			this.menuImageScale.Tag = "Zoom";
			this.menuImageScale.Text = "&Scale to Fit";
			// 
			// menuImageStretch
			// 
			this.flybyProvider.SetFlybyText(this.menuImageStretch, null);
			this.menuImageStretch.Name = "menuImageStretch";
			this.menuImageStretch.Size = new System.Drawing.Size(148, 22);
			this.menuImageStretch.Tag = "StretchImage";
			this.menuImageStretch.Text = "S&tretch to Fit";
			// 
			// menuImageActual
			// 
			this.flybyProvider.SetFlybyText(this.menuImageActual, null);
			this.menuImageActual.Name = "menuImageActual";
			this.menuImageActual.Size = new System.Drawing.Size(148, 22);
			this.menuImageActual.Tag = "Normal";
			this.menuImageActual.Text = "&Actual Size";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(191, 6);
			// 
			// menuNext
			// 
			this.flybyProvider.SetFlybyText(this.menuNext, null);
			this.menuNext.Name = "menuNext";
			this.menuNext.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
						| System.Windows.Forms.Keys.N)));
			this.menuNext.Size = new System.Drawing.Size(194, 22);
			this.menuNext.Text = "&Next";
			this.menuNext.Click += new System.EventHandler(this.menuNext_Click);
			// 
			// menuPrevious
			// 
			this.flybyProvider.SetFlybyText(this.menuPrevious, null);
			this.menuPrevious.Name = "menuPrevious";
			this.menuPrevious.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
						| System.Windows.Forms.Keys.P)));
			this.menuPrevious.Size = new System.Drawing.Size(194, 22);
			this.menuPrevious.Text = "&Previous";
			this.menuPrevious.Click += new System.EventHandler(this.menuPrevious_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(191, 6);
			// 
			// menuPixelData
			// 
			this.flybyProvider.SetFlybyText(this.menuPixelData, null);
			this.menuPixelData.Name = "menuPixelData";
			this.menuPixelData.Size = new System.Drawing.Size(194, 22);
			this.menuPixelData.Text = "Pi&xel Data...";
			this.menuPixelData.Click += new System.EventHandler(this.menuPixelData_Click);
			// 
			// menuPhotoProps
			// 
			this.flybyProvider.SetFlybyText(this.menuPhotoProps, null);
			this.menuPhotoProps.Name = "menuPhotoProps";
			this.menuPhotoProps.Size = new System.Drawing.Size(194, 22);
			this.menuPhotoProps.Text = "Phot&o Properties…";
			this.menuPhotoProps.Click += new System.EventHandler(this.menuPhotoProps_Click);
			// 
			// menuAlbumProps
			// 
			this.flybyProvider.SetFlybyText(this.menuAlbumProps, null);
			this.menuAlbumProps.Name = "menuAlbumProps";
			this.menuAlbumProps.Size = new System.Drawing.Size(194, 22);
			this.menuAlbumProps.Text = "Albu&m Properties…";
			this.menuAlbumProps.Click += new System.EventHandler(this.menuAlbumProps_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuView,
            this.menuHelp});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(292, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuFile
			// 
			this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.toolStripSeparator,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.toolStripSeparator1,
            this.menuFilePrint,
            this.menuFilePrintPreview,
            this.toolStripSeparator2,
            this.menuFileExit});
			this.flybyProvider.SetFlybyText(this.menuFile, "The File menu");
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new System.Drawing.Size(35, 20);
			this.menuFile.Text = "&File";
			// 
			// menuFileNew
			// 
			this.flybyProvider.SetFlybyText(this.menuFileNew, null);
			this.menuFileNew.Image = ((System.Drawing.Image)(resources.GetObject("menuFileNew.Image")));
			this.menuFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.menuFileNew.Name = "menuFileNew";
			this.menuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.menuFileNew.Size = new System.Drawing.Size(151, 22);
			this.menuFileNew.Text = "&New";
			this.menuFileNew.Click += new System.EventHandler(this.menuFileNew_Click);
			// 
			// menuFileOpen
			// 
			this.flybyProvider.SetFlybyText(this.menuFileOpen, null);
			this.menuFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("menuFileOpen.Image")));
			this.menuFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.menuFileOpen.Name = "menuFileOpen";
			this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.menuFileOpen.Size = new System.Drawing.Size(151, 22);
			this.menuFileOpen.Text = "&Open";
			this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(148, 6);
			// 
			// menuFileSave
			// 
			this.flybyProvider.SetFlybyText(this.menuFileSave, null);
			this.menuFileSave.Image = ((System.Drawing.Image)(resources.GetObject("menuFileSave.Image")));
			this.menuFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.menuFileSave.Name = "menuFileSave";
			this.menuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.menuFileSave.Size = new System.Drawing.Size(151, 22);
			this.menuFileSave.Text = "&Save";
			this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
			// 
			// menuFileSaveAs
			// 
			this.flybyProvider.SetFlybyText(this.menuFileSaveAs, null);
			this.menuFileSaveAs.Name = "menuFileSaveAs";
			this.menuFileSaveAs.Size = new System.Drawing.Size(151, 22);
			this.menuFileSaveAs.Text = "Save &As";
			this.menuFileSaveAs.Click += new System.EventHandler(this.menuFileSaveAs_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
			// 
			// menuFilePrint
			// 
			this.flybyProvider.SetFlybyText(this.menuFilePrint, null);
			this.menuFilePrint.Image = ((System.Drawing.Image)(resources.GetObject("menuFilePrint.Image")));
			this.menuFilePrint.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.menuFilePrint.Name = "menuFilePrint";
			this.menuFilePrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.menuFilePrint.Size = new System.Drawing.Size(151, 22);
			this.menuFilePrint.Text = "&Print";
			// 
			// menuFilePrintPreview
			// 
			this.flybyProvider.SetFlybyText(this.menuFilePrintPreview, null);
			this.menuFilePrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("menuFilePrintPreview.Image")));
			this.menuFilePrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.menuFilePrintPreview.Name = "menuFilePrintPreview";
			this.menuFilePrintPreview.Size = new System.Drawing.Size(151, 22);
			this.menuFilePrintPreview.Text = "Print Pre&view";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(148, 6);
			// 
			// menuFileExit
			// 
			this.flybyProvider.SetFlybyText(this.menuFileExit, null);
			this.menuFileExit.Name = "menuFileExit";
			this.menuFileExit.Size = new System.Drawing.Size(151, 22);
			this.menuFileExit.Text = "E&xit";
			this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
			// 
			// menuEdit
			// 
			this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditCut,
            this.menuEditCopy,
            this.menuEditPaste,
            this.toolStripMenuItem1,
            this.menuEditAdd,
            this.menuEditRemove});
			this.flybyProvider.SetFlybyText(this.menuEdit, null);
			this.menuEdit.Name = "menuEdit";
			this.menuEdit.Size = new System.Drawing.Size(37, 20);
			this.menuEdit.Text = "&Edit";
			this.menuEdit.DropDownOpening += new System.EventHandler(this.menuEdit_DropDownOpening);
			// 
			// menuEditCut
			// 
			this.flybyProvider.SetFlybyText(this.menuEditCut, null);
			this.menuEditCut.Image = ((System.Drawing.Image)(resources.GetObject("menuEditCut.Image")));
			this.menuEditCut.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.menuEditCut.Name = "menuEditCut";
			this.menuEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.menuEditCut.Size = new System.Drawing.Size(193, 22);
			this.menuEditCut.Text = "Cu&t";
			this.menuEditCut.Click += new System.EventHandler(this.menuEditCut_Click);
			// 
			// menuEditCopy
			// 
			this.flybyProvider.SetFlybyText(this.menuEditCopy, null);
			this.menuEditCopy.Image = ((System.Drawing.Image)(resources.GetObject("menuEditCopy.Image")));
			this.menuEditCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.menuEditCopy.Name = "menuEditCopy";
			this.menuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.menuEditCopy.Size = new System.Drawing.Size(193, 22);
			this.menuEditCopy.Text = "&Copy";
			this.menuEditCopy.Click += new System.EventHandler(this.menuEditCopy_Click);
			// 
			// menuEditPaste
			// 
			this.flybyProvider.SetFlybyText(this.menuEditPaste, null);
			this.menuEditPaste.Image = ((System.Drawing.Image)(resources.GetObject("menuEditPaste.Image")));
			this.menuEditPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.menuEditPaste.Name = "menuEditPaste";
			this.menuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.menuEditPaste.Size = new System.Drawing.Size(193, 22);
			this.menuEditPaste.Text = "&Paste";
			this.menuEditPaste.Click += new System.EventHandler(this.menuEditPaste_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 6);
			// 
			// menuEditAdd
			// 
			this.flybyProvider.SetFlybyText(this.menuEditAdd, null);
			this.menuEditAdd.Name = "menuEditAdd";
			this.menuEditAdd.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
						| System.Windows.Forms.Keys.A)));
			this.menuEditAdd.Size = new System.Drawing.Size(193, 22);
			this.menuEditAdd.Text = "Ad&d";
			this.menuEditAdd.Click += new System.EventHandler(this.menuEditAdd_Click);
			// 
			// menuEditRemove
			// 
			this.flybyProvider.SetFlybyText(this.menuEditRemove, null);
			this.menuEditRemove.Name = "menuEditRemove";
			this.menuEditRemove.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
						| System.Windows.Forms.Keys.R)));
			this.menuEditRemove.Size = new System.Drawing.Size(193, 22);
			this.menuEditRemove.Text = "Remo&ve";
			this.menuEditRemove.Click += new System.EventHandler(this.menuEditRemove_Click);
			// 
			// menuView
			// 
			this.flybyProvider.SetFlybyText(this.menuView, null);
			this.menuView.Name = "menuView";
			this.menuView.Size = new System.Drawing.Size(41, 20);
			this.menuView.Text = "&View";
			// 
			// menuHelp
			// 
			this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
			this.flybyProvider.SetFlybyText(this.menuHelp, null);
			this.menuHelp.Name = "menuHelp";
			this.menuHelp.Size = new System.Drawing.Size(40, 20);
			this.menuHelp.Text = "&Help";
			// 
			// menuHelpAbout
			// 
			this.flybyProvider.SetFlybyText(this.menuHelpAbout, null);
			this.menuHelpAbout.Name = "menuHelpAbout";
			this.menuHelpAbout.Size = new System.Drawing.Size(126, 22);
			this.menuHelpAbout.Text = "&About...";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusInfo,
            this.statusImageSize,
            this.statusAlbumPos});
			this.statusStrip1.Location = new System.Drawing.Point(0, 244);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(292, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// statusInfo
			// 
			this.statusInfo.AutoSize = false;
			this.statusInfo.Name = "statusInfo";
			this.statusInfo.Size = new System.Drawing.Size(204, 17);
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
			// flybyProvider
			// 
			this.flybyProvider.StatusLabel = this.statusInfo;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.pbxPhoto);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.KeyPreview = true;
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
		private System.Windows.Forms.ToolStripMenuItem menuFile;
		private System.Windows.Forms.ToolStripMenuItem menuFileNew;
		private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripMenuItem menuFileSave;
		private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem menuFilePrint;
		private System.Windows.Forms.ToolStripMenuItem menuFilePrintPreview;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem menuFileExit;
		private System.Windows.Forms.ToolStripMenuItem menuEdit;
		private System.Windows.Forms.ToolStripMenuItem menuEditCut;
		private System.Windows.Forms.ToolStripMenuItem menuEditCopy;
		private System.Windows.Forms.ToolStripMenuItem menuEditPaste;
		private System.Windows.Forms.ToolStripMenuItem menuHelp;
		private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem menuNext;
		private System.Windows.Forms.ToolStripMenuItem menuPrevious;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem menuEditAdd;
		private System.Windows.Forms.ToolStripMenuItem menuEditRemove;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem menuPixelData;
		private System.Windows.Forms.ToolStripMenuItem menuPhotoProps;
		private System.Windows.Forms.ToolStripMenuItem menuAlbumProps;
		private Manning.MyPhotoControls.FlybyTextProvider flybyProvider;
	}
}

