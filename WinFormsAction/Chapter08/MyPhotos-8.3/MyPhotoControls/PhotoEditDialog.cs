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
		private static class CurrentDate
		{
			/*
			 * In the book, there really should be a step 11 on page
			 * 238 that alters the SaveSettings() method to use
			 * CurrentDate.Parse() instead of DateTime.Parse(). This
			 * would ensure that future dates are ignored.
			 * 
			 * I caught this too late, so I had the text in step 9
			 * changed to say "may be ignored" (rather than "will")
			 * to represent the fact that future dates are still accepted.
			 * 
			 * I modified SaveSettings() here to achieve this
			 * behavior.
			 */
			public static DateTime Parse(string input)
			{
				DateTime result = DateTime.Parse(input);
				if (result > DateTime.Now)
					throw new FormatException(
						"The given date is in the future.");

				return result;
			}
		}

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

			mskDateTaken.ValidatingType = typeof(CurrentDate);
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
				mskDateTaken.Text = photo.DateTaken.ToString();
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
					photo.DateTaken = CurrentDate.Parse(mskDateTaken.Text);
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

		private void mskDateTaken_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
		{
			if (!e.IsValidInput)
			{
				DialogResult result = MessageBox.Show(
					"The Date Taken entry is invalid or "
						+ "in the future and will be ignored."
						+ " Do you wish to correct this?",
					"Photo Properties",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question);

				e.Cancel = (result == DialogResult.Yes);
			}
		}

	}
}

