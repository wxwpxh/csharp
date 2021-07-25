using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace experment10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Indent = 20;
            treeView1.Nodes.Add("哺乳动物");
            treeView1.Nodes[0].Nodes.Add("豹子");
            treeView1.Nodes[0].Nodes.Add("老虎");
            treeView1.Nodes[0].Nodes.Add("北极熊");
            treeView1.Nodes[0].Nodes.Add("狼");
            treeView1.Nodes[0].Nodes.Add("大象");
            treeView1.Nodes[0].Nodes.Add("犀牛");
            treeView1.Nodes.Add("鱼类");
            treeView1.Nodes[1].Nodes.Add("鲨鱼");
            treeView1.Nodes[1].Nodes.Add("热带鱼");
            treeView1.Nodes[1].Nodes.Add("金鱼");
            treeView1.Nodes.Add("鸟类");
            treeView1.Nodes[2].Nodes.Add("天鹅");
            treeView1.Nodes[2].Nodes.Add("猫头鹰");
            treeView1.Nodes[2].Nodes.Add("翠鸟");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string s;
            s = e.Node.Text;
            listView1.Items.Clear();
            listView1.LargeImageList = imageList1;
            listView1.SmallImageList = imageList2;
            switch (s)
            {
                case "哺乳动物":
                    listView1.Items.Add("豹子", 0);
                    listView1.Items.Add("老虎", 0);
                    listView1.Items.Add("北极熊", 0);
                    listView1.Items.Add("狼", 0);
                    listView1.Items.Add("大象", 0);
                    listView1.Items.Add("犀牛", 0);
                    break;
                case "鱼类":
                    listView1.Items.Add("鲨鱼", 0);
                    listView1.Items.Add("热带鱼", 0);
                    listView1.Items.Add("金鱼", 0);
                    break;
                case "鸟类":
                    listView1.Items.Add("天鹅", 0);
                    listView1.Items.Add("猫头鹰", 0);
                    listView1.Items.Add("翠鸟", 0);
                    break;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menu1_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void menu2_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void menu3_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void menu4_Click(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }
    }
}
