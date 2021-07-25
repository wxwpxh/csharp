// csc /t:winexe ThreeWinForm.cs
using System ;
using System.Windows.Forms ;
using System.Drawing ;
public class Form3 : Form
{	
	public static void Main( ){
	  Application.Run(new Form3());
	}

	private Label label1 ;
	
	public Form3(){
	  // 建立标签并且初始化
	  this.label1 = new System.Windows.Forms.Label( ) ;
	  //先继承一个Label 类
	  label1.Location = new System.Drawing.Point( 24 , 16 ) ;
	  //设定 Label的显示位置
	  label1.Text = "这是一个WinForm中的标签";
	  label1.Size = new System.Drawing.Size ( 200, 50 );
	  //设定标签的大小
	  label1.TabIndex = 0 ;
	  label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
	  // 设定标签的对齐方式
	  this.Text = "在WinForm中加入一个标签！";
	  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
	} 
	
}