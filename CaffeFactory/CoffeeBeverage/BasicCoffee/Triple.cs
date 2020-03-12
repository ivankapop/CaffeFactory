namespace CaffeFactory
{
    public class Triple : Espresso
    {
        public override string GetDescription()
        {
            return base.GetDescription() + "Triple portion of espresso";
        }
        public override int Cost()
        {
            return base.Cost() * 3;
        }
    }
}
