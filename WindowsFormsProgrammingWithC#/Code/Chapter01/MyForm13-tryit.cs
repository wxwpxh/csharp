[assembly: System.Reflection.AssemblyVersion("1.3.2")]

namespace MyNamespace
{
	using System;
	using System.Drawing;
	using System.Windows.Forms;

	public class MyForm : System.Windows.Forms.Form
	{
		private Button btnLoad, btnLoad2;	
		private PictureBox imgPhoto, imgPhoto2;

		public MyForm()
		{
            		// Constructor
			this.Text = "Hello Form 1.3 TRY IT";

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
			imgPhoto.Left = 0;
			imgPhoto.Top = btnLoad.Bottom + 5;
			imgPhoto.SizeMode = PictureBoxSizeMode.StretchImage;

			// Create and configure the second Button
			btnLoad2 = new Button();
			btnLoad2.Text = "L&oad2";
			btnLoad2.Left = btnLoad.Right + 10;
			btnLoad2.Top = 10;
			btnLoad2.Click += new System.EventHandler(this.OnLoadClick);

			// Create and configure the PictureBox
			imgPhoto2 = new PictureBox();
			imgPhoto2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			imgPhoto2.Width = this.Width / 2;			
			imgPhoto2.Height = this.Height / 2;			
			imgPhoto2.Left = imgPhoto.Right + 5;
			imgPhoto2.Top = imgPhoto.Top;
			imgPhoto2.SizeMode = PictureBoxSizeMode.StretchImage;

			// Add our new controls to the Form
			this.Controls.Add(btnLoad);
			this.Controls.Add(imgPhoto);	
			this.Controls.Add(btnLoad2);
			this.Controls.Add(imgPhoto2);	
		}

		// Note here how one constructor can invoke another, in this
		// case to create our button and picture box controls.
		public MyForm(string imageFile) : this()
		{
			Console.WriteLine("Image 0 is " + imageFile);
			imgPhoto.Image = new Bitmap(imageFile);
		}		

		public MyForm(string imageFile0, string imageFile1) : this(imageFile0)
		{
			Console.WriteLine("Image 1 is " + imageFile1);
			imgPhoto2.Image = new Bitmap(imageFile1);
		}		

		// This code does something slightly different than suggested
		// in the book.  We use the "OnLoadClick" handler as the Click
		// handler for both buttons, and make use of the "sender"
		// parameter to determine which PictureBox to use.
		protected void OnLoadClick(object sender, System.EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();

			dlg.Title = "Open Photo";
			dlg.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*" ;

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				if (sender == btnLoad2)
					imgPhoto2.Image = new Bitmap(dlg.OpenFile());
				else
					imgPhoto.Image = new Bitmap(dlg.OpenFile());
			}

			dlg.Dispose();
		}

		// Note that the [0] argument is the first parameter, rather than
		// the executable name as it is in C++.
		public static void Main(string[] args)
		{
			if (args.Length < 1)
				Application.Run(new MyForm());
			else if (args.Length > 1)
				Application.Run(new MyForm(args[0], args[1]));
			else
				Application.Run(new MyForm(args[0]));
		}
	}
}
