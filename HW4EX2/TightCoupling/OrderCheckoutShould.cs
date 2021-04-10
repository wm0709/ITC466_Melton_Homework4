using HW4EX2B4.TightCoupling.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW4EX2B4.TightCoupling
{
    [TestClass]
    public class OrderCheckoutShould
        
    {
        [TestMethod]
        public void NotFailWithCreditCardPaymenService()
        {

            var reservationService = new FakeReserveInventory();
            var paymentService = new FakePaymentProcessor();
            var notificationService = new FakeNotifyCustomer();
            var paymentDetails = new PaymentDetails() {PaymentMethod = PaymentMethod.CreditCard};

            var cart = new Cart();
            var order = new CreditCardSales(cart,paymentDetails,notificationService,reservationService,paymentService);

            bool shouldnotifycustomer = false;

            order.Checkout(shouldnotifycustomer);

            Assert.IsTrue(paymentService.wasCalled);
        }

        [TestMethod]
        public void NotFailWithNoNotificationCreditCardNotificationService()
        {

            var reservationService = new FakeReserveInventory();
            var paymentService = new FakePaymentProcessor();
            var notificationService = new FakeNotifyCustomer();
            var paymentDetails = new PaymentDetails() { PaymentMethod = PaymentMethod.CreditCard };

            var cart = new Cart();
            var order = new CreditCardSales(cart, paymentDetails, notificationService, reservationService, paymentService);

            bool shouldnotifycustomer = false;

            order.Checkout(shouldnotifycustomer);

            Assert.IsFalse(notificationService.wasCalled);
        }

        [TestMethod]
        public void NotFailWithNotificationCreditCardNotificationService()
        {
            var reservationService = new FakeReserveInventory();
            var paymentService = new FakePaymentProcessor();
            var notificationService = new FakeNotifyCustomer();
            var paymentDetails = new PaymentDetails() { PaymentMethod = PaymentMethod.CreditCard };

            var cart = new Cart();
            var order = new CreditCardSales(cart, paymentDetails, notificationService, reservationService, paymentService);

            bool shouldnotifycustomer = true;

            order.Checkout(shouldnotifycustomer);

            Assert.IsTrue(notificationService.wasCalled);
        }

        [TestMethod]
        public void NotFailWithCreditCardReserveInventory()
        {

            var reservationService = new FakeReserveInventory();
            var paymentService = new FakePaymentProcessor();
            var notificationService = new FakeNotifyCustomer();
            var paymentDetails = new PaymentDetails() { PaymentMethod = PaymentMethod.CreditCard };

            var cart = new Cart();
            var order = new CreditCardSales(cart, paymentDetails, notificationService, reservationService, paymentService);

            bool shouldnotifycustomer = false;

            order.Checkout(shouldnotifycustomer);

            Assert.IsTrue(reservationService.wasCalled);
        }

        [TestMethod]
        public void NotFailWithNoNotificationNoCreditCardNotificationService()
        {
            var reservationService = new FakeReserveInventory();
            var paymentService = new FakePaymentProcessor();
            var notificationService = new FakeNotifyCustomer();
            var paymentDetails = new PaymentDetails() { PaymentMethod = PaymentMethod.Cash };

            var cart = new Cart();
            var order = new CashSales(cart, paymentDetails, notificationService, reservationService, paymentService);

            bool shouldnotifycustomer = false;

            order.Checkout(shouldnotifycustomer);

            Assert.IsFalse(notificationService.wasCalled);
        }

        [TestMethod]
        public void NotFailWithNoCreditCardPaymentService()
        {
            var reservationService = new FakeReserveInventory();
            var paymentService = new FakePaymentProcessor();
            var notificationService = new FakeNotifyCustomer();
            var paymentDetails = new PaymentDetails() { PaymentMethod = PaymentMethod.Cash };

            var cart = new Cart();
            var order = new CashSales(cart, paymentDetails, notificationService, reservationService, paymentService);

            bool shouldnotifycustomer = false;

            order.Checkout(shouldnotifycustomer);

            Assert.IsTrue(paymentService.wasCalled);
        }

        [TestMethod]
        public void NotFailWithNotificationNoCreditCardNotificationService()
        {
            var reservationService = new FakeReserveInventory();
            var paymentService = new FakePaymentProcessor();
            var notificationService = new FakeNotifyCustomer();
            var paymentDetails = new PaymentDetails() { PaymentMethod = PaymentMethod.Cash };

            var cart = new Cart();
            var order = new CashSales(cart, paymentDetails, notificationService, reservationService, paymentService);

            bool shouldnotifycustomer = true;

            order.Checkout(shouldnotifycustomer);

            Assert.IsTrue(notificationService.wasCalled);
        }

        [TestMethod]
        public void NotFailNoCreditCardReserveInventory()
        {
            var reservationService = new FakeReserveInventory();
            var paymentService = new FakePaymentProcessor();
            var notificationService = new FakeNotifyCustomer();
            var paymentDetails = new PaymentDetails() { PaymentMethod = PaymentMethod.Cash };

            var cart = new Cart();
            var order = new CashSales(cart, paymentDetails, notificationService, reservationService, paymentService);

            bool shouldnotifycustomer = true;

            order.Checkout(shouldnotifycustomer);

            Assert.IsTrue(reservationService.wasCalled);
        }
    }
}
