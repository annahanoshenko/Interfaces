

namespace Payment_processing_system
{
    public interface IPaymentMethod
    {
        bool ProcessPayment(decimal amount);
        string GenerateReceipt();
    }
}

