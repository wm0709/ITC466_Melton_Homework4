using System;
using HW4EX2B4.TightCoupling.Services;

namespace HW4EX2B4.TightCoupling.Model
{
    class ReserveInventoryService : IReserveInventory
    {
        public void ReserveInventory(Cart cart)
        {
            foreach (OrderItem item in cart.Items)
            {
                try
                {
                    var inventorySystem = new InventorySystem();
                    inventorySystem.Reserve(item.Sku, item.Quantity);
                }
                catch (InsufficientInventoryException ex)
                {
                    throw new OrderException("Insufficient inventory for item " + item.Sku, ex);
                }
                catch (Exception ex)
                {
                    throw new OrderException("Problem reserving inventory", ex);
                }
            }
        }
    }
}