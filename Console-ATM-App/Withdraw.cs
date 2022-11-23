using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_ATM_App
{
    static class Withdraw
    {
        
        public static void OnWithdraw()
        {
            while (true)
            {

                Console.WriteLine("You can Withdraw!");
               
                Console.WriteLine();
                Console.WriteLine("Enter 1 to go to the Main Menu");
                Console.WriteLine("Enter 2 to Quit.");
                string? nextAction1 = Console.ReadLine().Trim();


                switch (nextAction1)
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
                if (nextAction1 == "2")
                {
                    
                    break;
                }
            }
        }
    }

    
}
