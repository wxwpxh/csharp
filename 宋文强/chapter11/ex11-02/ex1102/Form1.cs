using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//利用数据绑定技术，以及文本框、图片框和标签控件，仅编写少量代码，即可实现数据库内容的查看、添加、删除、修改和保存，并且可以查看相关联的图片
namespace ex1102
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 学生基本情况表BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.学生基本情况表BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“studentDataSet.学生基本情况表”中。您可以根据需要移动或移除它。
            this.学生基本情况表TableAdapter.Fill(this.studentDataSet.学生基本情况表);
            pictureBox1.Load(@"images\" + 学号TextBox.Text + ".jpg");
        }

        private void 学号TextBox_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Load(@"images\" + 学号TextBox.Text + ".jpg");

        }
    }
}
