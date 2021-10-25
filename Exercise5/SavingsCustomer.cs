using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SavingsCustomer:Customer
    {
        const double Interest = 0.12;
        const double WithdrawlFees = 0.12;

        public override void Deposit(double dep)
        {
            if (dep >= 100)
            {
                dep = dep + Interest;
            }
            currentBalance = currentBalance + dep;
            Console.WriteLine("Deposit+Current Savings Customer Balance: " + currentBalance);
            
        }
        public override void Withdraw(double ded)
        {
            currentBalance = currentBalance - (ded - WithdrawlFees);

            if (currentBalance < 0)
            {
                Console.WriteLine("Zero Balance");
            }
            else
            {

                Console.WriteLine("After withdrawn Current Balance: " + currentBalance);
            }

        }
        public override void GetCustomerType()
        {
            Console.WriteLine("");
        }
    }
}
