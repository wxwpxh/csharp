using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace PickerSample
{
	public partial class PickerForm : Form
	{
		public PickerForm()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnColor_Click(object sender, EventArgs e)
		{
			Type t = typeof(DateTimePicker); //same as dtpDate.GetType();
			string prop = comboProperty.Text;

			PropertyInfo info = t.GetProperty(prop);
			if (info != null && info.PropertyType == typeof(Color))
			{
				using (ColorDialog dlg = new ColorDialog())
				{
					dlg.Color = (Color)info.GetValue(dtpDate, null);
					if (dlg.ShowDialog() == DialogResult.OK)
						info.SetValue(dtpDate, dlg.Color, null);
				}
			}
			else
				MessageBox.Show("Property not found, or property not a color.");
		}

	}
}