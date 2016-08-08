using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bank_Account_Project
{
    //CHILD CLASS
    class SavingsAccount : Account
    {
        //FIELDS
        private int savingsNumber = 882958272;
        private double savingsBalance = 1000000.00;
        private double savingsDeposit = 0.00;
        private double savingsWithdraw = 0.00;

        //PARAMETERS
        public SavingsAccount(double savingsDeposit, double savingsWithdraw)
        { }


        //PROPERTIES

        public int SavingsNumber
        {
            get { return this.savingsNumber; }
        }

        public double SavingsBalance
        {
            get { return this.savingsBalance; }
            set { this.SavingsBalance = value; }
        }

        public double SavingsDeposit
        {
            get { return this.savingsDeposit; }
            set { this.SavingsDeposit = value; }
        }

        public double SavingsWithdraw
        {
            get { return this.savingsWithdraw; }
            set { this.SavingsWithdraw = value; }
        }

        //SAVINGS DEPOSIT
        public override void Deposit(double depositAmount)
        {
            Console.Clear();
            this.savingsDeposit = depositAmount;
            savingsBalance = savingsBalance + depositAmount;
            Console.WriteLine(SavingsBalance);
        }

        //SAVINGS WITHDRAW
        public override void Withdraw(double withdrawAmount)
        {
            Console.Clear();
            this.savingsDeposit = withdrawAmount;
            savingsBalance = savingsBalance - withdrawAmount;
            Console.WriteLine(SavingsBalance);
        }

        //SAVINGS BALANCE
        public override void Balance()
        {
            Console.Clear();
            Console.WriteLine(SavingsBalance);
        }

        //WRITES SAVINGS ACCOUNT SUMMARY TO FILE
        public override void AccountSummary()
        {
            StreamWriter writer = new StreamWriter("Savings_Account_Summary.txt");
            using (writer)
            {
                StringBuilder summary = new StringBuilder();
                summary.Append("\r\nClient Name: " + clientName);
                summary.Append("\r\nSavings Account Number: " + savingsNumber);
                summary.Append("\r\nAccount Type: Savings");
                summary.Append("\r\nDeposit Amount: +$" + savingsDeposit);
                summary.Append("\r\nWithdraw Ammount: -$" + savingsWithdraw);
                summary.Append("\r\nSavings Current Balance: $" + savingsBalance);
                DateTime now = DateTime.Now;

                writer.WriteLine(now);
                writer.WriteLine(summary);

            }
        }


    }
}
