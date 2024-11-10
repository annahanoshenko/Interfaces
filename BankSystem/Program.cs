using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentProcessor creditCardPayment = new CreditCardPaymentProcessor("4111112455667777");
            IPaymentProcessor bankAccountPayment = new BankAccountPaymentProcessor("567896");

            creditCardPayment.ProcessPayment(100);
            bankAccountPayment.ProcessPayment(300);
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
