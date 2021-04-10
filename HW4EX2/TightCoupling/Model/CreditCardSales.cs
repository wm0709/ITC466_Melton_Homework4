using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4EX2B4.TightCoupling.Model
{
    class CreditCardSales : Order
    {
        public CreditCardSales(Cart cart, PaymentDetails paymentDetails, INotifyCustomer notifyCustomer, IReserveInventory reserveInventory, IPaymentProcessor paymentProcessor) : base(cart, paymentDetails, notifyCustomer, reserveInventory, paymentProcessor)
        {
        }

        public override void Checkout(bool notifyCustomer)
        {
            if (_paymentDetails.PaymentMethod == PaymentMethod.CreditCard)
            {
                _paymentProcessor.ChargeCard(_paymentDetails, _cart.TotalAmount);
            }

            _reserveInventory.ReserveInventory(_cart);

            if (notifyCustomer)
            {
                _notifyCustomer.NotifyCustomer(_cart);
            }
        }
    }
}
