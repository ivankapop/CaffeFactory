namespace CaffeFactory
{
    public class IceCream : AddonDecorator
    {
        public IceCream(CoffeeBeverage decoratedBeverage) : base(decoratedBeverage)
        {
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " IceCream ";
        }
        public override int Cost()
        {
            return DecoratedBeverage.Cost() + 10;
        }
    }
}
