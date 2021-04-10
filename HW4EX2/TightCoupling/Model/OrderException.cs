using System;

namespace HW4EX2B4.TightCoupling.Model
{
    public class OrderException : Exception
    {
        public OrderException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}