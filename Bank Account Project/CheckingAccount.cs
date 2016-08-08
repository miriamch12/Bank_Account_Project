using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bank_Account_Project
{
    //CHILD CLASS
    class CheckingAccount : Account
    {
        
        //FIELDS
        private int checkingNumber = 243958209;
        private double checkingBalance = 5000000.00;
        private double checkingDeposit = 0.00;
        private double checkingWithdraw = 0.00;

        //PARAMETERS
        public CheckingAccount(double checkingDeposit, double checkingWithdraw)
        { }


        //PROPERTIES
        public int CheckingNumber
        {
            get { return this.checkingNumber; }
        }

        public double CheckingBalance
        {
            get { return this.checkingBalance; }
            set { this.CheckingBalance = value; }
        }

        public double CheckingDeposit
        {
            get { return this.checkingDeposit; }
            set { this.CheckingDeposit = value; }
        }

        public double CheckingWithdraw
        {
            get { return this.checkingWithdraw; }
            set { this.CheckingWithdraw = value; }
        }



        //CONSTRUCTORS

        //CHECKING DEPOSIT
        public override void Deposit(double depositAmount)
        {
            Console.Clear();
            this.checkingDeposit = checkingDeposit + depositAmount;
            checkingBalance = checkingBalance + depositAmount;
            Console.WriteLine(CheckingBalance);
        }
        
        //CHECKING WITHDRAW
        public override void Withdraw(double withdrawAmount)
        {
            Console.Clear();
            this.checkingWithdraw = checkingWithdraw + withdrawAmount;
            checkingBalance = checkingBalance - withdrawAmount;
            Console.WriteLine(CheckingBalance);
        }

        //CHECKING BALANCE
        public override void Balance()
    {
            Console.Clear();
        Console.WriteLine(CheckingBalance);
    }

        //WRITES CHECKING ACCOUNT SUMMARY TO FILE
        public override void AccountSummary()
        {
            StreamWriter writer = new StreamWriter("Checking_Account_Summary.txt");

            using (writer)
            {
                StringBuilder summary = new StringBuilder();
                summary.Append("\r\nClient Name: " + clientName);               
                summary.Append("\r\nChecking Account Number: " + checkingNumber);
                summary.Append("\r\nAccount Type: Checking");
                summary.Append("\r\nDeposit Amount: +$" + checkingDeposit);
                summary.Append("\r\nWithdraw Ammount: -$" + checkingWithdraw);
                summary.Append("\r\nChecking Current Balance: $" + checkingBalance);

                DateTime now = DateTime.Now;               
                writer.WriteLine(now);
                writer.WriteLine(summary);               
            }
        }
    }
}
