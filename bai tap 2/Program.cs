using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_2
{
    class  Account
    {
        private string id;
        private string name;
        private int balance;
    
    public Account(string id,string name,int balance)
    {
        this.id = id;
        this.name = name;
        this.balance = balance;
    }
        public string getid()
        {
            return id;
        }
        public string getname()
        {
            return name;
        }
        public int getbalance()
        {
            return balance;
        }
        public void credit(int amount)
        {
            if(balance>0)
            balance += amount; 
        }
        public void debit(int amount)
        {
            if(amount>0)
            balance -= amount;
        }
        public void tranferTo(Account acc ,int amount)
        {
            if(balance >0)
            balance -= amount;
            acc.balance += amount;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Account my = new Account("12345678910", "TuanLuuDan", 4000);
                Account myfriend = new Account("789123456", "TuThuocNo", 2000);

                Console.WriteLine("------Thông Tin Tài Khoảng Ban Đầu------");
                Console.WriteLine("my account:[id:{0},name:{1},balance:{2}]",
                    my.getid(), my.getname(), my.getbalance());
                Console.WriteLine("------Thông Tin Tài Khoảng Ban Đầu:[id{0},name{1},balance{2} ",
                    myfriend.getid(), myfriend.getname(), myfriend.getbalance());
                Console.WriteLine("------------------------------------------------");
                // rut tiền 
                my.debit(2000);
                myfriend.tranferTo(my,1000);

                Console.WriteLine("------Thông Tin Tài Khoảng sau khi thực hiện giao dịch------");
                Console.WriteLine("my friend account:[id:{0},name:{1},balance:{2} ",
                   my.getid(), my.getname(), my.getbalance());

                Console.WriteLine("------Thông Tin Tài Khoảng SAu:[id{0},name{1},balance{2} ",
                    myfriend.getid(), myfriend.getname(), myfriend.getbalance());
                Console.ReadKey();
            }
        }
    }
}
