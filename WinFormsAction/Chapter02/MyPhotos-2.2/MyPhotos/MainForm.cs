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
	}
}