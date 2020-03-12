namespace CaffeFactory
{
    public abstract class AddonDecorator : CoffeeBeverage
    {
        protected CoffeeBeverage DecoratedBeverage { get; set; }

        public AddonDecorator(CoffeeBeverage decoratedBeverage)
        {
            DecoratedBeverage = decoratedBeverage;
        }

        public override int Cost()
        {            
            return DecoratedBeverage.Cost();
        }

        public override string GetDescription()
        {   
            return DecoratedBeverage.GetDescription();
        }
    }
}