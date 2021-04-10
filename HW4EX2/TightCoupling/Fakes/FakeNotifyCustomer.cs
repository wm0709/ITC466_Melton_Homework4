namespace HW4EX2B4.TightCoupling.Model
{
    class FakeNotifyCustomer : INotifyCustomer
    {
        public bool wasCalled = false;

        public void NotifyCustomer(Cart cart)
        {
            wasCalled = true;
        }
    }
}