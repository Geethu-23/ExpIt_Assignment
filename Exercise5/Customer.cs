using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Customer
    {
        
        public  string firstName { get; set; }
        public  string lastName { get; set; }
        public  int SSN { get; set; }
        public  long accountNumber { get; set; }
        public  double currentBalance { get; set; }

        public void PrintName()
        {
            Console.WriteLine(firstName+lastName);
        }

        public abstract void GetCustomerType();

        public abstract void Deposit(double dep);

        public abstract void Withdraw(double ded);

        public void ShowBalance()
        {
            Console.WriteLine(currentBalance);
        }






     }
}
