private Color _color;

[EditorAttribute(typeof(System.Drawing.Design.ColorEditor),
				 typeof(System.Drawing.Design.UITypeEditor))]
[TypeConverter(typeof(System.Drawing.ColorConverter))]
[AmbientValue(typeof(Color), "Empty")]
public Color BaseColor
{
	get { return _color; }
	set
	{
		if (value == Color.Empty)
			_color = BackColor; // use BackColor by default
		else
			_color = value;
	}
}
