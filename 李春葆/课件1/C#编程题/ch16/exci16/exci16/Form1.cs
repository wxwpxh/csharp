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
            string xpath = "学生表/学生[学号='6']";
            XmlDocument myxmldoc = new XmlDocument();
            myxmldoc.Load("D:\\C#编程题\\ch16\\stud.xml");
            XmlNode mynode = myxmldoc.SelectSingleNode(xpath);
            XmlNodeList childnodes = mynode.ChildNodes; //获取子节点集
            textBox1.Text = "";
            foreach (XmlNode item in childnodes)
            {
                textBox1.Text = textBox1.Text + item.Name + ":" + item.InnerText + "\r\n";
            }
        }
    }
}
