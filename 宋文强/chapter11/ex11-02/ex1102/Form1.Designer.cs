namespace ex1102
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label 学号Label;
            System.Windows.Forms.Label 姓名Label;
            System.Windows.Forms.Label 性别Label;
            System.Windows.Forms.Label 籍贯Label;
            System.Windows.Forms.Label 专业Label;
            System.Windows.Forms.Label 出生年月Label;
            System.Windows.Forms.Label 高考成绩Label;
            this.studentDataSet = new ex1102.StudentDataSet();
            this.学生基本情况表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.学生基本情况表TableAdapter = new ex1102.StudentDataSetTableAdapters.学生基本情况表TableAdapter();
            this.tableAdapterManager = new ex1102.StudentDataSetTableAdapters.TableAdapterManager();
            this.学生基本情况表BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.学生基本情况表BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.学号TextBox = new System.Windows.Forms.TextBox();
            this.姓名TextBox = new System.Windows.Forms.TextBox();
            this.性别TextBox = new System.Windows.Forms.TextBox();
            this.籍贯TextBox = new System.Windows.Forms.TextBox();
            this.专业TextBox = new System.Windows.Forms.TextBox();
            this.出生年月TextBox = new System.Windows.Forms.TextBox();
            this.高考成绩TextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            学号Label = new System.Windows.Forms.Label();
            姓名Label = new System.Windows.Forms.Label();
            性别Label = new System.Windows.Forms.Label();
            籍贯Label = new System.Windows.Forms.Label();
            专业Label = new System.Windows.Forms.Label();
            出生年月Label = new System.Windows.Forms.Label();
            高考成绩Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生基本情况表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生基本情况表BindingNavigator)).BeginInit();
            this.学生基本情况表BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentDataSet
            // 
            this.studentDataSet.DataSetName = "StudentDataSet";
            this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 学生基本情况表BindingSource
            // 
            this.学生基本情况表BindingSource.DataMember = "学生基本情况表";
            this.学生基本情况表BindingSource.DataSource = this.studentDataSet;
            // 
            // 学生基本情况表TableAdapter
            // 
            this.学生基本情况表TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ex1102.StudentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.学生基本情况表TableAdapter = this.学生基本情况表TableAdapter;
            // 
            // 学生基本情况表BindingNavigator
            // 
            this.学生基本情况表BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.学生基本情况表BindingNavigator.BindingSource = this.学生基本情况表BindingSource;
            this.学生基本情况表BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.学生基本情况表BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.学生基本情况表BindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.学生基本情况表BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.学生基本情况表BindingNavigatorSaveItem});
            this.学生基本情况表BindingNavigator.Location = new System.Drawing.Point(0, 104);
            this.学生基本情况表BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.学生基本情况表BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.学生基本情况表BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.学生基本情况表BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.学生基本情况表BindingNavigator.Name = "学生基本情况表BindingNavigator";
            this.学生基本情况表BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.学生基本情况表BindingNavigator.Size = new System.Drawing.Size(432, 25);
            this.学生基本情况表BindingNavigator.TabIndex = 0;
            this.学生基本情况表BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 12);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // 学生基本情况表BindingNavigatorSaveItem
            // 
            this.学生基本情况表BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.学生基本情况表BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("学生基本情况表BindingNavigatorSaveItem.Image")));
            this.学生基本情况表BindingNavigatorSaveItem.Name = "学生基本情况表BindingNavigatorSaveItem";
            this.学生基本情况表BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.学生基本情况表BindingNavigatorSaveItem.Text = "保存数据";
            this.学生基本情况表BindingNavigatorSaveItem.Click += new System.EventHandler(this.学生基本情况表BindingNavigatorSaveItem_Click);
            // 
            // 学号Label
            // 
            学号Label.AutoSize = true;
            学号Label.Location = new System.Drawing.Point(8, 11);
            学号Label.Name = "学号Label";
            学号Label.Size = new System.Drawing.Size(35, 12);
            学号Label.TabIndex = 1;
            学号Label.Text = "学号:";
            // 
            // 学号TextBox
            // 
            this.学号TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生基本情况表BindingSource, "学号", true));
            this.学号TextBox.Location = new System.Drawing.Point(49, 7);
            this.学号TextBox.Name = "学号TextBox";
            this.学号TextBox.Size = new System.Drawing.Size(100, 21);
            this.学号TextBox.TabIndex = 2;
            this.学号TextBox.TextChanged += new System.EventHandler(this.学号TextBox_TextChanged);
            // 
            // 姓名Label
            // 
            姓名Label.AutoSize = true;
            姓名Label.Location = new System.Drawing.Point(174, 11);
            姓名Label.Name = "姓名Label";
            姓名Label.Size = new System.Drawing.Size(35, 12);
            姓名Label.TabIndex = 3;
            姓名Label.Text = "姓名:";
            // 
            // 姓名TextBox
            // 
            this.姓名TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生基本情况表BindingSource, "姓名", true));
            this.姓名TextBox.Location = new System.Drawing.Point(215, 7);
            this.姓名TextBox.Name = "姓名TextBox";
            this.姓名TextBox.Size = new System.Drawing.Size(100, 21);
            this.姓名TextBox.TabIndex = 4;
            // 
            // 性别Label
            // 
            性别Label.AutoSize = true;
            性别Label.Location = new System.Drawing.Point(8, 44);
            性别Label.Name = "性别Label";
            性别Label.Size = new System.Drawing.Size(35, 12);
            性别Label.TabIndex = 5;
            性别Label.Text = "性别:";
            // 
            // 性别TextBox
            // 
            this.性别TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生基本情况表BindingSource, "性别", true));
            this.性别TextBox.Location = new System.Drawing.Point(49, 40);
            this.性别TextBox.Name = "性别TextBox";
            this.性别TextBox.Size = new System.Drawing.Size(27, 21);
            this.性别TextBox.TabIndex = 6;
            // 
            // 籍贯Label
            // 
            籍贯Label.AutoSize = true;
            籍贯Label.Location = new System.Drawing.Point(97, 44);
            籍贯Label.Name = "籍贯Label";
            籍贯Label.Size = new System.Drawing.Size(35, 12);
            籍贯Label.TabIndex = 7;
            籍贯Label.Text = "籍贯:";
            // 
            // 籍贯TextBox
            // 
            this.籍贯TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生基本情况表BindingSource, "籍贯", true));
            this.籍贯TextBox.Location = new System.Drawing.Point(138, 40);
            this.籍贯TextBox.Name = "籍贯TextBox";
            this.籍贯TextBox.Size = new System.Drawing.Size(54, 21);
            this.籍贯TextBox.TabIndex = 8;
            // 
            // 专业Label
            // 
            专业Label.AutoSize = true;
            专业Label.Location = new System.Drawing.Point(213, 44);
            专业Label.Name = "专业Label";
            专业Label.Size = new System.Drawing.Size(35, 12);
            专业Label.TabIndex = 9;
            专业Label.Text = "专业:";
            // 
            // 专业TextBox
            // 
            this.专业TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生基本情况表BindingSource, "专业", true));
            this.专业TextBox.Location = new System.Drawing.Point(254, 40);
            this.专业TextBox.Name = "专业TextBox";
            this.专业TextBox.Size = new System.Drawing.Size(61, 21);
            this.专业TextBox.TabIndex = 10;
            // 
            // 出生年月Label
            // 
            出生年月Label.AutoSize = true;
            出生年月Label.Location = new System.Drawing.Point(8, 75);
            出生年月Label.Name = "出生年月Label";
            出生年月Label.Size = new System.Drawing.Size(59, 12);
            出生年月Label.TabIndex = 11;
            出生年月Label.Text = "出生年月:";
            // 
            // 出生年月TextBox
            // 
            this.出生年月TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生基本情况表BindingSource, "出生年月", true));
            this.出生年月TextBox.Location = new System.Drawing.Point(73, 72);
            this.出生年月TextBox.Name = "出生年月TextBox";
            this.出生年月TextBox.Size = new System.Drawing.Size(76, 21);
            this.出生年月TextBox.TabIndex = 12;
            // 
            // 高考成绩Label
            // 
            高考成绩Label.AutoSize = true;
            高考成绩Label.Location = new System.Drawing.Point(174, 75);
            高考成绩Label.Name = "高考成绩Label";
            高考成绩Label.Size = new System.Drawing.Size(59, 12);
            高考成绩Label.TabIndex = 13;
            高考成绩Label.Text = "高考成绩:";
            // 
            // 高考成绩TextBox
            // 
            this.高考成绩TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.学生基本情况表BindingSource, "高考成绩", true));
            this.高考成绩TextBox.Location = new System.Drawing.Point(239, 72);
            this.高考成绩TextBox.Name = "高考成绩TextBox";
            this.高考成绩TextBox.Size = new System.Drawing.Size(76, 21);
            this.高考成绩TextBox.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(337, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 129);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(高考成绩Label);
            this.Controls.Add(this.高考成绩TextBox);
            this.Controls.Add(出生年月Label);
            this.Controls.Add(this.出生年月TextBox);
            this.Controls.Add(专业Label);
            this.Controls.Add(this.专业TextBox);
            this.Controls.Add(籍贯Label);
            this.Controls.Add(this.籍贯TextBox);
            this.Controls.Add(性别Label);
            this.Controls.Add(this.性别TextBox);
            this.Controls.Add(姓名Label);
            this.Controls.Add(this.姓名TextBox);
            this.Controls.Add(学号Label);
            this.Controls.Add(this.学号TextBox);
            this.Controls.Add(this.学生基本情况表BindingNavigator);
            this.Name = "Form1";
            this.Text = "数据源与公共控件的绑定";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生基本情况表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.学生基本情况表BindingNavigator)).EndInit();
            this.学生基本情况表BindingNavigator.ResumeLayout(false);
            this.学生基本情况表BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource 学生基本情况表BindingSource;
        private ex1102.StudentDataSetTableAdapters.学生基本情况表TableAdapter 学生基本情况表TableAdapter;
        private ex1102.StudentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator 学生基本情况表BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton 学生基本情况表BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox 学号TextBox;
        private System.Windows.Forms.TextBox 姓名TextBox;
        private System.Windows.Forms.TextBox 性别TextBox;
        private System.Windows.Forms.TextBox 籍贯TextBox;
        private System.Windows.Forms.TextBox 专业TextBox;
        private System.Windows.Forms.TextBox 出生年月TextBox;
        private System.Windows.Forms.TextBox 高考成绩TextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

