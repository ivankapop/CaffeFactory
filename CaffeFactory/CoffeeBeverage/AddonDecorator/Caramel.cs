namespace CaffeFactory
{
    public class Caramel : AddonDecorator
    {
        public Caramel(CoffeeBeverage decoratedBeverage) : base(decoratedBeverage)
        {
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " Caramel ";
        }

        public override int Cost()
        {
            return DecoratedBeverage.Cost() + 3;
        }
    }
}
