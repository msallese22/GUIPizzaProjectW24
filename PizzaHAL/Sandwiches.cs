

namespace PizzaHAL
{
    internal class Sandwiches: Item
    {
        private const String BuffaloChicken = "Buffalo Chicken";
        private const String MediterraneanVeggie = "Mediterranean Veggie";
        private const String PhillyCheeseSteak = "Philly Cheesesteak";
        private const String ChickenParm = "Chicken Parm";


        private const double Price = 5.99;
        private String Flavor;

        public Sandwiches(String Flavor) 
        {
            this.Flavor = Flavor;
        }
        public override String ToString()
        {
            return Flavor + ": $" + Price;
        }

        public static String PrintSandwiches()
        {
            Console.WriteLine("Please select one of our sandwiches for $5.99.");
            Console.WriteLine(BuffaloChicken);
            Console.WriteLine(MediterraneanVeggie);
            Console.WriteLine(PhillyCheeseSteak);
            Console.WriteLine(ChickenParm);

            String input = Console.ReadLine();
            while (!string.Equals(input, BuffaloChicken,StringComparison.OrdinalIgnoreCase) && !string.Equals(input, MediterraneanVeggie, StringComparison.OrdinalIgnoreCase)
                && !string.Equals(input, PhillyCheeseSteak, StringComparison.OrdinalIgnoreCase)
                && !string.Equals(input, ChickenParm, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Invalid input. Please select one of our sandwiches.");
                input = Console.ReadLine();
            }
            return input;
        }
        public override double GetPrice()
        {
            return Price;
        }


    }
}
