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
			menuView.DropDown = ctxMenuPhoto;
		}

		private void SetTitleBar()
		{
			Version ver = new Version(Application.ProductVersion);
			Text = String.Format("MyPhotos {0:0}.{1:0} Try It",
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

		private void menuImage_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			ProcessImageClick(e);
		}

		private void ProcessImageClick(ToolStripItemClickedEventArgs e)
		{
			ToolStripItem item = e.ClickedItem;
			string enumVal = item.Tag as string;
			if (enumVal != null)
			{
				pbxPhoto.SizeMode = (PictureBoxSizeMode)
				Enum.Parse(typeof(PictureBoxSizeMode),
				enumVal);
			}
		}

		private void menuImage_DropDownOpening(object sender, EventArgs e)
		{
			ProcessImageOpening(sender as ToolStripDropDownItem);
		}

		private void ProcessImageOpening(ToolStripDropDownItem parent)
		{
			if (parent != null)
			{
				string enumVal = pbxPhoto.SizeMode.ToString();
				foreach (ToolStripMenuItem item in parent.DropDownItems)
				{
					item.Enabled = (pbxPhoto.Image != null);
					item.Checked = item.Tag.Equals(enumVal);
				}
			}
		}
	}
}