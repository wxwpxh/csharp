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

	}
}

