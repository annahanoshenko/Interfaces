
namespace Payment_processing_system
{
    public class CreditCardPayments : IPaymentMethod
    {
        private string CardNumber;
        private string CardHolderName;
        private decimal LastTransactionAmount;

        public CreditCardPayments(string cardNumber, string cardHolderName)
        {
            CardHolderName = cardHolderName;
            cardNumber = CardNumber;

        }

        public bool ProcessPayment(decimal amount)
        {
            if (amount > 0)
            {
                LastTransactionAmount = amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GenerateReceipt()
        {
            return $"Card: {CardHolderName}, {CardNumber}, suma: {LastTransactionAmount}";
        }
    }
       
}
