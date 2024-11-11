using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_processing_system
{
    internal class DigitalWalletPaymentProcessor : IPaymentMethod
    {
        private int WalletId;
        private double LastTransactionAmount;

        public DigitalWalletPaymentProcessor(int walletId)
        {
            WalletId = walletId;
        }

        public bool ProcessPayment(decimal amount)
        {
            if(amount > 10)
            {
                return true;
            }
            else
            {
                return false;
            }
   
        }

        public string GenerateReceipt()
        {
            return $"Card: {WalletId}, suma: {LastTransactionAmount}";
        }
    }
}
