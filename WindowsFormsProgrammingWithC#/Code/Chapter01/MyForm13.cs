[assembly: System.Reflection.AssemblyVersion("1.3")]

namespace MyNamespace
{
	using System;
	using System.Drawing;
	using System.Windows.Forms;

	public class MyForm : System.Windows.Forms.Form
	{
		private Button btnLoad;	
		private PictureBox imgPhoto;

		public MyForm()
		{
            		// Constructor
			this.Text = "Hello Form 1.3";

			// Create and configure the Button
			btnLoad = new Button();
			btnLoad.Text = "&Load";
			btnLoad.Left = 10;
			btnLoad.Top = 10;
			btnLoad.Click += new System.EventHandler(this.OnLoadClick);

			// Create and configure the PictureBox
			imgPhoto = new PictureBox();
			imgPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			imgPhoto.Width = this.Width / 2;			
			imgPhoto.Height = this.Height / 2;			
			imgPhoto.Left = (this.Width - imgPhoto.Width) / 2;
			imgPhoto.Top = (this.Height - imgPhoto.Height) / 2;
			imgPhoto.SizeMode = PictureBoxSizeMode.StretchImage;

			// Add our new controls to the Form
			this.Controls.Add(btnLoad);
			this.Controls.Add(imgPhoto);	
		}

		protected void OnLoadClick(object sender, System.EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();

			dlg.Title = "Open Photo";
			dlg.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*" ;

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				imgPhoto.Image = new Bitmap(dlg.OpenFile());
			}

			dlg.Dispose();
		}


		public static void Main()
		{
			Application.Run(new MyForm());
		}
	}
}
