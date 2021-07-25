using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

/*
 * This code implements the Try It! excercise from section 18.2 of the book
 * "Windows Forms Programming with C#" by Erik Brown.  After compiling the new
 * MyPhotoAlbum library with this new file in it, you can add the PhotoBox control to
 * the Toolbox window in Visual Studio .NET by performing the following steps:
 * 
 *		1. Open the Toolbox window
 *		2. Right-click to display the context menu and select "Customer Toolbox..."
 *		3. Select the ".NET Framework Components" tab.
 *		4. Click the "Browse..." button to display an open file dialog.
 *		5. Locate and select the MyPhotoAlbum.dll file with the compiled PhotoBox control.
 *		6. Click the Open button.
 * 
 * The PhotoBox control will now appear in the Toolbox window and can be dragged onto
 * a Form just like any other Windows Forms control.  In this PhotoBox.cs file, note
 * that the "Description" and "DefaultValue" attributes given for the new SizeMode
 * property are used in the Properties window of Visual Studio to control what appears
 * as the default value and the text for the Description pane.  As you might expect,
 * a number of other attributes exist for control other appearance aspects of a
 * displayed control.
 */
namespace Manning.MyPhotoAlbum
{
	/// <summary>
	/// Duplicates the PictureBoxSizeMode enumeration with the addition of
	/// a ScaleImage memeber to preserve the aspect ratio of an image
	/// within the control window.
	/// </summary>
	public enum PhotoBoxSizeMode
	{
		Normal = PictureBoxSizeMode.Normal,
		StretchImage = PictureBoxSizeMode.StretchImage,
		AutoSize = PictureBoxSizeMode.AutoSize,
		CenterImage = PictureBoxSizeMode.CenterImage,
		ScaleImage
	}

	/// <summary>
	/// A picture box that can scale an image to fit the window.
	/// </summary>
	public class PhotoBox : System.Windows.Forms.PictureBox
	{
		private PhotoBoxSizeMode _sizeMode = PhotoBoxSizeMode.ScaleImage;

		/// <summary>
		/// Overrides the SizeMode property from the PictureBox control.
		/// </summary>
		[ Description("Gets or sets how the image should be drawn in the client window.")]
		[ DefaultValue(PhotoBoxSizeMode.ScaleImage) ]
		public new PhotoBoxSizeMode SizeMode
		{
			get { return _sizeMode; }
			set 
			{
				_sizeMode = value;
				Invalidate();
			}
		}

		/// <summary>
		/// Calculate the rectangle required to scale an image within the window.  This
		/// code matches that used in the book, except it is written to work within
		/// the PhotoBox class.
		/// </summary>
		/// <param name="targetArea">The target rectangle where the image
		/// is to be displayed.</param>
		/// <param name="img">The image to display.</param>
		/// <returns>A rectangle in which to draw the image that will preserve
		/// the aspect ratio of the image.</returns>
		private Rectangle ScaleToFit(Rectangle targetArea, System.Drawing.Image img)
		{
			Rectangle result = new Rectangle(targetArea.Location.X, targetArea.Location.Y,
				targetArea.Size.Width-1, targetArea.Size.Height-1);

			// Determine best fit: width or height
			if (result.Height * img.Width > result.Width * img.Height)
			{
				// Final width should match target, determine and center height
				result.Height = result.Width * img.Height / img.Width;
				result.Y += (targetArea.Height - result.Height) / 2;
			}
			else
			{
				// Final height should match target, determine and center width
				result.Width = result.Height * img.Width / img.Height;
				result.X += (targetArea.Width - result.Width) / 2;
			}

			return result;
		}

		/// <summary>
		/// Overrides the PictureBox version of this method.  Note that
		/// the ScaleImage mode does not invoke the base OnPoint method,
		/// and will therefore not invoke any Paint event handlers
		/// registered with the class.
		/// </summary>
		/// <param name="e">the Paint event data</param>
		protected override void OnPaint(PaintEventArgs e)
		{
			if (this.SizeMode != PhotoBoxSizeMode.ScaleImage)
			{
				base.SizeMode = (PictureBoxSizeMode)_sizeMode;
				base.OnPaint(e);
				return;
			}

			// Implement ScaleImage enumeration value.
			e.Graphics.Clear(this.BackColor);

			if (Image != null)
			{
				// Draw the image in the proper rectangle with a black border
				Rectangle paintRec = ScaleToFit(this.ClientRectangle, this.Image);
				e.Graphics.DrawImage(this.Image, paintRec);
				e.Graphics.DrawRectangle(Pens.Black, paintRec);
			}
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);

			if (this.SizeMode == PhotoBoxSizeMode.ScaleImage)
			{
				// Force the control to redraw the image
				this.Invalidate();
			}
		}

		// end of PhotoBox class
	}
}
