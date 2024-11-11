
using System;

namespace Payment_processing_system
{
    internal class PaymentService 
    {
        public void ProcessAllPayments(IPaymentMethod[] payments)
        {
            foreach (var payment in payments)
            {
                decimal amount = new Random().Next(5, 50);

                if (payment.ProcessPayment(amount))
                {
                    Console.WriteLine(payment.GenerateReceipt());
                }
                else
                {
                    Console.WriteLine("Failed");
                }
            }
        }
    }
}
