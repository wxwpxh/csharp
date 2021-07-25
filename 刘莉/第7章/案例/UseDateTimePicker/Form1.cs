using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UseDateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1 .Format =DateTimePickerFormat .Custom ;
            dateTimePicker1.CustomFormat = "HH:mm:ss MM/dd yyyy dddd";
            this.textBox1.Text = dateTimePicker1.Value.ToString();            
        }
    }
}
