[assembly: System.Reflection.AssemblyVersion("1.2")]

namespace MyNamespace
{
	using System;	
	using System.Windows.Forms;

	public class MyForm : System.Windows.Forms.Form
	{
		private Button btnLoad;	
		private PictureBox imgPhoto;

        public MyForm()
        {
		// Constructor
		this.Text = "Hello Form 1.2";

		// Create and configure the Button
		btnLoad = new Button();
		btnLoad.Text = "&Load";
		btnLoad.Left = 10;
		btnLoad.Top = 10;

		// Create and configure the PictureBox
		imgPhoto = new PictureBox();
		imgPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		imgPhoto.Width = this.Width / 2;			
		imgPhoto.Height = this.Height / 2;			
		imgPhoto.Left = (this.Width - imgPhoto.Width) / 2;
		imgPhoto.Top = (this.Height - imgPhoto.Height) / 2;

		// Add our new controls to the Form
		this.Controls.Add(btnLoad);
		this.Controls.Add(imgPhoto);	
        }


	public static void Main()
        {
            Application.Run(new MyForm());
        }
    }
}
