namespace Project2.Models
{
    public class Sandwiches : Item
    {
        public static String BuffaloChicken = "Buffalo Chicken";
        public static String MediterraneanVeggie = "Mediterranean Veggie";
        public static String PhillyCheeseSteak = "Philly Cheesesteak";
        public static String ChickenParm = "Chicken Parm";

        public static double Price = 5.99;
        private String Flavor;

        public Sandwiches(String Flavor)
        {
            this.Flavor = Flavor;
        }
        public override double GetPrice()
        {
            return Price;
        }
        public override String ToString()
        {
            return Flavor + ": $" + Price;
        }


    }
}
