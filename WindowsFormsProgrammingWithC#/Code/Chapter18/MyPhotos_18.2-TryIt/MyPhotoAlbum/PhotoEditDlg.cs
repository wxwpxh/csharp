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
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.ComboBox cmbxPhotographer;
		private System.Windows.Forms.DateTimePicker dtpDateTaken;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnPrev;
		private System.Windows.Forms.ToolTip toolTipPhotos;
		private System.ComponentModel.IContainer components = null;

		public PhotoEditDlg(PhotoAlbum album)
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// Initialize the dialog settings
			_album = album;
			_index = album.CurrentPosition;
			ResetSettings();
			SetOriginals();
		}

		private PhotoAlbum _album;
		private int _index;
		private string _origCaption;
		private DateTime _origDateTaken;
		private string _origPhotographer;
		private bool _modifiedTxtNotes;
		private bool _hasChanged = false;

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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(PhotoEditDlg));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPhotoFile = new System.Windows.Forms.TextBox();
			this.txtCaption = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.cmbxPhotographer = new System.Windows.Forms.ComboBox();
			this.dtpDateTaken = new System.Windows.Forms.DateTimePicker();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnPrev = new System.Windows.Forms.Button();
			this.toolTipPhotos = new System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.dtpDateTaken,
																				 this.cmbxPhotographer,
																				 this.txtCaption,
																				 this.txtPhotoFile,
																				 this.label4,
																				 this.label3,
																				 this.label2,
																				 this.label1});
			this.panel1.Location = new System.Drawing.Point(8, 32);
			this.panel1.Size = new System.Drawing.Size(280, 128);
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
			this.label3.Location = new System.Drawing.Point(8, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "&Date Taken:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 18);
			this.label4.TabIndex = 6;
			this.label4.Text = "&Photographer:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPhotoFile
			// 
			this.txtPhotoFile.Location = new System.Drawing.Point(96, 6);
			this.txtPhotoFile.Name = "txtPhotoFile";
			this.txtPhotoFile.ReadOnly = true;
			this.txtPhotoFile.Size = new System.Drawing.Size(176, 20);
			this.txtPhotoFile.TabIndex = 1;
			this.txtPhotoFile.Text = "";
			this.toolTipPhotos.SetToolTip(this.txtPhotoFile, "Image file containing photo");
			// 
			// txtCaption
			// 
			this.txtCaption.Location = new System.Drawing.Point(96, 36);
			this.txtCaption.Name = "txtCaption";
			this.txtCaption.Size = new System.Drawing.Size(176, 20);
			this.txtCaption.TabIndex = 3;
			this.txtCaption.Text = "";
			this.toolTipPhotos.SetToolTip(this.txtCaption, "Short caption for photo");
			this.txtCaption.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaption_KeyPress);
			this.txtCaption.TextChanged += new System.EventHandler(this.txtCaption_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 168);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "&Notes:";
			// 
			// txtNotes
			// 
			this.txtNotes.AcceptsReturn = true;
			this.txtNotes.Location = new System.Drawing.Point(16, 184);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtNotes.Size = new System.Drawing.Size(264, 64);
			this.txtNotes.TabIndex = 5;
			this.txtNotes.Text = "";
			this.toolTipPhotos.SetToolTip(this.txtNotes, "Details about this photo");
			this.txtNotes.TextChanged += new System.EventHandler(this.txtNotes_TextChanged);
			// 
			// cmbxPhotographer
			// 
			this.cmbxPhotographer.Location = new System.Drawing.Point(96, 96);
			this.cmbxPhotographer.MaxDropDownItems = 4;
			this.cmbxPhotographer.Name = "cmbxPhotographer";
			this.cmbxPhotographer.Size = new System.Drawing.Size(176, 21);
			this.cmbxPhotographer.Sorted = true;
			this.cmbxPhotographer.TabIndex = 7;
			this.toolTipPhotos.SetToolTip(this.cmbxPhotographer, "Person who took photo");
			this.cmbxPhotographer.Validated += new System.EventHandler(this.cmbxPhotographer_Validated);
			this.cmbxPhotographer.TextChanged += new System.EventHandler(this.cmbxPhotographer_TextChanged);
			// 
			// dtpDateTaken
			// 
			this.dtpDateTaken.CustomFormat = "MM/dd/yy \'at\' hh:mm tt";
			this.dtpDateTaken.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateTaken.Location = new System.Drawing.Point(96, 66);
			this.dtpDateTaken.Name = "dtpDateTaken";
			this.dtpDateTaken.Size = new System.Drawing.Size(176, 20);
			this.dtpDateTaken.TabIndex = 5;
			this.toolTipPhotos.SetToolTip(this.dtpDateTaken, "When photo was taken");
			// 
			// btnNext
			// 
			this.btnNext.Image = ((System.Drawing.Bitmap)(resources.GetObject("btnNext.Image")));
			this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNext.Location = new System.Drawing.Point(224, 8);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(60, 20);
			this.btnNext.TabIndex = 6;
			this.btnNext.Text = "N&ext";
			this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.toolTipPhotos.SetToolTip(this.btnNext, "Next photo");
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnPrev
			// 
			this.btnPrev.Image = ((System.Drawing.Bitmap)(resources.GetObject("btnPrev.Image")));
			this.btnPrev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPrev.Location = new System.Drawing.Point(152, 8);
			this.btnPrev.Name = "btnPrev";
			this.btnPrev.Size = new System.Drawing.Size(60, 20);
			this.btnPrev.TabIndex = 7;
			this.btnPrev.Text = "Pre&v";
			this.btnPrev.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolTipPhotos.SetToolTip(this.btnPrev, "Previous photo");
			this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
			// 
			// PhotoEditDlg
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(296, 297);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnPrev,
																		  this.panel1,
																		  this.btnNext,
																		  this.label5,
																		  this.txtNotes});
			this.Name = "PhotoEditDlg";
			this.Text = "Photo Properties";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		protected override void ResetSettings()
		{
			// Initialize the ComboBox settings
			if (cmbxPhotographer.Items.Count == 0)
			{
				// Create the list of photographers
				cmbxPhotographer.BeginUpdate();
				cmbxPhotographer.Items.Clear();
				cmbxPhotographer.Items.Add("unknown");

				foreach (Photograph ph in _album)
				{
					if (ph.Photographer != null && !cmbxPhotographer.Items.Contains(ph.Photographer))
					{
						cmbxPhotographer.Items.Add(ph.Photographer);
					}
				}
				cmbxPhotographer.EndUpdate();
			}

			Photograph photo = _album[_index];

			if (photo != null)
			{
				txtPhotoFile.Text = photo.FileName;
				txtCaption.Text = photo.Caption;
				dtpDateTaken.Value = photo.DateTaken;
				cmbxPhotographer.SelectedItem = photo.Photographer;
				txtNotes.Text = photo.Notes;
			}

			btnPrev.Enabled = !(_index == 0);
			btnNext.Enabled = !(_index == _album.Count - 1);
		}

		protected override bool SaveSettings()
		{
			if (NewControlValues())
			{
				// Save the photograph’s settings
				Photograph photo = _album[_index];

				if (photo != null)
				{
					photo.Caption = txtCaption.Text;
					photo.DateTaken = dtpDateTaken.Value;
					photo.Photographer = cmbxPhotographer.Text;
					photo.Notes = txtNotes.Text;
					_hasChanged = true;
				}
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

		private void cmbxPhotographer_Validated(object sender, System.EventArgs e)
		{
			string pg = cmbxPhotographer.Text;

			if (!cmbxPhotographer.Items.Contains(pg))
			{
				_album[_index].Photographer = pg;
				cmbxPhotographer.Items.Add(pg);
			}
			cmbxPhotographer.SelectedItem = pg;
		}

		private void cmbxPhotographer_TextChanged(object sender, System.EventArgs e)
		{
			string text = cmbxPhotographer.Text;
			int index = cmbxPhotographer.FindString(text);

			if (index >= 0)
			{
				// Found a match
				string newText = cmbxPhotographer.Items[index].ToString();
				cmbxPhotographer.Text = newText;

				cmbxPhotographer.SelectionStart = text.Length;
				cmbxPhotographer.SelectionLength = newText.Length - text.Length;
			}
		}

		protected void SetOriginals()
		{
			Photograph photo = _album[_index];

			if (photo != null) 
			{
				_origCaption = photo.Caption;
				_origDateTaken = photo.DateTaken;
				_origPhotographer = photo.Photographer;
				_modifiedTxtNotes = false;
			}
		}

		private void txtNotes_TextChanged(object sender, System.EventArgs e)
		{
			if (txtNotes.Focused)
				_modifiedTxtNotes = true;
		}

		protected bool NewControlValues()
		{
			bool result =
				((_origCaption != txtCaption.Text)
				|| (_origDateTaken != dtpDateTaken.Value)
				|| (_origPhotographer != cmbxPhotographer.Text)
				|| (_modifiedTxtNotes));

			return result;
		}

		private void btnNext_Click(object sender, System.EventArgs e)
		{
			SaveSettings();

			if (_index < _album.Count - 1)
			{
				_index ++;
				ResetSettings();
				SetOriginals();
			}
		}

		private void btnPrev_Click(object sender, System.EventArgs e)
		{
			SaveSettings();

			if (_index > 0)
			{
				_index --;
				ResetSettings();
				SetOriginals();
			}
		}

		public bool HasChanged
		{
			get { return _hasChanged; }
		}

		// end of PhotoEditDlg
	}
}

