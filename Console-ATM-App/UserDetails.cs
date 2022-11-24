using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_ATM_App
{
    internal class UserDetails
    {
        private static List<DefaultAccounts> ExistingAccounts = new List<DefaultAccounts>();
           

        public static void Starter()
        {
            DefaultAccounts First = new DefaultAccounts("Chinenye");
            DefaultAccounts Second = new DefaultAccounts("Rose");
            DefaultAccounts Third = new DefaultAccounts("Akin");

            ExistingAccounts.Add(First);
            ExistingAccounts.Add(Second);
            ExistingAccounts.Add(Third);

            DefaultAccounts user = new DefaultAccounts("test");
            bool _login = false;


            void Entry()
            {
                Console.WriteLine("...............Welcome to THBank ATM!................ ");
                Console.WriteLine(".....Kindly Enter your Card Number and Pin to run a transaction......");
                Console.WriteLine();    

                Console.Write("Card Number: ");
                var CardNumber = Console.ReadLine();

                Console.Write("Pin: ");
                var Pin = Console.ReadLine();

                foreach (var input in ExistingAccounts)
                {
                    if (input.Number == CardNumber && input.Pin == Pin)
                    {
                        user = input;
                        _login = true;
                        Transaction(user);
                    }
                }
                if (!_login)
                {
                    Console.WriteLine("This Account doesn't exist in THBank!");
                    Entry();
                }
            }
            if (!_login)
            {
                Entry();
            }

            void Transaction(DefaultAccounts owner)
            {

                DateTime date = DateTime.Now;

                Console.WriteLine("Enter 1 to withdraw");
                Console.WriteLine("Enter 2 to Check balance");
                Console.WriteLine("Enter 3 to Transfer");
                Console.WriteLine("Enter 4 for Account Statement");
                Console.WriteLine("Enter 5 to Quit"); 

                var selection = Console.ReadLine();


                if (int.TryParse(selection, out int userInput))
                {
                    switch (userInput)
                    {
                        case 1:
                            Console.WriteLine("Please enter amount: ");
                            var amount = Console.ReadLine();

                            if (double.TryParse(amount, out double amountInput))
                            {
                                owner.Withdraw(amountInput);
                                owner.Checkbalance();
                                Transaction(owner);
                            }
                            else
                            {
                                Console.WriteLine("Transaction failed!");
                                Transaction(owner);
                            }
                            break;

                        case 2:
                            owner.Checkbalance(); Transaction(owner); 
                            break;

                        case 3:
                            Console.WriteLine("Please enter amount");
                            var transferAmount = Console.ReadLine();

                            Console.WriteLine("Please enter account number");
                            var recieverAccount = Console.ReadLine();

                            Console.WriteLine("Please enter message");
                            var message = Console.ReadLine();

                            if (double.TryParse(transferAmount, out double transferAmountInput))
                            {
                                owner.Transfer(transferAmountInput, date, message, recieverAccount);
                                Transaction(owner);
                            }
                            else
                            {
                                Transaction(owner);
                            }
                            break;

                        case 4: Transaction(owner); 
                            break;

                        case 5:
                            Entry();
                            Transaction(owner);
                            _login = false;
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Your input appears to be invalid, please try a numeric value");
                    Transaction(owner);
                }
            }
            Transaction(user);

        }
    }
}


