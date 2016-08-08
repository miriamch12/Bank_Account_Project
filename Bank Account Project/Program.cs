using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bank_Account_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //OBJECTS INSTANTIATED FROM THE CHECKING, RESERVE AND SAVINGS ACCOUNT CLASS
            CheckingAccount check = new CheckingAccount(0,0);
            ReserveAccount reserve = new ReserveAccount(0, 0);
            SavingsAccount save = new SavingsAccount(0, 0);

            int answer;

            do {
                
                Console.Clear();
                //MAIN MENTU
                 check.MainMenu();
                 answer = int.Parse(Console.ReadLine());
                
                //SWITCH OPTIONS FOR MAIN MENUE
                switch (answer)
                {
                    case 1:
                        Console.Clear();
                        //CLIENT INFORMATION
                        check.clientInformation();
                        break;
                    case 2:
                        Console.Clear();
                        //VIEW ACCOUNT
                        check.ViewAccount();
                        int accountAnswer = int.Parse(Console.ReadLine());
                        //SWITCH FOR BALANCE
                        switch (accountAnswer)
                        {
                            case 1:
                                //CHECKING BALANCE
                                Console.Clear();
                                check.Balance();
                               
                                break;
                            case 2:
                                //RESERVE BALANCE
                                Console.Clear();
                                reserve.Balance();
                                break;
                            case 3:
                                //SAVINGS BALANCE
                                Console.Clear();
                                save.Balance();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 3:
                        Console.Clear();
                        check.DepositFunds();
                        int depositAnswer = int.Parse(Console.ReadLine());

                        //GIVES MAIN MENU/EXIT OPTION IF USER INPUTS INVALID NUMBER
                        if(depositAnswer < 4)
                        {                       
                        Console.WriteLine("Deposit Amount");
                        double depAmount = double.Parse(Console.ReadLine());
                            //SWITCH FOR DEPOSIT
                            switch (depositAnswer)
                            {
                                case 1:
                                    //CHECKING DEPOSIT AMOUNT
                                    Console.Clear();
                                    check.Deposit(depAmount);
                                    break;
                                case 2:
                                    //RESERVE DEPOSIT AMOUNT
                                    Console.Clear();
                                    reserve.Deposit(depAmount);
                                    break;
                                case 3:
                                    //SAVINGS DEPOSIT AMOUNT
                                    Console.Clear();
                                    save.Deposit(depAmount);
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case 4:
                        Console.Clear();
                        check.WithdrawFunds();
                        int withdrawAnswer = int.Parse(Console.ReadLine());

                        //GIVES MAIN MENU/EXIT OPTION IF USER INPUTS INVALID NUMBER
                        if (withdrawAnswer < 3)
                        {                                   
                        Console.WriteLine("Withdraw Amount");
                        double withAmount = double.Parse(Console.ReadLine());
                            //SWITCH FOR WITHDRAW AMOUNT
                            switch (withdrawAnswer)
                            {
                                case 1:
                                    //CHECKING WITHDRAW AMOUNT
                                    Console.Clear();
                                    check.Withdraw(withAmount);
                                    break;
                                case 2:
                                    //RESERVE WITHDRAW AMOUNT
                                    Console.Clear();
                                    reserve.Withdraw(withAmount);
                                    break;
                                case 3:
                                    //SAVINGS WITHDRAW AMOUNT
                                    Console.Clear();
                                    save.Withdraw(withAmount);
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Goodbye");
                        break;                           
                }

                if (answer != 5)
                {
                    //ALLOWS USER TO GO BACK TO MAIN MENU OR EXIT
                    Console.WriteLine("\n\n\n\n\n1. Main Menu");
                    Console.WriteLine("2. Exit");

                    int option = int.Parse(Console.ReadLine());
                    if (option == 2)
                    {
                        Console.WriteLine("Goodbye");
                        answer = 5;
                    }
                }
            }
            while (answer < 5);   
            //WRITES CHECKING ACCOUNT SUMMARY TO FILE       
            check.AccountSummary();
            //WRITES RESERVE ACCOUNT SUMMARY TO FILE
            reserve.AccountSummary();
            //WRITES SAVINGS ACCOUNT SUMMARY TO FILE
            save.AccountSummary();                                           
        }
    }
}
