using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UseListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //设置显示模式组合框的内容为“详细列表”
            comboBox1.SelectedIndex = 3;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //获取listView1控件中项的数目
            int count = listView1.Items.Count;
            string sex="";
            if(radioButton1.Checked )
                sex=radioButton1 .Text ;
            else 
                sex=radioButton2.Text ;
            string[] subItem = { txtStuNo.Text, txtStuName.Text, sex, txtAddress.Text };
            listView1.Items.Insert(count, new ListViewItem(subItem));
            listView1.Items[count].ImageIndex = 0;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listView1.SelectedItems.Count.ToString ());
            for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
            {
                ListViewItem item = listView1.SelectedItems[i];
                listView1.Items.Remove(item);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = comboBox1.SelectedItem.ToString();
            switch (str)
            {
                case  "大图标":
                    listView1.View = View.LargeIcon;
                    break;
                case "小图标":
                    listView1.View = View.SmallIcon;
                    break ;
                case "列表":
                    listView1.View = View.List;
                    break;
                default :
                    listView1.View = View.Details;
                    break;
            }
        }
        private void listView1_Click(object sender, EventArgs e)
        {
            string str;
            MessageBox.Show("该学生的信息时："+listView1 .SelectedItems [0].SubItems [0].Text +"=="+listView1 .SelectedItems [0].SubItems [1].Text );
            //str = listView1.SelectedItems[0].Text;
            //MessageBox.Show("该学生的学号为："+str);
            //MessageBox.Show("该学生的姓名为：" +listView1 .SelectedItems [0].SubItems [1].Text );
        }

        
    }
}
