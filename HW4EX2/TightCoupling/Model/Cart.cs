using System.Collections.Generic;

namespace HW4EX2B4.TightCoupling.Model
{
    public class Cart
    {
        public decimal TotalAmount { get; set; }
        public IEnumerable<OrderItem> Items { get; set; }
        public string CustomerEmail { get; set; }

        public Cart()
        {
            this.Items = new List<OrderItem>();
        }
    }
}