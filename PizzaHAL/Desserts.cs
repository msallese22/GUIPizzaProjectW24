

namespace PizzaHAL
{
    internal class Desserts: Item
    {
        private double Price = 0;
        private String Flavor;
        private const String Tiramisu = "Tiramisu";
        private const String CookieBrownie = "Cookie Brownie";
        private const String ChocolateChipCookie = "Chocolate Chip Cookie";

        private const double TiramisuPrice = 4.99;
        private const double CookieBrowniePrice = 6.49;
        private const double ChocolateChipCookiePrice = 2.49;

       

        public Desserts(String Flavor)
        {
            this.Flavor = Flavor;
            if (string.Equals(Flavor, Tiramisu, StringComparison.OrdinalIgnoreCase))
            {
                Price = TiramisuPrice;
            }
            else if (string.Equals(Flavor, CookieBrownie, StringComparison.OrdinalIgnoreCase))
            {
                Price = CookieBrowniePrice;
            }
            else if (string.Equals(Flavor, ChocolateChipCookie, StringComparison.OrdinalIgnoreCase))
            {
                Price = ChocolateChipCookiePrice;
            }
        }

        public override String ToString()
        {
            return Flavor + ": $" + Price;
        }

        public static String PrintDesserts()
        {
            Console.WriteLine("Please make a selection from our desserts.");
            Console.WriteLine(Tiramisu + ": $" + TiramisuPrice);
            Console.WriteLine(CookieBrownie + ": $" +CookieBrowniePrice);
            Console.WriteLine(ChocolateChipCookie + ": $" +ChocolateChipCookiePrice);
            String input = Console.ReadLine();
            while (!string.Equals(input, Tiramisu, StringComparison.OrdinalIgnoreCase) && !string.Equals(input, CookieBrownie, StringComparison.OrdinalIgnoreCase) && !string.Equals(input, ChocolateChipCookie, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Invalid input. Please make a selection from our desserts.");
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


