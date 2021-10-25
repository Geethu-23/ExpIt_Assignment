using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CheckingCustomer : Customer
    {
        public override void Deposit(double dep)
        {
            currentBalance = currentBalance + dep;
            Console.WriteLine("Deposit+Current Balance: "+ currentBalance);
        }
        public override void Withdraw(double ded) {
            currentBalance = currentBalance - (ded - WithdrawlFees);
            
            Console.WriteLine("After withdrawn Current Balance: "+ currentBalance);

        }
        public void IsOverDrafted(double currentBalance)
        {
            
            if (currentBalance <= 0)
            {
                Console.WriteLine("Yes overdrafted! True");
            }
            else
            {
                Console.WriteLine("Not overdrafted! False");
            }

        }
        public override void GetCustomerType()
        {
            Console.WriteLine("");
        }

     

        const double WithdrawlFees = 0.01;
        static void Main(string[] args)
        {

            CheckingCustomer cc = new CheckingCustomer();

            //Customer mysavingcust = new SavingsCustomer();
            

            cc.firstName = "Geetha";
            cc.lastName = "Anand";
            cc.PrintName();

            cc.SSN = 765-43-2170;
            cc.accountNumber = 3456298756;
            cc.currentBalance = 0;

            cc.GetCustomerType();
           // cc.Withdraw(1000.00);

            Console.WriteLine("Please enter the deposit amount of Checking Customer : ");
            int checkingdeposit = Convert.ToInt32(Console.ReadLine());
            cc.Deposit(checkingdeposit);

            Console.WriteLine("Please enter  withdraw  amount : ");
            int Withdraw = Convert.ToInt32(Console.ReadLine());
            cc.Withdraw(Withdraw);

            cc.IsOverDrafted(cc.currentBalance);

            Console.WriteLine("Please enter the deposit amount of savings customer : ");
            int savingsdeposit = Convert.ToInt32(Console.ReadLine());
            cc.Deposit(savingsdeposit);


            Console.WriteLine("Please enter the withdraw amount of savings customer : ");
            int savingswithdraw = Convert.ToInt32(Console.ReadLine());
            cc.Withdraw(savingswithdraw);

        }

    }
}
