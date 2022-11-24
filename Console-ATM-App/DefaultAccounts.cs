using System;


namespace Console_ATM_App
{
    internal class DefaultAccounts
    {
        private static int _cardNumber = 1020304050;
        private static int _pin = 1234;
        private List<TransactionsDetails> transactions = new List<TransactionsDetails>();

        public string Number { get; }
        public string Pin { get; }
        public string AccountName { get; }

        private double Balance
        {
            get
            {
                double AccountBalance = 5000.00;
                foreach (var item in transactions)
                {
                    AccountBalance += item.Amount;
                }
                return AccountBalance;
            }
        }
       
        public DefaultAccounts(string accountName)
        {
            AccountName = accountName;
            Number = _cardNumber.ToString();
            Pin = _pin.ToString();
            _cardNumber++;
            _pin++;
        }

        public void Transfer(double amount, DateTime date, string statement, string recieverDetails)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Cannot make a zero amount withdrawal");
            }
            else if (Balance - amount < 0)
            {
                Console.WriteLine("Insufficient balance...");
            }
            else
            {
                TransactionsDetails transfer = new TransactionsDetails(-amount);
                transactions.Add(transfer);
                Console.WriteLine($"Successful: {amount} has been transfered to {recieverDetails}");

            }

        }

        public void Checkbalance()
        {
            Console.WriteLine($"Available Balance: {Balance}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount.");
            }
            else if (Balance - amount < 0)
            {
                Console.WriteLine("Insufficient balance...");
            }
            else
            {
                TransactionsDetails withdrawal = new TransactionsDetails(-amount);
                transactions.Add(withdrawal);
                Console.WriteLine($"Transaction Successful!");
            }

        }
    }
}

