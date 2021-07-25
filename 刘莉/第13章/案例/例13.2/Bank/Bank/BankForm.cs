using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading ;

namespace Bank
{
    public partial class BankForm : Form
    {
        public BankForm()
        {
            InitializeComponent();
        }
        delegate void AddListBoxItemDelegate(string str);
        public void AddListBoxItme(string str)
        {
            if (listBox1.InvokeRequired)
            {
                AddListBoxItemDelegate d = AddListBoxItme;
                listBox1.Invoke(d, str);
            }
            else
            {
                listBox1.Items.Add(str);
            }
        }
       private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();     // 情况列表内容
            Thread[] threads = new Thread[6];
           // 定义账户，初始款项为1000元
            Account acc = new Account(1000, this);
            for (int i = 1; i < 6; i++)
            {
                Thread t = new Thread(acc.DoTransactions);
                t.Name = "用户" + i.ToString();
                threads[i] = t;
            }
            for (int i = 1; i < 6; i++)
            {
                threads[i].Start();
            }
        }
    }
}
