namespace CaffeFactory
{
    public class Espresso : CoffeeBeverage
    {
       
        public override string GetDescription()
        {
           
            return base.GetDescription() + " Espresso";
        }
        public override int Cost()
        {
            return base.Cost() + 15;
        }
    }
}
