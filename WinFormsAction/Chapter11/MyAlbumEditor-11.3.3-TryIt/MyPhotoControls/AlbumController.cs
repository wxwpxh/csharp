using System;
using System.Windows.Forms;
using Manning.MyPhotoAlbum;
namespace Manning.MyPhotoControls
{
	public static class AlbumController
	{
		public static bool OpenAlbumDialog(ref string path, ref string password)
		{
			// Allow user to select a new album
			using (OpenFileDialog dlg = new OpenFileDialog())
			{
				dlg.Title = "Open Album";
				dlg.Filter = "Album files (*.abm)|*.abm|"
					+ "All files (*.*)|*.*";
				dlg.InitialDirectory = AlbumManager.DefaultPath;
				dlg.RestoreDirectory = true;

				if (dlg.ShowDialog() == DialogResult.OK)
				{
					path = dlg.FileName;
					return CheckAlbumPassword(path, ref password);
				}
			}

			return false;
		}

		/// <summary>
		/// Open one or more photographs
		/// </summary>
		/// <remarks>This is taken from the menuEditAdd_Click() method
		/// in the MainForm class of the MyPhotos solution.</remarks>
		/// <returns></returns>
		public static string[] OpenPhotographs()
		{
			using (OpenFileDialog dlg = new OpenFileDialog())
			{

				dlg.Title = "Add Photos";
				dlg.Multiselect = true;
				dlg.Filter = "Image Files (JPEG, GIF, BMP, etc.)|"
					+ "*.jpg;*.jpeg;*.gif;*.bmp;"
					+ "*.tif;*.tiff;*.png|"
					+ "JPEG files (*.jpg;*.jpeg)|*.jpg;*.jpeg|"
					+ "GIF files (*.gif)|*.gif|"
					+ "BMP files (*.bmp)|*.bmp|"
					+ "TIFF files (*.tif;*.tiff)|*.tif;*.tiff|"
					+ "PNG files (*.png)|*.png|"
					+ "All files (*.*)|*.*";
				dlg.InitialDirectory = Environment.CurrentDirectory;

				if (dlg.ShowDialog() == DialogResult.OK)
					return dlg.FileNames;
				else
					return null;
			}
		}

		public static bool CheckAlbumPassword(string path, ref string password)
		{
			// Get password if encrypted
			if (AlbumStorage.IsEncrypted(path))
			{
				using (AlbumPasswordDialog pwdDlg
				= new AlbumPasswordDialog())
				{
					pwdDlg.Album = path;
					if (pwdDlg.ShowDialog() != DialogResult.OK)
						return false; // Open cancelled
					password = pwdDlg.Password;
				}
			}
			return true;
		}

		public static bool SaveAlbumDialog(ref string path)
		{
			using (SaveFileDialog dlg = new SaveFileDialog())
			{
				// Display a dialog for saving the album
				dlg.Title = "Save Album";
				dlg.DefaultExt = "abm";
				dlg.Filter = "Album files (*.abm)|*.abm|"
					+ "All files|*.*";
				dlg.InitialDirectory = AlbumManager.DefaultPath;
				dlg.RestoreDirectory = true;

				if (dlg.ShowDialog() == DialogResult.OK)
				{
					// Save the album under the new name
					path = dlg.FileName;
					return true;
				}

				return false;
			}
		}

		public static DialogResult AskForSave(AlbumManager manager)
		{
			if (manager.Album.HasChanged)
			{
				string msg;
				if (manager.FullName == null)
					msg = "Do you wish to save your changes?";
				else
					msg = "Do you wish to save your changes to "
						+ manager.ShortName + "?";

				// Ask user if they wish to save file
				DialogResult result = MessageBox.Show(
					msg, "Save Changes?",
					MessageBoxButtons.YesNoCancel,
					MessageBoxIcon.Question);

				return result;
			}

			return DialogResult.No;
		}

	}
}