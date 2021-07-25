using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace exci16
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

        private void button1_Click(object sender, EventArgs e)
        {
            string xpath = "学生表/学生[民族='汉族']";
            XmlDocument myxmldoc = new XmlDocument();
            myxmldoc.Load("D:\\C#编程题\\ch16\\stud.xml");
            XmlNodeList mynodes = myxmldoc.SelectNodes(xpath);
            textBox1.Text = "";
            foreach (XmlNode item in mynodes)
            {
                textBox1.Text = textBox1.Text + item.Name + ":" + item.InnerText + "\r\n";
            }
        }
    }
}
