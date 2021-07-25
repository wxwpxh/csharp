namespace Manning.MyPhotoControls
{
	partial class PhotoEditDialog
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
			this.tablePanel = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPhotoFile = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCaption = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDateTaken = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPhotographer = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.ctxMenuNotes = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuUndo = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.menuCut = new System.Windows.Forms.ToolStripMenuItem();
			this.menuPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.menuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			this.tablePanel.SuspendLayout();
			this.ctxMenuNotes.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tablePanel);
			// 
			// tablePanel
			// 
			this.tablePanel.ColumnCount = 2;
			this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
			this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
			this.tablePanel.Controls.Add(this.label1, 0, 0);
			this.tablePanel.Controls.Add(this.txtPhotoFile, 1, 0);
			this.tablePanel.Controls.Add(this.label2, 0, 1);
			this.tablePanel.Controls.Add(this.txtCaption, 1, 1);
			this.tablePanel.Controls.Add(this.label3, 0, 2);
			this.tablePanel.Controls.Add(this.txtDateTaken, 1, 2);
			this.tablePanel.Controls.Add(this.label4, 0, 3);
			this.tablePanel.Controls.Add(this.txtPhotographer, 1, 3);
			this.tablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tablePanel.Location = new System.Drawing.Point(0, 0);
			this.tablePanel.Name = "tablePanel";
			this.tablePanel.RowCount = 4;
			this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tablePanel.Size = new System.Drawing.Size(266, 98);
			this.tablePanel.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Photo &File:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPhotoFile
			// 
			this.txtPhotoFile.Location = new System.Drawing.Point(96, 3);
			this.txtPhotoFile.Name = "txtPhotoFile";
			this.txtPhotoFile.ReadOnly = true;
			this.txtPhotoFile.Size = new System.Drawing.Size(167, 20);
			this.txtPhotoFile.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Cap&tion:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCaption
			// 
			this.txtCaption.Location = new System.Drawing.Point(96, 27);
			this.txtCaption.Name = "txtCaption";
			this.txtCaption.Size = new System.Drawing.Size(167, 20);
			this.txtCaption.TabIndex = 3;
			this.txtCaption.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaption_KeyPress);
			this.txtCaption.TextChanged += new System.EventHandler(this.txtCaption_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 24);
			this.label3.TabIndex = 4;
			this.label3.Text = "&Date Taken:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDateTaken
			// 
			this.txtDateTaken.Location = new System.Drawing.Point(96, 51);
			this.txtDateTaken.Name = "txtDateTaken";
			this.txtDateTaken.Size = new System.Drawing.Size(167, 20);
			this.txtDateTaken.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(3, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 26);
			this.label4.TabIndex = 6;
			this.label4.Text = "&Photographer:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPhotographer
			// 
			this.txtPhotographer.Location = new System.Drawing.Point(96, 75);
			this.txtPhotographer.Name = "txtPhotographer";
			this.txtPhotographer.Size = new System.Drawing.Size(167, 20);
			this.txtPhotographer.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 115);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "&Notes:";
			// 
			// txtNotes
			// 
			this.txtNotes.AcceptsReturn = true;
			this.txtNotes.ContextMenuStrip = this.ctxMenuNotes;
			this.txtNotes.Location = new System.Drawing.Point(12, 131);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtNotes.Size = new System.Drawing.Size(268, 94);
			this.txtNotes.TabIndex = 5;
			// 
			// ctxMenuNotes
			// 
			this.ctxMenuNotes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUndo,
            this.toolStripMenuItem1,
            this.menuCopy,
            this.menuCut,
            this.menuPaste,
            this.menuDelete,
            this.toolStripMenuItem2,
            this.menuSelectAll});
			this.ctxMenuNotes.Name = "ctxMenuNotes";
			this.ctxMenuNotes.Size = new System.Drawing.Size(129, 148);
			this.ctxMenuNotes.Opened += new System.EventHandler(this.ctxMenuNotes_Opened);
			// 
			// menuUndo
			// 
			this.menuUndo.Name = "menuUndo";
			this.menuUndo.Size = new System.Drawing.Size(128, 22);
			this.menuUndo.Text = "&Undo";
			this.menuUndo.Click += new System.EventHandler(this.menuUndo_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 6);
			// 
			// menuCopy
			// 
			this.menuCopy.Name = "menuCopy";
			this.menuCopy.Size = new System.Drawing.Size(128, 22);
			this.menuCopy.Text = "&Copy";
			this.menuCopy.Click += new System.EventHandler(this.menuCopy_Click);
			// 
			// menuCut
			// 
			this.menuCut.Name = "menuCut";
			this.menuCut.Size = new System.Drawing.Size(128, 22);
			this.menuCut.Text = "Cu&t";
			this.menuCut.Click += new System.EventHandler(this.menuCut_Click);
			// 
			// menuPaste
			// 
			this.menuPaste.Name = "menuPaste";
			this.menuPaste.Size = new System.Drawing.Size(128, 22);
			this.menuPaste.Text = "&Paste";
			this.menuPaste.Click += new System.EventHandler(this.menuPaste_Click);
			// 
			// menuDelete
			// 
			this.menuDelete.Name = "menuDelete";
			this.menuDelete.Size = new System.Drawing.Size(128, 22);
			this.menuDelete.Text = "&Delete";
			this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(125, 6);
			// 
			// menuSelectAll
			// 
			this.menuSelectAll.Name = "menuSelectAll";
			this.menuSelectAll.Size = new System.Drawing.Size(128, 22);
			this.menuSelectAll.Text = "Select &All";
			this.menuSelectAll.Click += new System.EventHandler(this.menuSelectAll_Click);
			// 
			// PhotoEditDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtNotes);
			this.Name = "PhotoEditDialog";
			this.Text = "Photo Properties";
			this.Controls.SetChildIndex(this.txtNotes, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.panel1.ResumeLayout(false);
			this.tablePanel.ResumeLayout(false);
			this.tablePanel.PerformLayout();
			this.ctxMenuNotes.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tablePanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPhotoFile;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCaption;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDateTaken;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPhotographer;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.ContextMenuStrip ctxMenuNotes;
		private System.Windows.Forms.ToolStripMenuItem menuUndo;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem menuCopy;
		private System.Windows.Forms.ToolStripMenuItem menuCut;
		private System.Windows.Forms.ToolStripMenuItem menuPaste;
		private System.Windows.Forms.ToolStripMenuItem menuDelete;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem menuSelectAll;
	}
}
