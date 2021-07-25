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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string xpath = "/学生表/学生[last()]";
            XmlDocument myxmldoc = new XmlDocument();
            myxmldoc.Load("D:\\C#编程题\\ch16\\stud.xml");
            XmlNode mynode = myxmldoc.SelectSingleNode(xpath);
            XmlNode newnode = myxmldoc.CreateNode(XmlNodeType.Element, "学生", null);
            newnode.InnerXml = "<学号>10</学号><姓名>孙武</姓名><性别>男</性别><民族>汉族</民族><班号>07002</班号>";
            mynode.ParentNode.InsertAfter(newnode, mynode);
            textBox1.Text = newnode.InnerText;
            myxmldoc.Save("D:\\C#编程题\\ch16\\stud1.xml");
        }
    }
}
