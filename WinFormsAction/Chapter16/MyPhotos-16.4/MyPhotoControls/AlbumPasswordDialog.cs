using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Manning.MyPhotoControls
{
	public partial class AlbumPasswordDialog : Form
	{
		public AlbumPasswordDialog()
		{
			InitializeComponent();
		
			// Define dialog results for link labels
			IButtonControl btn = (IButtonControl)lnkOK;
			btn.DialogResult = DialogResult.OK;
			btn = (IButtonControl)lnkCancel;
			btn.DialogResult = DialogResult.Cancel;
		}

		public string Album
		{
			get { return txtAlbum.Text; }
			set { txtAlbum.Text = value; }
		}

		public string Password
		{
			get { return txtPassword.Text; }
			set { txtPassword.Text = value; }
		}

		private void lnk_LinkClicked(object sender,
			LinkLabelLinkClickedEventArgs e)
		{
			IButtonControl btn = sender as IButtonControl;
			if (btn != null)
			{
				DialogResult = btn.DialogResult;
				Close();
			}
		}
	}
}