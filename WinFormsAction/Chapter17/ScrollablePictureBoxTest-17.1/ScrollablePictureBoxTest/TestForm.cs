using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScrollablePictureBoxTest
{
	public partial class TestForm : Form
	{
		public TestForm()
		{
			InitializeComponent();
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				spbxImage.Image = Image.FromFile(dlg.FileName);
			}
		}

		private void comboSizeMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboSizeMode.Text.Length > 0)
			{
				spbxImage.SizeMode = (PictureBoxSizeMode)
					Enum.Parse(typeof(PictureBoxSizeMode),
							   comboSizeMode.Text);
			}
		}
	}
}