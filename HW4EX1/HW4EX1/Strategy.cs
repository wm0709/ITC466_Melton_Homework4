using System;
using System.Collections.Generic;
using System.Text;

namespace HW4EX1
{
    public interface IStrategy
    {
        void Order(int quantity, int comboQuantity = 0);
    }
    public class Factory
    {
        public static IOrderBurger CreateBurgerService()
        {
            return new BurgerOrderService();
        }

        public static IOrderFries CreateFrieService()
        {
            return new FriesOrderService();
        }
    }

    public class StrategyBurger : IStrategy
    {
        IOrderBurger orderBurgerService = Factory.CreateBurgerService();

        public void Order(int quantity, int comboQuantity = 0)
        {
            orderBurgerService.orderBurger(quantity);
        }
    }

    public class StrategyFires : IStrategy
    {
        IOrderFries orderFrieService = Factory.CreateFrieService();

        public void Order(int quantity, int comboQuantity = 0)
        {
            orderFrieService.orderFries(quantity);
        }
    }

    public class StrategyCombo : IStrategy
    {
        IOrderBurger orderBurgerService = Factory.CreateBurgerService();
        IOrderFries orderFriesService = Factory.CreateFrieService();

        public void Order(int quantity, int fries)
        {
            orderBurgerService.orderBurger(quantity);
            orderFriesService.orderFries(fries);
        }
    }
}
