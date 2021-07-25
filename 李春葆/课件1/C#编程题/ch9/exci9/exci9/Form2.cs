using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exci9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void rbutton1_CheckedChanged(object sender, EventArgs e)
        {
            Font f = new Font("宋体", textBox1.Font.Size, textBox1.Font.Style);
            textBox1.Font = f;
        }

        private void rbutton2_CheckedChanged(object sender, EventArgs e)
        {
            Font f = new Font("楷体", textBox1.Font.Size, textBox1.Font.Style);
            textBox1.Font = f;
        }

        private void rbutton3_CheckedChanged(object sender, EventArgs e)
        {
            Font f = new Font(textBox1.Font.Name, 10, textBox1.Font.Style);
            textBox1.Font = f;
        }

        private void rbutton4_CheckedChanged(object sender, EventArgs e)
        {
            Font f = new Font(textBox1.Font.Name, 16, textBox1.Font.Style);
            textBox1.Font = f;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Font f = new Font(textBox1.Font.Name, textBox1.Font.Size, FontStyle.Bold);
                textBox1.Font = f;
            }
            else
            {
                Font f = new Font(textBox1.Font.Name, textBox1.Font.Size, FontStyle.Regular);
                textBox1.Font = f;
            }
        }
    }
}
