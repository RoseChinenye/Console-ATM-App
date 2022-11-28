
namespace Console_ATM_App
{
    internal class TransactionsDetails
    {
        
        public double Amount { get; }
        public DateTime Date { get; }

        public TransactionsDetails(double amount)
        {
            Amount = amount;
            
        }
    }
}
