using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//利用数据绑定技术，以及DataGridView控件，不需要编写任何代码，即可实现数据库内容的查看
namespace ex1101
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

        }
    }
}
