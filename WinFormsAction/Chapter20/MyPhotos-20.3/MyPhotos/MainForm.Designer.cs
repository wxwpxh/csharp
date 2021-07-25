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
			this.menuSlideShow = new System.Windows.Forms.ToolStripMenuItem();
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
			this.pbxPhoto = new System.Windows.Forms.PictureBox();
			this.toolStripMain = new System.Windows.Forms.ToolStrip();
			this.tsbNew = new System.Windows.Forms.ToolStripButton();
			this.tsbOpen = new System.Windows.Forms.ToolStripButton();
			this.tsbSave = new System.Windows.Forms.ToolStripButton();
			this.tsbPrint = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbCut = new System.Windows.Forms.ToolStripButton();
			this.tsbCopy = new System.Windows.Forms.ToolStripButton();
			this.tsbPaste = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbPrevious = new System.Windows.Forms.ToolStripButton();
			this.tsbNext = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbHelp = new System.Windows.Forms.ToolStripButton();
			this.imageListArrows = new System.Windows.Forms.ImageList(this.components);
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.toolStripDialogs = new System.Windows.Forms.ToolStrip();
			this.tsbAlbumProps = new System.Windows.Forms.ToolStripButton();
			this.tsbPhotoProps = new System.Windows.Forms.ToolStripButton();
			this.tsbPixelData = new System.Windows.Forms.ToolStripButton();
			this.tsbPixelData2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripImages = new System.Windows.Forms.ToolStrip();
			this.tsdImage = new System.Windows.Forms.ToolStripDropDownButton();
			this.tssSelect = new System.Windows.Forms.ToolStripSplitButton();
			this.flybyProvider = new Manning.MyPhotoControls.FlybyTextProvider(this.components);
			this.ctxMenuPhoto.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
			this.toolStripMain.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.toolStripDialogs.SuspendLayout();
			this.toolStripImages.SuspendLayout();
			this.SuspendLayout();
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
            this.menuAlbumProps,
            this.menuSlideShow});
			this.ctxMenuPhoto.Name = "ctxMenuPhoto";
			this.ctxMenuPhoto.Size = new System.Drawing.Size(195, 170);
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
			// menuSlideShow
			// 
			this.flybyProvider.SetFlybyText(this.menuSlideShow, null);
			this.menuSlideShow.Name = "menuSlideShow";
			this.menuSlideShow.Size = new System.Drawing.Size(194, 22);
			this.menuSlideShow.Text = "&Slide Show...";
			this.menuSlideShow.Click += new System.EventHandler(this.menuSlideShow_Click);
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
			this.menuFile.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new System.Drawing.Size(35, 20);
			this.menuFile.Text = "&File";
			// 
			// menuFileNew
			// 
			this.flybyProvider.SetFlybyText(this.menuFileNew, null);
			this.menuFileNew.Image = ((System.Drawing.Image)(resources.GetObject("menuFileNew.Image")));
			this.menuFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.menuFileNew.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
			this.menuFileNew.MergeIndex = 0;
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
			this.menuFileOpen.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
			this.menuFileOpen.MergeIndex = 1;
			this.menuFileOpen.Name = "menuFileOpen";
			this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.menuFileOpen.Size = new System.Drawing.Size(151, 22);
			this.menuFileOpen.Text = "&Open";
			this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.MergeAction = System.Windows.Forms.MergeAction.Replace;
			this.toolStripSeparator.MergeIndex = 3;
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(148, 6);
			// 
			// menuFileSave
			// 
			this.flybyProvider.SetFlybyText(this.menuFileSave, null);
			this.menuFileSave.Image = ((System.Drawing.Image)(resources.GetObject("menuFileSave.Image")));
			this.menuFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.menuFileSave.MergeAction = System.Windows.Forms.MergeAction.Insert;
			this.menuFileSave.MergeIndex = 4;
			this.menuFileSave.Name = "menuFileSave";
			this.menuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.menuFileSave.Size = new System.Drawing.Size(151, 22);
			this.menuFileSave.Text = "&Save";
			this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
			// 
			// menuFileSaveAs
			// 
			this.flybyProvider.SetFlybyText(this.menuFileSaveAs, null);
			this.menuFileSaveAs.MergeAction = System.Windows.Forms.MergeAction.Insert;
			this.menuFileSaveAs.MergeIndex = 5;
			this.menuFileSaveAs.Name = "menuFileSaveAs";
			this.menuFileSaveAs.Size = new System.Drawing.Size(151, 22);
			this.menuFileSaveAs.Text = "Save &As";
			this.menuFileSaveAs.Click += new System.EventHandler(this.menuFileSaveAs_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert;
			this.toolStripSeparator1.MergeIndex = 6;
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
			// 
			// menuFilePrint
			// 
			this.flybyProvider.SetFlybyText(this.menuFilePrint, null);
			this.menuFilePrint.Image = ((System.Drawing.Image)(resources.GetObject("menuFilePrint.Image")));
			this.menuFilePrint.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.menuFilePrint.MergeAction = System.Windows.Forms.MergeAction.Insert;
			this.menuFilePrint.MergeIndex = 7;
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
			this.menuFilePrintPreview.MergeAction = System.Windows.Forms.MergeAction.Insert;
			this.menuFilePrintPreview.MergeIndex = 8;
			this.menuFilePrintPreview.Name = "menuFilePrintPreview";
			this.menuFilePrintPreview.Size = new System.Drawing.Size(151, 22);
			this.menuFilePrintPreview.Text = "Print Pre&view";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.MergeAction = System.Windows.Forms.MergeAction.Insert;
			this.toolStripSeparator2.MergeIndex = 9;
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(148, 6);
			// 
			// menuFileExit
			// 
			this.flybyProvider.SetFlybyText(this.menuFileExit, null);
			this.menuFileExit.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
			this.menuFileExit.MergeIndex = 10;
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
			// pbxPhoto
			// 
			this.pbxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbxPhoto.ContextMenuStrip = this.ctxMenuPhoto;
			this.pbxPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbxPhoto.Location = new System.Drawing.Point(0, 0);
			this.pbxPhoto.Name = "pbxPhoto";
			this.pbxPhoto.Size = new System.Drawing.Size(292, 170);
			this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxPhoto.TabIndex = 1;
			this.pbxPhoto.TabStop = false;
			this.pbxPhoto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxPhoto_MouseMove);
			// 
			// toolStripMain
			// 
			this.toolStripMain.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbOpen,
            this.tsbSave,
            this.tsbPrint,
            this.toolStripSeparator3,
            this.tsbCut,
            this.tsbCopy,
            this.tsbPaste,
            this.toolStripSeparator4,
            this.tsbPrevious,
            this.tsbNext,
            this.toolStripSeparator5,
            this.tsbHelp});
			this.toolStripMain.Location = new System.Drawing.Point(3, 0);
			this.toolStripMain.Name = "toolStripMain";
			this.toolStripMain.Size = new System.Drawing.Size(289, 25);
			this.toolStripMain.TabIndex = 4;
			this.toolStripMain.Text = "toolStrip1";
			// 
			// tsbNew
			// 
			this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
			this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbNew.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
			this.tsbNew.MergeIndex = 0;
			this.tsbNew.Name = "tsbNew";
			this.tsbNew.Size = new System.Drawing.Size(23, 22);
			this.tsbNew.Text = "&New";
			this.tsbNew.Click += new System.EventHandler(this.tbs_Click);
			// 
			// tsbOpen
			// 
			this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
			this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbOpen.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
			this.tsbOpen.MergeIndex = 1;
			this.tsbOpen.Name = "tsbOpen";
			this.tsbOpen.Size = new System.Drawing.Size(23, 22);
			this.tsbOpen.Text = "&Open";
			this.tsbOpen.Click += new System.EventHandler(this.tbs_Click);
			// 
			// tsbSave
			// 
			this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
			this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbSave.Name = "tsbSave";
			this.tsbSave.Size = new System.Drawing.Size(23, 22);
			this.tsbSave.Text = "&Save";
			this.tsbSave.Click += new System.EventHandler(this.tbs_Click);
			// 
			// tsbPrint
			// 
			this.tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
			this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPrint.Name = "tsbPrint";
			this.tsbPrint.Size = new System.Drawing.Size(23, 22);
			this.tsbPrint.Text = "&Print";
			this.tsbPrint.Click += new System.EventHandler(this.tbs_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbCut
			// 
			this.tsbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbCut.Image = ((System.Drawing.Image)(resources.GetObject("tsbCut.Image")));
			this.tsbCut.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbCut.Name = "tsbCut";
			this.tsbCut.Size = new System.Drawing.Size(23, 22);
			this.tsbCut.Text = "C&ut";
			this.tsbCut.Click += new System.EventHandler(this.tbs_Click);
			// 
			// tsbCopy
			// 
			this.tsbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbCopy.Image = ((System.Drawing.Image)(resources.GetObject("tsbCopy.Image")));
			this.tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbCopy.Name = "tsbCopy";
			this.tsbCopy.Size = new System.Drawing.Size(23, 22);
			this.tsbCopy.Text = "&Copy";
			this.tsbCopy.Click += new System.EventHandler(this.tbs_Click);
			// 
			// tsbPaste
			// 
			this.tsbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPaste.Image = ((System.Drawing.Image)(resources.GetObject("tsbPaste.Image")));
			this.tsbPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPaste.Name = "tsbPaste";
			this.tsbPaste.Size = new System.Drawing.Size(23, 22);
			this.tsbPaste.Text = "&Paste";
			this.tsbPaste.Click += new System.EventHandler(this.tbs_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbPrevious
			// 
			this.tsbPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPrevious.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrevious.Image")));
			this.tsbPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPrevious.Name = "tsbPrevious";
			this.tsbPrevious.Size = new System.Drawing.Size(23, 22);
			this.tsbPrevious.Text = "Previous";
			this.tsbPrevious.Click += new System.EventHandler(this.tbs_Click);
			// 
			// tsbNext
			// 
			this.tsbNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbNext.Image = ((System.Drawing.Image)(resources.GetObject("tsbNext.Image")));
			this.tsbNext.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbNext.Name = "tsbNext";
			this.tsbNext.Size = new System.Drawing.Size(23, 22);
			this.tsbNext.Text = "Next";
			this.tsbNext.Click += new System.EventHandler(this.tbs_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbHelp
			// 
			this.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsbHelp.Image")));
			this.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbHelp.Name = "tsbHelp";
			this.tsbHelp.Size = new System.Drawing.Size(23, 22);
			this.tsbHelp.Text = "He&lp";
			this.tsbHelp.Click += new System.EventHandler(this.tbs_Click);
			// 
			// imageListArrows
			// 
			this.imageListArrows.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListArrows.ImageStream")));
			this.imageListArrows.TransparentColor = System.Drawing.Color.Fuchsia;
			this.imageListArrows.Images.SetKeyName(0, "RightArrow.bmp");
			this.imageListArrows.Images.SetKeyName(1, "LeftArrow.bmp");
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.pbxPhoto);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(292, 170);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(292, 220);
			this.toolStripContainer1.TabIndex = 5;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripMain);
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripImages);
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripDialogs);
			// 
			// toolStripDialogs
			// 
			this.toolStripDialogs.AllowMerge = false;
			this.toolStripDialogs.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStripDialogs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAlbumProps,
            this.tsbPhotoProps,
            this.tsbPixelData,
            this.tsbPixelData2});
			this.toolStripDialogs.Location = new System.Drawing.Point(117, 25);
			this.toolStripDialogs.Name = "toolStripDialogs";
			this.toolStripDialogs.Size = new System.Drawing.Size(81, 25);
			this.toolStripDialogs.TabIndex = 5;
			// 
			// tsbAlbumProps
			// 
			this.tsbAlbumProps.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbAlbumProps.Image = ((System.Drawing.Image)(resources.GetObject("tsbAlbumProps.Image")));
			this.tsbAlbumProps.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAlbumProps.Name = "tsbAlbumProps";
			this.tsbAlbumProps.Size = new System.Drawing.Size(23, 22);
			this.tsbAlbumProps.Text = "toolStripButton1";
			this.tsbAlbumProps.ToolTipText = "Album Properties";
			this.tsbAlbumProps.Click += new System.EventHandler(this.tbs_Click);
			// 
			// tsbPhotoProps
			// 
			this.tsbPhotoProps.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPhotoProps.Image = ((System.Drawing.Image)(resources.GetObject("tsbPhotoProps.Image")));
			this.tsbPhotoProps.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPhotoProps.Name = "tsbPhotoProps";
			this.tsbPhotoProps.Size = new System.Drawing.Size(23, 22);
			this.tsbPhotoProps.Text = "toolStripButton2";
			this.tsbPhotoProps.ToolTipText = "Photo Properties";
			this.tsbPhotoProps.Click += new System.EventHandler(this.tbs_Click);
			// 
			// tsbPixelData
			// 
			this.tsbPixelData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPixelData.Image = ((System.Drawing.Image)(resources.GetObject("tsbPixelData.Image")));
			this.tsbPixelData.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPixelData.Name = "tsbPixelData";
			this.tsbPixelData.Size = new System.Drawing.Size(23, 22);
			this.tsbPixelData.Text = "toolStripButton3";
			this.tsbPixelData.ToolTipText = "Pixel Data";
			this.tsbPixelData.Click += new System.EventHandler(this.tsbPixelData_Click);
			// 
			// tsbPixelData2
			// 
			this.tsbPixelData2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbPixelData2.Image = ((System.Drawing.Image)(resources.GetObject("tsbPixelData2.Image")));
			this.tsbPixelData2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPixelData2.Name = "tsbPixelData2";
			this.tsbPixelData2.Size = new System.Drawing.Size(23, 22);
			this.tsbPixelData2.Text = "toolStripButton4";
			this.tsbPixelData2.Visible = false;
			// 
			// toolStripImages
			// 
			this.toolStripImages.AllowMerge = false;
			this.toolStripImages.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStripImages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsdImage,
            this.tssSelect});
			this.toolStripImages.Location = new System.Drawing.Point(3, 25);
			this.toolStripImages.Name = "toolStripImages";
			this.toolStripImages.Size = new System.Drawing.Size(114, 25);
			this.toolStripImages.TabIndex = 6;
			// 
			// tsdImage
			// 
			this.tsdImage.AutoToolTip = false;
			this.tsdImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsdImage.Image = ((System.Drawing.Image)(resources.GetObject("tsdImage.Image")));
			this.tsdImage.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsdImage.Name = "tsdImage";
			this.tsdImage.Size = new System.Drawing.Size(50, 22);
			this.tsdImage.Text = "&Image";
			this.tsdImage.DropDownOpening += new System.EventHandler(this.menuImage_DropDownOpening);
			this.tsdImage.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuImage_DropDownItemClicked);
			// 
			// tssSelect
			// 
			this.tssSelect.AutoToolTip = false;
			this.tssSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tssSelect.Image = ((System.Drawing.Image)(resources.GetObject("tssSelect.Image")));
			this.tssSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tssSelect.Name = "tssSelect";
			this.tssSelect.Size = new System.Drawing.Size(52, 22);
			this.tssSelect.Text = "&Select";
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
			this.Controls.Add(this.toolStripContainer1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "MyPhotos";
			this.ctxMenuPhoto.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
			this.toolStripMain.ResumeLayout(false);
			this.toolStripMain.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.toolStripDialogs.ResumeLayout(false);
			this.toolStripDialogs.PerformLayout();
			this.toolStripImages.ResumeLayout(false);
			this.toolStripImages.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pbxPhoto;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ContextMenuStrip ctxMenuPhoto;
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
		private System.Windows.Forms.ToolStripMenuItem menuSlideShow;
		private System.Windows.Forms.ToolStrip toolStripMain;
		private System.Windows.Forms.ToolStripButton tsbNew;
		private System.Windows.Forms.ToolStripButton tsbOpen;
		private System.Windows.Forms.ToolStripButton tsbSave;
		private System.Windows.Forms.ToolStripButton tsbPrint;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton tsbCut;
		private System.Windows.Forms.ToolStripButton tsbCopy;
		private System.Windows.Forms.ToolStripButton tsbPaste;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton tsbHelp;
		private System.Windows.Forms.ImageList imageListArrows;
		private System.Windows.Forms.ToolStripButton tsbPrevious;
		private System.Windows.Forms.ToolStripButton tsbNext;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.ToolStrip toolStripDialogs;
		private System.Windows.Forms.ToolStripButton tsbAlbumProps;
		private System.Windows.Forms.ToolStripButton tsbPhotoProps;
		private System.Windows.Forms.ToolStripButton tsbPixelData;
		private System.Windows.Forms.ToolStripButton tsbPixelData2;
		private System.Windows.Forms.ToolStrip toolStripImages;
		private System.Windows.Forms.ToolStripDropDownButton tsdImage;
		private System.Windows.Forms.ToolStripSplitButton tssSelect;
		private System.Windows.Forms.ToolStripMenuItem menuImage;
		private System.Windows.Forms.ToolStripMenuItem menuImageScale;
		private System.Windows.Forms.ToolStripMenuItem menuImageStretch;
		private System.Windows.Forms.ToolStripMenuItem menuImageActual;
	}
}

