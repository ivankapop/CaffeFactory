namespace CaffeFactory
{
    public class Milk : AddonDecorator
    {
        public Milk(CoffeeBeverage decoratedBeverage) : base(decoratedBeverage)
        {
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " Fresh milk ";
        }
        public override int Cost()
        {
            return DecoratedBeverage.Cost() + 7;
        }
    }
}
