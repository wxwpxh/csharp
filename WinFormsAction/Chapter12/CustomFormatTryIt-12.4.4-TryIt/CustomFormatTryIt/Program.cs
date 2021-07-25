using System;
using System.Collections.Generic;
using System.Text;

using Manning.MyPhotoAlbum;

namespace CustomFormatTryIt
{
	class Program
	{
		static void Main(string[] args)
		{
			CustomPhotoFormatter photoFormatter = new CustomPhotoFormatter();
			Photograph photo = new Photograph("c:\\temp\\MyRedImage.bmp");
			Console.WriteLine(String.Format(photoFormatter,
				"The pixel at (100,100) is {0:p100,100}",
				photo));
		}
	}
}
