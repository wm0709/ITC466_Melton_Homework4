namespace HW4EX2B4.TightCoupling.Model
{
    class FakePaymentProcessor : IPaymentProcessor
    {
        public decimal amountPassed = 0;
        public bool wasCalled = false;

        public void ChargeCard(PaymentDetails paymentDetails, decimal amount)
        {
            wasCalled = true;
            amountPassed = amount;

        }

        public void CollectCash(decimal amount)
        {
            wasCalled = true;
            amountPassed = amount;
        }
    }
}