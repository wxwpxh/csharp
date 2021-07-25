using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*创建Windows窗体应用程序，在程序启动时将数据选项添加到组合框ComboBox1中（不允许以交互方式输入另外的选项），
 单击列表中的任一选项之后，在标签控件label1中显示出自己最喜欢的一位运动员。*/
namespace ex7_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "您最喜爱的运动员是：\n\n    " + comboBox1.Text;
        }
        private void Form1_Load(object sender, EventArgs e)
        {										//禁止在文本编辑框输入数据的组合框样式
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.MaxDropDownItems = 8;		//下拉列表中最多允许显示8个选项
            string[] item = { "郭晶晶", "吴敏霞", "庞伟", "姚明", "刘翔" };
            for (int i = 0; i < item.Length; i++)
                comboBox1.Items.Add(item[i]);		//把数据选项逐个添加到组合框的列表中
            string[] newitem = { "张怡宁", "王楠", "王浩", "马林", "张宁" };
            comboBox1.Items.AddRange(newitem);		//把一个数组整体添加到组合框的列表中
        }

    }
}
