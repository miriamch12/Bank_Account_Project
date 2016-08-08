using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bank_Account_Project
{
    //CHILD CLASS
    class ReserveAccount : Account
    {
        //FIELDS
        private int reserveNumber = 845870280;
        private double reserveBalance = 500500.00;
        private double reserveDeposit = 0.00;
        private double reserveWithdraw = 0.00;

        //PARAMETERS
        public ReserveAccount(double reserveDeposit, double reserveWithdraw)
        { }


        //PROPERTIES
        public int ReserveNumber
        {
            get { return this.reserveNumber; }
        }

        public double ReserveBalance
        {
            get { return this.reserveBalance; }
            set { this.ReserveBalance = value; }
        }

        public double ReserveDeposit
        {
            get { return this.reserveDeposit; }
            set { this.ReserveDeposit = value; }
        }

        public double ReserveWithdraw
        {
            get { return this.reserveWithdraw; }
            set { this.ReserveWithdraw = value; }
        }



        //CONSTRUCTORS

            //RESERVE DEPOSIT
        public override void Deposit(double depositAmount)
        {
            this.reserveDeposit = depositAmount;
            reserveBalance = reserveBalance + depositAmount;
            Console.WriteLine(ReserveBalance);
        }

        //RESERVE WITHDRAW
        public override void Withdraw(double withdrawAmount)
        {
            this.reserveDeposit = withdrawAmount;
            reserveBalance = reserveBalance - withdrawAmount;
            Console.WriteLine(ReserveBalance);
        }

        //RESERVE BALANCE
        public override void Balance()
        {
            Console.Clear();
            Console.WriteLine(ReserveBalance);
        }

        //WRITES RESERVE ACCOUNT SUMMARY TO FILE
        public override void AccountSummary()
        {
            StreamWriter writer = new StreamWriter("Reserve_Account_Summary.txt");
            using (writer)
            {
                StringBuilder summary = new StringBuilder();
                summary.Append("\r\nClient Name: " + clientName);
                summary.Append("\r\nReserve Account Number: " + reserveNumber);
                summary.Append("\r\nAccount Type: Reserve");
                summary.Append("\r\nDeposit Amount: +$" + reserveDeposit);
                summary.Append("\r\nWithdraw Ammount: -$" + reserveWithdraw);
                summary.Append("\r\nReserve Current Balance: $" + reserveBalance);

                DateTime now = DateTime.Now;
                writer.WriteLine(now);
                writer.WriteLine(summary);
            }
        }

        }
}
