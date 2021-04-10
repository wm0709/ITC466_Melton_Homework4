namespace HW4EX2B4.TightCoupling.Model
{
    public interface IPaymentProcessor
    {
        void ChargeCard(PaymentDetails paymentDetails, decimal amount);

        void CollectCash(decimal amount);
    }
}