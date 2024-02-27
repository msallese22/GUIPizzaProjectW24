namespace Project2.Models
{
    public class Pizzas : Item
    {
        private String Size;
        private double Price = 0;
        public List<String> Toppings = new List<String>();

        public static String Small = "Small";
        public static String Medium = "Medium";
        public static String Large = "Large";
        public static String XLarge = "Extra-Large";

        public static double SmPrice = 5.99;
        public static double MdPrice = 7.99;
        public static double LgPrice = 9.99;
        public static double XlgPrice = 11.99;

        public static double SmToppings = .50;
        public static double MdToppings = .70;
        public static double LgToppings = .90;
        public static double XlgToppings = 1.00;
        public Pizzas(String Size, List<String> Toppings)//constructor ooo
        {
            this.Size = Size;
            this.Toppings = Toppings;
            if (string.Equals(Size, Small, StringComparison.OrdinalIgnoreCase))
            {
                Price = SmPrice;
                foreach (String s in Toppings)
                {
                    Price += SmToppings;
                }
            }
            else if (string.Equals(Size, Medium, StringComparison.OrdinalIgnoreCase))

            {
                Price = MdPrice;
                foreach (String s in Toppings)
                {
                    Price += MdToppings;
                }
            }
            else if (string.Equals(Size, Large, StringComparison.OrdinalIgnoreCase))
            {
                Price = LgPrice;
                foreach (String s in Toppings)
                {
                    Price += LgToppings;
                }
            }
            else
            {
                Price = XlgPrice;
                foreach (String s in Toppings)
                {
                    Price += XlgToppings;
                }
            }
        }

        public override String ToString()
        {

            if (Toppings.Count > 0)
            {
                return Size + " pizza with cheese, " + String.Join(", ", Toppings) + ": $" + Price.ToString("0.00");

            }
            else
            {
                return Size + " pizza with cheese: $" + Price;
            }
        }
        public override double GetPrice()
        {
            return Price;
        }
    }
}
 
