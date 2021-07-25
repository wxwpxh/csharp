using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace doTransaction
{
    class Account       // 帐户类
    {
        private Object thisLock = new Object();
        int balance;
        Random rnd = new Random();      // 准备生成随机数
        public Account(int initial)     // 帐户构造函数
        {
            balance = initial;
        }
        int withDraw(int amount)    // 从帐户中取款
        {
            if (balance < 0)      // 本条件永远不会为True，除非注释掉lock语句
            {
                throw new Exception("帐户余额不足（<=0）！");
            }
            lock (thisLock)
            {
                if (balance >= amount)
                {
                    Console.WriteLine("取款前账户余额：" + balance);
                    Console.WriteLine("取款额(-)        ：-" + amount);
                    balance = balance - amount;
                    Console.WriteLine("取款后帐户余额：" + balance);
                    return amount;
                }
                else
                {
                    return 0;          // 拒绝交易
                }
            }
        }
        public void DoTransactions()        // 执行交易DoTransactions()
        { // 从帐户中取50次钱款，每次取款额为1~100中的随机数
            for (int i = 0; i < 50; i++)
            {
                withDraw(rnd.Next (1,100));
            }
        }
    }
}
