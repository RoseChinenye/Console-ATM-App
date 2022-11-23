using System;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Transactions;


namespace Console_ATM_App
{
    static class BankATM
    {

        static string? Userinput;

        public static void Starter()
        {
            Console.WriteLine("Welcome to GTBank ATM!");
            Console.WriteLine();
            Next();
        }

        public static void Next()
        {

            while (true)
            {
                Console.WriteLine("Enter 1 to Check balance");
                Console.WriteLine("Enter 2 to Withdraw");
                Console.WriteLine("Enter 3 to Transfer");
                Console.WriteLine("Enter 4 to Quit: ");

                string? transaction = Console.ReadLine().Trim();

                switch (transaction)
                {
                    case "1":
                        CheckBalance.OnCheckBalance();
                        break;

                    case "2":
                        Withdraw.OnWithdraw();
                        break;

                    case "3":
                        Transfer.OnTransfer();
                        break;

                    case "4":
                        Console.WriteLine("Thank you for banking with us!");
                        break;


                    default:
                        Console.WriteLine("Please enter 1, 2 or 3 ");
                        break;

                }
                if (transaction == "4")
                {
                    Userinput = "2";
                    break;
                }

            }

        }



    }
    
}