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
			Text = String.Format("MyPhotos {0:0}.{1:0}",
			ver.Major, ver.Minor);
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Title = "Open Photo";
			dlg.Filter = "jpg files (*.jpg)|*.jpg"
				+ "|All files (*.*)|*.*";
			
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				try
				{
					pbxPhoto.Image = new Bitmap(dlg.OpenFile());
				}
				catch (ArgumentException ex)
				{
					// Handle exception
					MessageBox.Show("Unable to load file: " + ex.Message);
					pbxPhoto.Image = null;
				}
			}
			
			dlg.Dispose();
		}

		private void menuFileLoad_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();

			dlg.Title = "Load Photo";
			dlg.Filter = "jpg files (*.jpg)"
				+ "|*.jpg|All files (*.*)|*.*";
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				try
				{
					pbxPhoto.Image = new Bitmap(dlg.OpenFile());
				}
				catch (ArgumentException ex)
				{
					MessageBox.Show("Unable to load file: "
						+ ex.Message);
				}
			}

			dlg.Dispose();
		}

		private void menuFileExit_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}