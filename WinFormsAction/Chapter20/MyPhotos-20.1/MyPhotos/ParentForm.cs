using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
	}
}