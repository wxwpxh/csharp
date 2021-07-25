using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyPhotos
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			SetTitleBar();
		}

		private void SetTitleBar()
		{
			Version ver = new Version(Application.ProductVersion);
			Text = String.Format("MyPhotos {0:0}.{1:0} TRY IT",
			ver.Major, ver.Minor);
		}

		private Image LoadPhoto()
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Title = "Open Photo";
			dlg.Filter = "jpg files (*.jpg)|*.jpg"
				+ "|All files (*.*)|*.*";

			Image result = null;
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				try
				{
					result = new Bitmap(dlg.OpenFile());
				}
				catch (ArgumentException ex)
				{
					// Handle exception
					MessageBox.Show("Unable to load file: " + ex.Message);
					result = null;
				}
			}

			dlg.Dispose();
			return result;
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			pbxPhoto.Image = LoadPhoto();
		}
		
		private void btnLoad2_Click(object sender, EventArgs e)
		{
			pbxPhoto2.Image = LoadPhoto();
		}

        private void pbxPhoto_Click(object sender, EventArgs e)
        {

        }
    }
}