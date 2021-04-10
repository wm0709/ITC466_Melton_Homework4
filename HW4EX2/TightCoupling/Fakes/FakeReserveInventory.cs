namespace HW4EX2B4.TightCoupling.Model
{
    class FakeReserveInventory : IReserveInventory
    {
        public bool wasCalled = false;

        public void ReserveInventory(Cart cart)
        {
            wasCalled = true;
        }
    }
}