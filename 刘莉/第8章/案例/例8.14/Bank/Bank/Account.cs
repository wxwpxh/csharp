using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Bank
{
    class Account
    {
        private Object obj = new Object();  // 用于上锁
        int balance;        // 余额
        Random r = new Random();
        BankForm form1;
        public Account(int initial, BankForm frm)
        {
            this.form1 = frm;
            this.balance = initial;
        }
        //取款
        public int Withdraw(int amount)     // amount为要取的钱数
        {
            if (balance < 0)
            {
                form1.AddListBoxItme("余额为：" + balance + "  余额已经是负数了，不能再取！");
            }
            lock (obj)      // 上锁
            {
                if (balance >= amount)
                {
                    string str = Thread.CurrentThread.Name + "取款-----";
                    str += string.Format("取款钱余额为：{0,-6}取款：", balance, amount);
                    balance = balance - amount;
                    str += "取款后余额为：" + balance.ToString ();
                    form1.AddListBoxItme(str);
                    return amount;
                }
                else
                {
                    return 0;
                }
            }
        }
        //自动取款
        public void DoTransactions()
        {
            for (int i = 0; i < 5; i++)
            {
                Withdraw(r.Next(1, 6));
            }
        }
    }
}
