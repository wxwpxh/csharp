private string _directory;

[Editor(typeof(System.Windows.Forms.Design.FolderNameEditor),
		typeof(System.Drawing.Design.UITypeEditor))]
public string BaseDirectory
{
	get { return _directory; }
	set { _directory = value; }
}