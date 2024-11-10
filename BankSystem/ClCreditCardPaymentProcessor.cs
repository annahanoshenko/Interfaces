using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class CreditCardPaymentProcessor : IPaymentProcessor
    {
        public string CardNumber {  get; set; }

        public CreditCardPaymentProcessor(string cardNumber)
        {
            CardNumber = cardNumber;
        }

        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of{amount:C} using card number: {CardNumber}");
        }
    }
}
