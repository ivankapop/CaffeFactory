using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeFactory
{
    public class Chocolate : AddonDecorator
    {
        public Chocolate(CoffeeBeverage decoratedBeverage) : base(decoratedBeverage)
        {
        }
        public override string GetDescription()
        {
            return base.GetDescription() + "tasty chocolate";
        }
        public override int Cost()
        {
            base.Cost();
            return DecoratedBeverage.Cost() + 5;
        }
    }
}
