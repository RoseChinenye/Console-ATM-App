using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_ATM_App
{
    static class CheckBalance
    {
        

            public static void OnCheckBalance()
            {
                

                while (true)
                {

                    Console.WriteLine("You can Check Balance!");

                    Console.WriteLine();
                    Console.WriteLine("Enter 1 to go to the Main Menu");
                    Console.WriteLine("Enter 2 to Quit.");
                    string? nextAction2 = Console.ReadLine().Trim();


                    switch (nextAction2)
                    {
                        case "1":
                            BankATM.Next();
                            break;

                        case "2":
                            Console.WriteLine("Thank you for banking with us!");
                            break;

                        default:
                            Console.WriteLine("Please enter 1 or 2 ");
                            break;

                    }
                    if (nextAction2 == "2")
                    {
                        break;
                    }
                }

        }
        
    }
}
