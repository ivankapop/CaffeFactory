namespace CaffeFactory
{
    public class Water : AddonDecorator
    {
        public Water(CoffeeBeverage decoratedBeverage) : base(decoratedBeverage)
        {
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " More Water, fot You!";
        }
        public override int Cost()
        {
            return DecoratedBeverage.Cost() + 1;
        }
    }
}
