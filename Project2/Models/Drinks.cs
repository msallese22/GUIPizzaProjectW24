namespace Project2.Models
{
    public class Drinks : Item
    {
        private String Size;
        private double Price = 0;
        private String Flavor;
        private String Ice;

        public static String Dynamite = "Dr. Dynamite";
        public static String Thunder = "Dr. Thunder";
        public static String LemonLime = "Lemon Lime";
        public static String MtnLightning = "Mountain Lightning";
        public static String MrPibb = "Mr. Pibb";
        public static String Dew = "7 Dew";

        public static double SmPriceD = 1.19;
        public static double MdPriceD = 1.59;
        public static double LgPriceD = 1.99;

        public static String SmallD = "Small";
        public static String MediumD = "Medium";
        public static String LargeD = "Large";

        public static String RegIce = "Regular";
        public static String ExtraIce = "Extra";
        public static    String NoIce = "None";

        public Drinks(String Flavor, String Size, String Ice)
        {
            this.Flavor = Flavor;
            this.Size = Size;
            this.Ice = Ice;

            if (string.Equals(Size, SmallD, StringComparison.OrdinalIgnoreCase))
            {
                Price = SmPriceD;
            }
            else if (string.Equals(Size, MediumD, StringComparison.OrdinalIgnoreCase))
            {
                Price = MdPriceD;
            }
            else
            {
                Price = LgPriceD;
            }
        }
        public override String ToString()
        {
            return Size + " " + Flavor + " with " + Ice + " ice: $" + Price;
        }
        public override double GetPrice()
        {
            return Price;
        }
    }
}
