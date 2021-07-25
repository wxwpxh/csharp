[assembly: System.Reflection.AssemblyVersion("1.5")]

namespace MyNamespace
{
	using System;
	using System.Drawing;
	using System.Windows.Forms;

	public class MyForm : System.Windows.Forms.Form
	{
		private Button btnLoad;	
		private PictureBox pboxPhoto;

		public MyForm()
		{
           		// Constructor
			this.Text = "Hello Form 1.5";
			this.MinimumSize = new Size(200,200);

			// Create and configure the Button
			btnLoad = new Button();
			btnLoad.Text = "&Load";
			btnLoad.Left = 10;
			btnLoad.Top = 10;
			btnLoad.Click += new System.EventHandler(this.OnLoadClick);
			btnLoad.Anchor = AnchorStyles.Top | AnchorStyles.Left;

			// Create and configure the PictureBox
			pboxPhoto = new PictureBox();
			pboxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			pboxPhoto.Width = this.Width / 2;			
			pboxPhoto.Height = this.Height / 2;			
			pboxPhoto.Left = (this.Width - pboxPhoto.Width) / 2;
			pboxPhoto.Top = (this.Height - pboxPhoto.Height) / 2;
			pboxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
			pboxPhoto.Dock = DockStyle.Fill;

			// Add our new controls to the Form
			this.Controls.Add(btnLoad);
			this.Controls.Add(pboxPhoto);	
		}

		protected void OnLoadClick(object sender, System.EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();

			dlg.Title = "Open Photo";
			dlg.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*" ;

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				pboxPhoto.Image = new Bitmap(dlg.OpenFile());
			}

			dlg.Dispose();
		}


		public static void Main()
		{
			Application.Run(new MyForm());
		}
	}
}
