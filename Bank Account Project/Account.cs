using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bank_Account_Project
{
   public abstract class Account
    {
        //FIELDS
        protected string clientName = "Spongebob SquarePants";
        protected int accountNumber = 1003245678;
        protected string accountType;
        protected double totalAmount;
        protected double withdrawAmount;
        protected double depositAmount;
       
        


        //PROPERTIES
        public string ClientName
        {
            get { return this.clientName; }
        }

        public int AccountNumber
        {
            get { return this.accountNumber; }
        }

        public double TotalAmount
        {
            get { return this.totalAmount; }
            set { this.totalAmount = value; }
        }

        public double WithdrawAmount
        {
            get { return this.withdrawAmount; }
            set { this.withdrawAmount = value; }
        }

        public double DepositAmount
        {
            get { return this.depositAmount; }
            set { this.depositAmount = value; }
        }





        //CONSTRUCTORS
        public abstract void Withdraw(double withdrawAmount);
        public abstract void Deposit(double depositAmount);
        public abstract void Balance();
        public abstract void AccountSummary();
        public void MainMenu()
        {
            Console.WriteLine("MAIN MENU");
            List<string> menu = new List<string>();
            menu.Add("1. View Client Information");
            menu.Add("2. View Account Balance");
            menu.Add("3. Deposit Funds");
            menu.Add("4. Withdraw Funds");
            menu.Add("5. Exit");
            foreach(string s in menu)
            {
                Console.WriteLine(s);
            }
        }

        public void ViewAccount()
        {
            List<string> balance = new List<string>();
            balance.Add("1. Checking Account Balance");
            balance.Add("2. Reserve Account Balance");
            balance.Add("3. Savings Account Balance");
            foreach (string s in balance)
            {
                Console.WriteLine(s);
            }
        }
        public void DepositFunds()
        {
            List<string> deposit = new List<string>();
            deposit.Add("1. Deposit Funds to Checking");
            deposit.Add("2. Deposit Funds to Reserve");
            deposit.Add("3. Deposit Funds to Savings");
            foreach (string s in deposit)
            {
                Console.WriteLine(s);
            }

        }

        public void WithdrawFunds()
        {
            List<string> withdraw = new List<string>();
            withdraw.Add("1. Withdraw Funds from Checking");
            withdraw.Add("2. Withdraw Funds from Reserve");
            withdraw.Add("3. Withdraw Funds from Savings");
            foreach(string s in withdraw)
            {
                Console.WriteLine(s);
            }
        }
        
        public void clientInformation()
        {
            Console.WriteLine("NAME: SPONGEBOB SQUAREPANTS");
            Console.WriteLine("ADDRESS: 124 CONCH ST, BIKINI BOTTOM");
            Console.WriteLine("SEX: M");
            Console.WriteLine("DOB: 07-14-86");
            
        }
        
      
                  





             
    }
}
