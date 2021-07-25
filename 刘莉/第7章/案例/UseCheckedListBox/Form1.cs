using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UseCheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            //遍历checkedListBox1的选中项
            for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
            {
                str += checkedListBox1.Items[checkedListBox1.CheckedIndices[i]].ToString() + "\n";
            }
            MessageBox.Show(str,"你的爱好");
            str = "";
            //方法二
            foreach (string s in checkedListBox1.CheckedItems)
            {
                str += s + "\n";
            }
            MessageBox.Show(str, "你的爱好");
        }
    }
}
