using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace Manning.MyPhotoAlbum
{
	public class PhotoEditDlg : Manning.MyPhotoAlbum.BaseEditDlg
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPhotoFile;
		private System.Windows.Forms.TextBox txtCaption;
		private System.Windows.Forms.TextBox txtDate;
		private System.Windows.Forms.TextBox txtPhotographer;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.ContextMenu ctxtMenuNotes;
		private System.Windows.Forms.MenuItem menuUndo;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuCut;
		private System.Windows.Forms.MenuItem menuCopy;
		private System.Windows.Forms.MenuItem menuPaste;
		private System.Windows.Forms.MenuItem menuDelete;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuSelectAll;
		private System.Windows.Forms.MenuItem menuClear;
		private System.ComponentModel.IContainer components = null;

		public PhotoEditDlg(PhotoAlbum album)
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// Initialize the dialog settings
			_album = album;
			ResetSettings();
		}

		private PhotoAlbum _album;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPhotoFile = new System.Windows.Forms.TextBox();
			this.txtCaption = new System.Windows.Forms.TextBox();
			this.txtDate = new System.Windows.Forms.TextBox();
			this.txtPhotographer = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.ctxtMenuNotes = new System.Windows.Forms.ContextMenu();
			this.menuUndo = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuCut = new System.Windows.Forms.MenuItem();
			this.menuCopy = new System.Windows.Forms.MenuItem();
			this.menuPaste = new System.Windows.Forms.MenuItem();
			this.menuDelete = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuSelectAll = new System.Windows.Forms.MenuItem();
			this.menuClear = new System.Windows.Forms.MenuItem();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.txtPhotographer,
																				 this.txtDate,
																				 this.txtCaption,
																				 this.txtPhotoFile,
																				 this.label4,
																				 this.label3,
																				 this.label2,
																				 this.label1});
			this.panel1.Visible = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Photo &File:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 14);
			this.label2.TabIndex = 2;
			this.label2.Text = "Cap&tion:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "&Date Taken:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 103);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 18);
			this.label4.TabIndex = 6;
			this.label4.Text = "&Photographer:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPhotoFile
			// 
			this.txtPhotoFile.Location = new System.Drawing.Point(104, 6);
			this.txtPhotoFile.Name = "txtPhotoFile";
			this.txtPhotoFile.ReadOnly = true;
			this.txtPhotoFile.Size = new System.Drawing.Size(160, 20);
			this.txtPhotoFile.TabIndex = 1;
			this.txtPhotoFile.Text = "";
			// 
			// txtCaption
			// 
			this.txtCaption.Location = new System.Drawing.Point(104, 36);
			this.txtCaption.Name = "txtCaption";
			this.txtCaption.Size = new System.Drawing.Size(160, 20);
			this.txtCaption.TabIndex = 3;
			this.txtCaption.Text = "";
			this.txtCaption.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaption_KeyPress);
			this.txtCaption.TextChanged += new System.EventHandler(this.txtCaption_TextChanged);
			// 
			// txtDate
			// 
			this.txtDate.Location = new System.Drawing.Point(104, 68);
			this.txtDate.Name = "txtDate";
			this.txtDate.Size = new System.Drawing.Size(160, 20);
			this.txtDate.TabIndex = 5;
			this.txtDate.Text = "";
			// 
			// txtPhotographer
			// 
			this.txtPhotographer.Location = new System.Drawing.Point(104, 102);
			this.txtPhotographer.Name = "txtPhotographer";
			this.txtPhotographer.Size = new System.Drawing.Size(160, 20);
			this.txtPhotographer.TabIndex = 7;
			this.txtPhotographer.Text = "";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 160);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "&Notes:";
			// 
			// txtNotes
			// 
			this.txtNotes.AcceptsReturn = true;
			this.txtNotes.ContextMenu = this.ctxtMenuNotes;
			this.txtNotes.Location = new System.Drawing.Point(16, 176);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtNotes.Size = new System.Drawing.Size(264, 72);
			this.txtNotes.TabIndex = 5;
			this.txtNotes.Text = "";
			// 
			// ctxtMenuNotes
			// 
			this.ctxtMenuNotes.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						  this.menuUndo,
																						  this.menuItem2,
																						  this.menuCut,
																						  this.menuCopy,
																						  this.menuPaste,
																						  this.menuDelete,
																						  this.menuItem7,
																						  this.menuSelectAll,
																						  this.menuClear});
			this.ctxtMenuNotes.Popup += new System.EventHandler(this.ctxtMenuNotes_Popup);
			// 
			// menuUndo
			// 
			this.menuUndo.Index = 0;
			this.menuUndo.Text = "&Undo";
			this.menuUndo.Click += new System.EventHandler(this.menuUndo_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.Text = "-";
			// 
			// menuCut
			// 
			this.menuCut.Index = 2;
			this.menuCut.Text = "Cu&t";
			this.menuCut.Click += new System.EventHandler(this.menuCut_Click);
			// 
			// menuCopy
			// 
			this.menuCopy.Index = 3;
			this.menuCopy.Text = "&Copy";
			this.menuCopy.Click += new System.EventHandler(this.menuCopy_Click);
			// 
			// menuPaste
			// 
			this.menuPaste.Index = 4;
			this.menuPaste.Text = "&Paste";
			this.menuPaste.Click += new System.EventHandler(this.menuPaste_Click);
			// 
			// menuDelete
			// 
			this.menuDelete.Index = 5;
			this.menuDelete.Text = "&Delete";
			this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 6;
			this.menuItem7.Text = "-";
			// 
			// menuSelectAll
			// 
			this.menuSelectAll.Index = 7;
			this.menuSelectAll.Text = "Select &All";
			this.menuSelectAll.Click += new System.EventHandler(this.menuSelectAll_Click);
			// 
			// menuClear
			// 
			this.menuClear.Index = 8;
			this.menuClear.Text = "Clea&r";
			this.menuClear.Click += new System.EventHandler(this.menuClear_Click);
			// 
			// PhotoEditDlg
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(296, 297);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel1,
																		  this.txtNotes,
																		  this.label5});
			this.Name = "PhotoEditDlg";
			this.Text = "Photo Properties";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		protected override void ResetSettings()
		{
			Photograph photo = _album.CurrentPhoto;

			if (photo != null)
			{
				txtPhotoFile.Text = photo.FileName;
				txtCaption.Text = photo.Caption;
				txtDate.Text = photo.DateTaken.ToString();
				txtPhotographer.Text = photo.Photographer;
				this.txtNotes.Text = photo.Notes;
			}
		}
		protected override bool SaveSettings()
		{
			Photograph photo = _album.CurrentPhoto;

			if (photo != null)
			{
				photo.Caption = txtCaption.Text;
				// Ignore txtDate setting for now
				photo.Photographer = txtPhotographer.Text;
				photo.Notes = txtNotes.Text;
			}

			return true;
		}

		private void txtCaption_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			char c = e.KeyChar;

			e.Handled = !(Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c) || Char.IsControl(c));
		}

		private void txtCaption_TextChanged(object sender, System.EventArgs e)
		{		
			this.Text = String.Format("{0} - Photo Properties", txtCaption.Text);
		}

		private void ctxtMenuNotes_Popup(object sender, System.EventArgs e)
		{
			// Make sure this control has the focus
			txtNotes.Focus();

			// Enable the controls as appropriate
			menuUndo.Enabled = txtNotes.CanUndo;
			
			bool selected = (txtNotes.SelectedText.Length > 0);
			menuCut.Enabled = selected;
			menuCopy.Enabled = selected;

			object obj = Clipboard.GetDataObject().GetData(DataFormats.Text);
			menuPaste.Enabled = (obj != null);

			menuDelete.Enabled = selected;
			menuSelectAll.Enabled = (txtNotes.SelectionLength < txtNotes.TextLength);

			menuClear.Enabled = (txtNotes.TextLength > 0);
		}

		private void menuUndo_Click(object sender, System.EventArgs e)
		{
			if (txtNotes.CanUndo)
				txtNotes.Undo();
		}

		private void menuCut_Click(object sender, System.EventArgs e)
		{
			txtNotes.Cut();
		}

		private void menuCopy_Click(object sender, System.EventArgs e)
		{
			txtNotes.Copy();
		}

		private void menuPaste_Click(object sender, System.EventArgs e)
		{
			txtNotes.Paste();
		}

		private void menuDelete_Click(object sender, System.EventArgs e)
		{
			string oldText = txtNotes.Text;
			txtNotes.Text = oldText.Remove(txtNotes.SelectionStart, txtNotes.SelectionLength);
		}

		private void menuSelectAll_Click(object sender, System.EventArgs e)
		{
			txtNotes.SelectAll();
		}

		private void menuClear_Click(object sender, System.EventArgs e)
		{
			txtNotes.Clear();
		}

		// end of PhotoEditDlg
	}
}

