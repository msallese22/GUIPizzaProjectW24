namespace Project2.Models
{
    public class Desserts : Item
    {
        private double Price = 0;
        private String Flavor;
        public static String Tiramisu = "Tiramisu";
        public static String CookieBrownie = "Cookie Brownie";
        public static String ChocolateChipCookie = "Chocolate Chip Cookie";

        public static double TiramisuPrice = 4.99;
        public static double CookieBrowniePrice = 6.49;
        public static double ChocolateChipCookiePrice = 2.49;



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
        public override double GetPrice()
        {
            return Price;
        }
    }
}
