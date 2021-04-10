using System;
using System.Collections.Generic;
using System.Text;

namespace HW4EX1
{
    class Context
    {
        private IStrategy _strategy;

        public Context() { }

        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void MakeOrder(int quantity, int comboQuantity = 0)
        {
            _strategy.Order(quantity, comboQuantity);
        }


    }
}
