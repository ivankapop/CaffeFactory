namespace CaffeFactory
{
    public abstract class CoffeeBeverage
    {
        public virtual int Cost()
        {
            return 0;
        }

        public virtual string GetDescription()
        {
            return "Your order:";
        }
    }

}