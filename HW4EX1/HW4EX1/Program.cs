using System;

namespace HW4EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();

            Console.WriteLine("Burger Only Order");
            context.SetStrategy(new StrategyBurger());
            context.MakeOrder(5);

            Console.WriteLine();

            Console.WriteLine("Frie Only Order");
            context.SetStrategy(new StrategyFires());
            context.MakeOrder(10);

            Console.WriteLine();

            Console.WriteLine("Combo Order");
            context.SetStrategy(new StrategyCombo());
            context.MakeOrder(5, 10);
        }
    }


    interface IOrder
    {
        void orderBurger(int quantity);
        void orderFries(int fries);
        void orderCombo(int quantity, int fries);
    }

    public interface IOrderBurger
    {
        void orderBurger(int quantity);
    }

    public interface IOrderFries
    {
        void orderFries(int fries);
    }

    public class BurgerOrderService : IOrderBurger
    {
        public void orderBurger(int quantity)
        {
            Console.WriteLine($"Received order for {quantity} burgers");
        }
    }

    public class FriesOrderService : IOrderFries
    {
        public void orderFries(int fries)
        {
            Console.WriteLine($"Received order for {fries} fries");
        }
    }
}
