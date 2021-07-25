using System;
using System.Windows.Forms;

namespace ListViewSample
{
	public partial class ListViewForm : Form
	{
		public ListViewForm()
		{
			InitializeComponent();
		}

		// Strings for numbers from zero to nineteen
		string[] ones = { "zero", "one", "two", "three", "four", "five",
			"six", "seven", "eight", "nine", "ten",
			"eleven", "twelve", "thirteen", "fourteen", "fifteen",
			"sixteen", "seventeen", "eighteen", "nineteen" };

		// Strings for numbers by tens from zero to ninety
		string[] tens = { "zero", "ten", "twenty", "thirty", "forty",
			"fifty", "sixty", "seventy", "eighty", "ninety" };

		private void lvNumbers_RetrieveVirtualItem(object sender,
			RetrieveVirtualItemEventArgs e)
		{
			int x = e.ItemIndex;
			string numString = NumericString(x);
			ListViewItem item = new ListViewItem(numString);
			e.Item = item;
		}

		private string NumericString(int x)
		{
			if (x < 20)
				return ones[x];
			else if (x < 100)
			{
				int n = x % 10;
				x = x / 10;
				if (n == 0) return tens[x];
				else return tens[x] + "-" + ones[n];
			}
			else if (x < 1000)
			{
				string result = NumericString(x / 100) + " hundred ";
				return result + NumericString(x % 100);
			}
			else if (x < 1000000)
			{
				string result = NumericString(x / 1000) + " thousand ";
				return result + NumericString(x % 1000);
			}
			else if (x < 1000000000)
			{
				string result = NumericString(x / 1000000) + " million ";
				return result + NumericString(x % 1000000);
			}
			else
				return "number too big";
		}

		private void nudSize_ValueChanged(object sender, EventArgs e)
		{
			lvNumbers.VirtualListSize = (int)nudSize.Value;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}