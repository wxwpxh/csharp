using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyAlbumExplorer
{
	public partial class ExplorerForm : Form
	{
		public ExplorerForm()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			// Assign title bar
			Version v = new Version(Application.ProductVersion);
			this.Text = String.Format("MyAlbumExplorer {0:#}.{1:#}",
				v.Major, v.Minor);
			
			base.OnLoad(e);
		}
	}
}