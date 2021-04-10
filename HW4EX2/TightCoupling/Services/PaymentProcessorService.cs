using System;
using HW4EX2B4.TightCoupling.Services;

namespace HW4EX2B4.TightCoupling.Model
{
    class PaymentProcessorService : IPaymentProcessor
    {
        public void ChargeCard(PaymentDetails paymentDetails, decimal amount)
        {
            using (var paymentGateway = new PaymentGateway())
            {
                try
                {
                    paymentGateway.Credentials = "account credentials";
                    paymentGateway.CardNumber = paymentDetails.CreditCardNumber;
                    paymentGateway.ExpiresMonth = paymentDetails.ExpiresMonth;
                    paymentGateway.ExpiresYear = paymentDetails.ExpiresYear;
                    paymentGateway.NameOnCard = paymentDetails.CardholderName;
                    paymentGateway.AmountToCharge = amount;

                    paymentGateway.Charge();
                }
                catch (AvsMismatchException ex)
                {
                    throw new OrderException("The card gateway rejected the card based on the address provided.", ex);
                }
                catch (Exception ex)
                {
                    throw new OrderException("There was a problem with your card.", ex);
                }
            }
        }

        public void CollectCash(decimal amount)
        {
            decimal cashCollected = amount;
        }
    }
}