using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace study10_14线程1
{
    class Account//模拟银行账户
    {
        private object thisLock = new object();//为互斥锁准备对象
        int balance;//银行余额
        public Account(int initial)//构造函数传初始的金额
        {
            this.balance = initial;//初始化银行账户余额
        }
        public void Withdraw(object amount)//从账户中取款
        {
            lock (thisLock)//进入互斥线锁
            {
                if (balance >= (int)amount)//账户余额 > 取款余额
                {
                    Thread.Sleep(500);
                    balance = balance - (int)amount;//账户余额 - 取款金额
                    Console.WriteLine("{0}操作成功,余额={1}", Thread.CurrentThread.Name, balance);
                }
                else
                {
                    Console.WriteLine("{0}操作失败,账户余额不足，余额={1}", Thread.CurrentThread.Name, balance);
                }

            }
        }
    }

    class Lock互斥锁
    {
        static void pMain(string[] args)
        {

            Account acc = new Account(1000);//创建新的账户对象，余额1000元

            Thread t1 = new Thread(acc.Withdraw);
            t1.Name = "小明";
            Thread t2 = new Thread(acc.Withdraw);
            t2.Name = "小红";

            t1.Start(600);//取款
            t2.Start(600);//取款

            Console.ReadKey();
        }
    }
}
