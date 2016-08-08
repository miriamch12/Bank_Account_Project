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

            CheckingAccount check = new CheckingAccount(0,0);
            ReserveAccount reserve = new ReserveAccount(0, 0);
            SavingsAccount save = new SavingsAccount(0, 0);

            int answer;
            List<int> numbAnswer = new List<int>();

            do {
                
                Console.Clear();
            check.MainMenu();
                 answer = int.Parse(Console.ReadLine());
                

                switch (answer)
                {
                    case 1:
                        Console.Clear();
                        check.clientInformation();
                        break;
                    case 2:
                        Console.Clear();
                        check.ViewAccount();
                        int accountAnswer = int.Parse(Console.ReadLine());
                        switch (accountAnswer)
                        {
                            case 1:
                                Console.Clear();
                                check.Balance();
                               
                                break;
                            case 2:
                                Console.Clear();
                                reserve.Balance();
                                break;
                            case 3:
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
                        Console.WriteLine("Deposit Amount");
                        double depAmmount = double.Parse(Console.ReadLine());
                        
                        switch (depositAnswer)
                        {
                            case 1:
                                Console.Clear();
                                check.Deposit(depAmmount);                            
                                break;
                            case 2:
                                Console.Clear();
                                reserve.Deposit(depAmmount);
                                break;
                            case 3:
                                Console.Clear();
                                save.Deposit(depAmmount);
                                break;
                            default:
                                break;
                        }
                        break;
                    case 4:
                        Console.Clear();
                        check.WithdrawFunds();
                        int withdrawAnswer = int.Parse(Console.ReadLine());
                        numbAnswer.Add(withdrawAnswer);
                        Console.WriteLine("Withdraw Ammount");
                        double withAmmount = double.Parse(Console.ReadLine());
                        switch (withdrawAnswer)
                        {
                            case 1:
                                Console.Clear();
                                check.Withdraw(withAmmount);
                                break;
                            case 2:
                                Console.Clear();
                                reserve.Withdraw(withAmmount);
                                break;
                            case 3:
                                Console.Clear();
                                save.Withdraw(withAmmount);
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Goodbye");
                        break;

                             
                }
                Console.WriteLine("\n\n\n\n\n1. Main Menu");
                Console.WriteLine("2. Exit");
                
                int option = int.Parse(Console.ReadLine());
                if (option == 2)
                {
                    answer = 5;
                }

               

            }
            while (answer != 5);
          
            check.AccountSummary();
            reserve.AccountSummary();
            save.AccountSummary();
                

                
            
           

        }
    }
}
