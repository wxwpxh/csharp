using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Manning.MyPhotoAlbum;

namespace Manning.MyPhotoControls
{
	public partial class PhotoEditDialog : Manning.MyPhotoControls.BaseEditDialog
	{
		private Photograph _photo;
		private Photograph Photo { get { return _photo; } }

		private AlbumManager _manager = null;
		private AlbumManager Manager { get { return _manager; } }

		protected PhotoEditDialog()
		{
			// Call required by Windows Form Designer.
			InitializeComponent();
		}

		private void InitializeDialog(Photograph photo)
		{
			_photo = photo;
			ResetDialog();
		}

		public PhotoEditDialog(Photograph photo)
			: this()
		{
			if (photo == null)
				throw new ArgumentNullException(
					"The photo parameter cannot be null");

			InitializeDialog(photo);
		}

		public PhotoEditDialog(AlbumManager mgr)
			: this()
		{
			if (mgr == null)
				throw new ArgumentNullException(
					"The mgr parameter cannot be null");

			_manager = mgr;
			InitializeDialog(mgr.Current);
		}

		protected override void ResetDialog()
		{
			Photograph photo = Photo;
			if (photo != null)
			{
				txtPhotoFile.Text = photo.FileName;
				txtCaption.Text = photo.Caption;
				txtDateTaken.Text = photo.DateTaken.ToString();
				txtPhotographer.Text = photo.Photographer;
				txtNotes.Text = photo.Notes;
			}
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			if (DialogResult == DialogResult.OK)
				SaveSettings();
		}

		private void SaveSettings()
		{
			Photograph photo = Photo;

			if (photo != null)
			{
				photo.Caption = txtCaption.Text;
				photo.Photographer = txtPhotographer.Text;
				photo.Notes = txtNotes.Text;

				// On parse error, do not set date
				try
				{
					photo.DateTaken = DateTime.Parse(txtDateTaken.Text);
				}
				catch (FormatException) { }
			}
		}

		private void txtCaption_KeyPress(object sender, KeyPressEventArgs e)
		{
			char c = e.KeyChar;
			e.Handled = !(Char.IsLetterOrDigit(c)
				|| Char.IsWhiteSpace(c)
				|| Char.IsControl(c));

			if (e.Handled)
				Console.Beep();
		}

		private void txtCaption_TextChanged(object sender, EventArgs e)
		{
			Text = txtCaption.Text + " - Properties";
		}

		private void ctxMenuNotes_Opened(object sender, EventArgs e)
		{
			menuUndo.Enabled = txtNotes.CanUndo;
			menuCopy.Enabled = txtNotes.SelectionLength > 0;
			menuCut.Enabled = txtNotes.SelectionLength > 0;
			menuPaste.Enabled = Clipboard.ContainsText();
			menuDelete.Enabled = txtNotes.TextLength > 0;
			menuSelectAll.Enabled = (txtNotes.SelectionLength < txtNotes.TextLength);
		}

		private void menuUndo_Click(object sender, EventArgs e)
		{
			if (txtNotes.CanUndo)
				txtNotes.Undo();
		}

		private void menuCopy_Click(object sender, EventArgs e)
		{
			txtNotes.Copy();
		}

		private void menuCut_Click(object sender, EventArgs e)
		{
			txtNotes.Cut();
		}

		private void menuPaste_Click(object sender, EventArgs e)
		{
			txtNotes.Paste();
		}

		private void menuDelete_Click(object sender, EventArgs e)
		{
			txtNotes.Clear();
		}

		private void menuSelectAll_Click(object sender, EventArgs e)
		{
			txtNotes.SelectAll();
		}

	}
}

