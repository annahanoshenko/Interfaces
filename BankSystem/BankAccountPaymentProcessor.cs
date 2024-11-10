using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class BankAccountPaymentProcessor : IPaymentProcessor
    {
        public string AccountNumber {  get; set; }

        public BankAccountPaymentProcessor(string accountNumber)
        {

             AccountNumber = accountNumber; 
        }

        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing bank account payment of {amount:C} using account number {AccountNumber}.");
        }
    }
}
