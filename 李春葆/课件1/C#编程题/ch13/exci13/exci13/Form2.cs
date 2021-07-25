using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exci13
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public class Myclass
        {
            int no;
            string name;
            public void input(int no1, string name1)
            {
                no = no1; name = name1;
            }
            public string getstud()
            {
                return string.Format("{0}\t{1}", no, name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Myclass[] st = new Myclass[3];
            int i;
            string mystr="";
            try
            {
                //for (i = 0; i < 3; i++) 加上本for循环就不会出错
                //    st[i] = new Myclass();
                st[0].input(1, "王华");
                st[1].input(3, "曾丽");
                st[2].input(2, "陈山");
                for (i = 0; i < 3; i++)
                    mystr = mystr + st[i].getstud() + "\r\n";
                textBox1.Text = mystr;
            }
            catch (Exception ex)
            {
                string str = ex.Message + "\r\n" + ex.Source + "\r\n" + ex.HelpLink ; 
                MessageBox.Show(str); 
            }
        }
    }
}
