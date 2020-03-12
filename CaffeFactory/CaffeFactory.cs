using System;

namespace CaffeFactory
{
    public class CaffeFactory
    {
        static void Main(string[] args)
        {
            CoffeeBeverage coffee = null;

            WriteCoffeeList();
            while (!ReadCoffee(out coffee))
            {
                WriteCoffeeList();
            }

            AddonDecorator addon = null;

            while (true)
            {
                WriteAddonList();
                if (ReadAddon(coffee, out addon) && addon == null)
                {
                    break;
                }
                coffee = addon;
            }

            Console.WriteLine();
            Console.WriteLine(coffee.GetDescription() + " with cost - " + coffee.Cost());
            Console.ReadLine();
        }

        private static void WriteCoffeeList()
        {
            Console.WriteLine("Choose COFFEE");
            Console.WriteLine("1 - Espresso");
            Console.WriteLine("2 - Dopio");
            Console.WriteLine("3 - Triple");
        }
        private static bool ReadCoffee(out CoffeeBeverage coffee)
        {
            string position = Console.ReadLine();
            coffee = null;

            if (int.TryParse(position, out int number))
            {
                switch (number)
                {
                    case 1:
                        coffee = new Espresso();
                        break;
                    case 2:
                        coffee = new Dopio();
                        break;
                    case 3:
                        coffee = new Triple();
                        break;
                    default:
                        return false;
                }
                return true;
            }
            return false;
        }
        private static void WriteAddonList()
        {
            Console.WriteLine("Add Addon to you coffee:");
            Console.WriteLine("1 - Caramel");
            Console.WriteLine("2 - Milk");
            Console.WriteLine("3 - Water");
            Console.WriteLine("4 - IceCream");
            Console.WriteLine("5 - Chocolate");
            Console.WriteLine("0 - No addon");
        }

        private static bool ReadAddon(CoffeeBeverage coffee, out AddonDecorator addon)
        {
            string position = Console.ReadLine();
            int number = 0;
            addon = null;

            if (int.TryParse(position, out number))
            {
                switch (number)
                {
                    case 0:                     
                        break;
                    case 1:
                        addon = new Caramel(coffee);
                        break;
                    case 2:
                        addon = new Milk(coffee);
                        break;
                    case 3:
                        addon = new Water(coffee);
                        break;
                    case 4:
                        addon = new IceCream(coffee);
                        break;
                    case 5:
                        addon = new Chocolate(coffee);
                        break;
                    default:
                        return false;
                }
                return true;
            }
            return false;

        }
    }
}
