using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_ATM_App
{
    internal class TransactionsDetails
    {
        
        public double Amount { get; }
        public DateTime Date { get; }
        public string Statement { get; set; }

        public TransactionsDetails(double amount)
        {
            Amount = amount;
            
        }
    }
}
