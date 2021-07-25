using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyAlbumEditor
{
	public partial class WorkerProgressDialog : Form
	{
		public WorkerProgressDialog()
		{
			InitializeComponent();
		}

		public int Progress
		{
			get { return pbarProgress.Value; }
			set { pbarProgress.Value = value; }
		}

	}
}