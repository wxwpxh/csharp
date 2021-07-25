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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string xpath = "学生表/学生[班号='07001']";
            XmlDocument myxmldoc = new XmlDocument();
            myxmldoc.Load("D:\\C#编程题\\ch16\\stud.xml");
            XmlNodeList mynodes = myxmldoc.SelectNodes(xpath);
            textBox1.Text = "07001班学生人数：" + mynodes.Count.ToString();
        }
    }
}
