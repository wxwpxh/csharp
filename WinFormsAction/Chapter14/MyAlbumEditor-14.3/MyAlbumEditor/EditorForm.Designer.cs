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
			this.btnBrowse = new System.Windows.Forms.Button();
			this.comboAlbums = new System.Windows.Forms.ComboBox();
			this.btnAlbumProps = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.tcPhotos = new System.Windows.Forms.TabControl();
			this.pagePhotos = new System.Windows.Forms.TabPage();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnMoveDown = new System.Windows.Forms.Button();
			this.btnMoveUp = new System.Windows.Forms.Button();
			this.btnPhotoProps = new System.Windows.Forms.Button();
			this.lstPhotos = new System.Windows.Forms.ListBox();
			this.pageDates = new System.Windows.Forms.TabPage();
			this.albumCalendar = new MyAlbumEditor.AlbumCalendar();
			this.grpAlbums.SuspendLayout();
			this.tcPhotos.SuspendLayout();
			this.pagePhotos.SuspendLayout();
			this.pageDates.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpAlbums
			// 
			this.grpAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpAlbums.Controls.Add(this.btnBrowse);
			this.grpAlbums.Controls.Add(this.comboAlbums);
			this.grpAlbums.Controls.Add(this.btnAlbumProps);
			this.grpAlbums.Location = new System.Drawing.Point(12, 12);
			this.grpAlbums.Name = "grpAlbums";
			this.grpAlbums.Size = new System.Drawing.Size(381, 50);
			this.grpAlbums.TabIndex = 0;
			this.grpAlbums.TabStop = false;
			this.grpAlbums.Text = "&Albums";
			// 
			// btnBrowse
			// 
			this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse.Location = new System.Drawing.Point(219, 14);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 3;
			this.btnBrowse.Text = "&Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// comboAlbums
			// 
			this.comboAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.comboAlbums.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboAlbums.DropDownWidth = 400;
			this.comboAlbums.FormattingEnabled = true;
			this.comboAlbums.Location = new System.Drawing.Point(6, 16);
			this.comboAlbums.Name = "comboAlbums";
			this.comboAlbums.Size = new System.Drawing.Size(207, 21);
			this.comboAlbums.TabIndex = 2;
			this.comboAlbums.SelectionChangeCommitted += new System.EventHandler(this.comboAlbums_SelectionChangeCommitted);
			// 
			// btnAlbumProps
			// 
			this.btnAlbumProps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAlbumProps.Enabled = false;
			this.btnAlbumProps.Location = new System.Drawing.Point(300, 14);
			this.btnAlbumProps.Name = "btnAlbumProps";
			this.btnAlbumProps.Size = new System.Drawing.Size(75, 23);
			this.btnAlbumProps.TabIndex = 1;
			this.btnAlbumProps.Text = "Propertie&s";
			this.btnAlbumProps.UseVisualStyleBackColor = true;
			this.btnAlbumProps.Click += new System.EventHandler(this.btnAlbumProps_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnClose.Location = new System.Drawing.Point(161, 274);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "&Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// tcPhotos
			// 
			this.tcPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tcPhotos.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tcPhotos.Controls.Add(this.pagePhotos);
			this.tcPhotos.Controls.Add(this.pageDates);
			this.tcPhotos.Location = new System.Drawing.Point(12, 68);
			this.tcPhotos.Name = "tcPhotos";
			this.tcPhotos.SelectedIndex = 0;
			this.tcPhotos.Size = new System.Drawing.Size(381, 200);
			this.tcPhotos.TabIndex = 2;
			this.tcPhotos.SelectedIndexChanged += new System.EventHandler(this.tcPhotos_SelectedIndexChanged);
			// 
			// pagePhotos
			// 
			this.pagePhotos.Controls.Add(this.btnRemove);
			this.pagePhotos.Controls.Add(this.btnMoveDown);
			this.pagePhotos.Controls.Add(this.btnMoveUp);
			this.pagePhotos.Controls.Add(this.btnPhotoProps);
			this.pagePhotos.Controls.Add(this.lstPhotos);
			this.pagePhotos.Location = new System.Drawing.Point(4, 25);
			this.pagePhotos.Name = "pagePhotos";
			this.pagePhotos.Padding = new System.Windows.Forms.Padding(3);
			this.pagePhotos.Size = new System.Drawing.Size(373, 171);
			this.pagePhotos.TabIndex = 0;
			this.pagePhotos.Text = "Photos";
			this.pagePhotos.UseVisualStyleBackColor = true;
			// 
			// btnRemove
			// 
			this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRemove.Location = new System.Drawing.Point(296, 69);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(75, 23);
			this.btnRemove.TabIndex = 10;
			this.btnRemove.Text = "&Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnMoveDown
			// 
			this.btnMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMoveDown.Location = new System.Drawing.Point(296, 37);
			this.btnMoveDown.Name = "btnMoveDown";
			this.btnMoveDown.Size = new System.Drawing.Size(75, 23);
			this.btnMoveDown.TabIndex = 9;
			this.btnMoveDown.Text = "Move &Down";
			this.btnMoveDown.UseVisualStyleBackColor = true;
			this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
			// 
			// btnMoveUp
			// 
			this.btnMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMoveUp.Location = new System.Drawing.Point(296, 5);
			this.btnMoveUp.Name = "btnMoveUp";
			this.btnMoveUp.Size = new System.Drawing.Size(75, 23);
			this.btnMoveUp.TabIndex = 8;
			this.btnMoveUp.Text = "Move &Up";
			this.btnMoveUp.UseVisualStyleBackColor = true;
			this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
			// 
			// btnPhotoProps
			// 
			this.btnPhotoProps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPhotoProps.Location = new System.Drawing.Point(296, 101);
			this.btnPhotoProps.Name = "btnPhotoProps";
			this.btnPhotoProps.Size = new System.Drawing.Size(75, 23);
			this.btnPhotoProps.TabIndex = 7;
			this.btnPhotoProps.Text = "Properti&es";
			this.btnPhotoProps.UseVisualStyleBackColor = true;
			this.btnPhotoProps.Click += new System.EventHandler(this.btnPhotoProps_Click);
			// 
			// lstPhotos
			// 
			this.lstPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lstPhotos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.lstPhotos.FormattingEnabled = true;
			this.lstPhotos.HorizontalScrollbar = true;
			this.lstPhotos.Location = new System.Drawing.Point(2, 5);
			this.lstPhotos.Name = "lstPhotos";
			this.lstPhotos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstPhotos.Size = new System.Drawing.Size(288, 164);
			this.lstPhotos.TabIndex = 6;
			this.lstPhotos.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstPhotos_DrawItem);
			this.lstPhotos.DoubleClick += new System.EventHandler(this.lstPhotos_DoubleClick);
			this.lstPhotos.SelectedIndexChanged += new System.EventHandler(this.lstPhotos_SelectedIndexChanged);
			this.lstPhotos.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lstPhotos_MeasureItem);
			// 
			// pageDates
			// 
			this.pageDates.Controls.Add(this.albumCalendar);
			this.pageDates.Location = new System.Drawing.Point(4, 25);
			this.pageDates.Name = "pageDates";
			this.pageDates.Padding = new System.Windows.Forms.Padding(3);
			this.pageDates.Size = new System.Drawing.Size(373, 171);
			this.pageDates.TabIndex = 1;
			this.pageDates.Text = "Dates";
			this.pageDates.UseVisualStyleBackColor = true;
			// 
			// albumCalendar
			// 
			this.albumCalendar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.albumCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.albumCalendar.Location = new System.Drawing.Point(3, 3);
			this.albumCalendar.Manager = null;
			this.albumCalendar.Name = "albumCalendar";
			this.albumCalendar.Size = new System.Drawing.Size(367, 165);
			this.albumCalendar.TabIndex = 0;
			// 
			// EditorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(405, 309);
			this.Controls.Add(this.tcPhotos);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.grpAlbums);
			this.Name = "EditorForm";
			this.Text = "MyAlbumEditor";
			this.grpAlbums.ResumeLayout(false);
			this.tcPhotos.ResumeLayout(false);
			this.pagePhotos.ResumeLayout(false);
			this.pageDates.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpAlbums;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnAlbumProps;
		private System.Windows.Forms.ComboBox comboAlbums;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.TabControl tcPhotos;
		private System.Windows.Forms.TabPage pagePhotos;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnMoveDown;
		private System.Windows.Forms.Button btnMoveUp;
		private System.Windows.Forms.Button btnPhotoProps;
		private System.Windows.Forms.ListBox lstPhotos;
		private System.Windows.Forms.TabPage pageDates;
		private AlbumCalendar albumCalendar;
	}
}

