using System;
using System.Net.Mail;
using HW4EX2B4.Utility;

namespace HW4EX2B4.TightCoupling.Model
{
    class NotifyCustomerService  : INotifyCustomer
    {
        public void NotifyCustomer(Cart cart)
        {
            string customerEmail = cart.CustomerEmail;
            if (!String.IsNullOrEmpty(customerEmail))
            {
                using (var message = new MailMessage("orders@somewhere.com", customerEmail))
                using (var client = new SmtpClient("localhost"))
                {
                    message.Subject = "Your order placed on " + DateTime.Now;
                    message.Body = "Your order details: \n " + cart;

                    try
                    {
                        client.Send(message);
                    }
                    catch (Exception ex)
                    {
                        Logger.Error("Problem sending notification email", ex);
                        throw;
                    }
                }
            }
        }
    }
}