
namespace Payment_processing_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentMethod[] paymentMethods = new IPaymentMethod[]
            {

                new CreditCardPayments("1234 5678 9876 5432", "John Doe "),
                new DigitalWalletPaymentProcessor(12340976)
           
            };

            PaymentService payment = new PaymentService();
            payment.ProcessAllPayments(paymentMethods);


        }
    }
}
