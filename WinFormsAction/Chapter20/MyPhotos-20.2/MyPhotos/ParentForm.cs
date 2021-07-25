using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Manning.MyPhotoAlbum;
using Manning.MyPhotoControls;

namespace MyPhotos
{
	public partial class ParentForm : Form
	{
		public ParentForm()
		{
			InitializeComponent();
		}

		private void menuFileExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void menuFileNew_Click(object sender, EventArgs e)
		{
			CreateMdiChild(new MainForm());
		}

		private void CreateMdiChild(Form child)
		{
			child.MdiParent = this;
			child.Show();
		}

		private void menuFileOpen_Click(object sender, EventArgs e)
		{
			OpenAlbum();
		}

		private void OpenAlbum()
		{
			string path = null;
			string pwd = null;

			if (AlbumController.OpenAlbumDialog(ref path, ref pwd))
			{
				try
				{
					CreateMdiChild(new MainForm(path, pwd));
				}
				catch (AlbumStorageException aex)
				{
					MessageBox.Show(this, "Unable to open album " + path
							+ "\n [" + aex.Message + "]",
						"Open Album Error",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				}
			}
		}

		private void menuFileClose_Click(object sender, EventArgs e)
		{
			if (ActiveMdiChild != null)
				ActiveMdiChild.Close();
		}

		private void menuFile_DropDownOpening(object sender, EventArgs e)
		{
			menuFileClose.Enabled = (this.ActiveMdiChild != null);
		}

	}
}