//csc binarytree.cs
using System;

public class Node{                                           // 定义二叉树节点类 Node
	public int Data;
	public Node Left;
	public Node Right;
	
	public void Display(){
            Console.WriteLine(Data);
    }
    
	public Node(int x){
            Data = x;
    }
}

public class BinaryTree{              // 定义二叉树
	public Node Current;             // 
	Node Parent;                     // 定义一个 Parent，用于存储当前节点（Current）的父节点，为添加删除节点方法做准备
	public Node Root;                // 定义根结点

	public BinaryTree(){              // 构造函数，初始化二叉树
		Root = null;
	}

	public void InOrder(Node theRoot){            // 通过递归，中序遍历
	if (theRoot != null){
		InOrder(theRoot.Left);
		Console.Write(theRoot.Data + "\t");
		InOrder(theRoot.Right);
		}
	}


	public void PreOrder(Node theRoot){          // 通过递归，先序遍历
		if (theRoot != null){
			Console.Write(theRoot.Data + "\t");
			PreOrder(theRoot.Left);
			PreOrder(theRoot.Right);
        }
	}


	public void PostOrder(Node theRoot)        // 通过递归，后序遍历

        {

            if (theRoot != null)

            {

                PostOrder(theRoot.Left);

                PostOrder(theRoot.Right);

                Console.Write(theRoot.Data+"\t");

            }

        }

        public void Insert(int x)                  // 插入节点

        {

            Node newNode = new Node(x);

            Current = Root;

 

            if (Root == null)

            {

                Root = newNode;

            }

            else

            {

                while (true)

                {

                    Parent = Current;

                    if (x < Current.Data)

                    {

                        Current = Current.Left;

                        if (Current == null)

                        {

                            Parent.Left = newNode;

                            break;

                        }

                    }

                    else

                    {

                        Current = Current.Right;

                        if (Current == null)

                        {

                            Parent.Right = newNode;

                            break;

                        }

                    }

                }

            }

        }

        public int Min()              // 查找最小值

        {

            Current = Root;

            while (Current.Left != null)

                Current = Current.Left;

            return Current.Data;

        }

        public int Max()              // 查找最大值

        {

            Current = Root;

            while (Current.Right != null)

                Current = Current.Right;

            return Current.Data;

        }

        public Node Find(int key)     // 查找某一个确定的节点的值

        {

            Current = Root;

 

            while (Current != null)

            {

 

                if (key == Current.Data)

                    break;               // 找到了就结束 while 循环

                if (key < Current.Data)

                {

                    Parent = Current;

                    Current = Current.Left;

                }

                else

                {

                    Parent = Current;

                    Current = Current.Right;

                }

            }

            if (Current == null)

                return null;

            else

                return Current;

        }

      

}


class Program{

        static void Main(string[] args)
        {
            BinaryTree bst = new BinaryTree();
            bst.Insert(25);
            bst.Insert(50);
            bst.Insert(15);
            bst.Insert(33);
            bst.Insert(4);
            bst.Insert(100);
            bst.Insert(20);
            bst.Insert(38);
            bst.Insert(1);
            bst.Insert(10);
            bst.Insert(18);
            bst.Insert(30);
            bst.Insert(32);

            Console.WriteLine("The min is: {0}", bst.Min());
            Console.WriteLine("The max is: {0}", bst.Max());
            Console.Write("Find \"100\": ");
            Console.Write(bst.Find(100).Data+"\n");

            
            Console.WriteLine("\n" + "PreOrder: ");
            bst.PreOrder(bst.Root);

            Console.WriteLine("\n" +"PostOrder:");
            bst.PostOrder(bst.Root);

            Console.WriteLine("\n"+"InOrder: ");
            bst.InOrder(bst.Root);

            Console.Read();

        }

}
