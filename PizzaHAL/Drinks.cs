

namespace PizzaHAL
{
    internal class Drinks: Item

    {
        private String Size;
        private double Price = 0;
        private String Flavor;
        private String Ice;
        private const String Dynamite = "Dr. Dynamite";
        private const String Thunder = "Dr. Thunder";
        private const String LemonLime = "Lemon Lime";
        private const String MtnLightning = "Mountain Lightning";
        private const String MrPibb = "Mr. Pibb";
        private const String Dew = "7 Dew";

        private const double SmPrice = 1.19;
        private const double MdPrice = 1.59;
        private const double LgPrice = 1.99;

        private const String Small = "Small";
        private const String Medium = "Medium";
        private const String Large = "Large";

        private const String RegIce = "Regular";
        private const String ExtraIce = "Extra";
        private const String NoIce = "None";

        public Drinks(String Flavor, String Size, String Ice)
        { 
            this.Flavor = Flavor;
            this.Size = Size;
            this.Ice = Ice;

            if (string.Equals(Size, Small, StringComparison.OrdinalIgnoreCase))
            {
                Price = SmPrice;
            }
            else if (string.Equals(Size, Medium, StringComparison.OrdinalIgnoreCase))
            {
                Price = MdPrice;
            }
            else
            {
                Price = LgPrice;
            }
        }
        public override String ToString()
        {
            return Size + " " + Flavor + " with "+ Ice + " ice: $" + Price;
        }

        public static String[] PrintDrinks()
        {
            String[] CustomerChoices=new String[3];
            Console.WriteLine("Please select one of our drinks.");
            Console.WriteLine(Dynamite);
            Console.WriteLine(Thunder);
            Console.WriteLine(LemonLime);
            Console.WriteLine(MtnLightning);
            Console.WriteLine(MrPibb);
            Console.WriteLine(Dew);
            
            String input = Console.ReadLine();
            while (!string.Equals(input, Dynamite, StringComparison.OrdinalIgnoreCase) && !string.Equals(input, Thunder, StringComparison.OrdinalIgnoreCase) && !string.Equals(input, LemonLime, StringComparison.OrdinalIgnoreCase)
                && !string.Equals(input, MtnLightning, StringComparison.OrdinalIgnoreCase) && !string.Equals(input, MrPibb, StringComparison.OrdinalIgnoreCase) && !string.Equals(input, Dew, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Invalid input. Please select one of our drinks.");
                input = Console.ReadLine();
            }
            Console.WriteLine("You have chosen: " + input + "! Please choose what size drink you'd like.");
            
            CustomerChoices[0] = input;

            Console.WriteLine(Small + ": $" + SmPrice);
            Console.WriteLine(Medium + ": $" + MdPrice);
            Console.WriteLine(Large + ": $" + LgPrice);

            Console.WriteLine("Enter \"Small\" for 12oz, \"Medium\" for 16oz, or \"Large\" for 20oz.");
            input = Console.ReadLine();
            while (!string.Equals(input, Small, StringComparison.OrdinalIgnoreCase) && !string.Equals(input, Medium, StringComparison.OrdinalIgnoreCase) && !string.Equals(input, Large, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Invalid input. Please select a size.");
                input = Console.ReadLine();
            }
            Console.WriteLine("You have chosen: " + input + ". Please select your ice level.");
            CustomerChoices[1] = input;

            Console.WriteLine(RegIce);
            Console.WriteLine(NoIce);
            Console.WriteLine(ExtraIce);

            input = Console.ReadLine();
            while (!string.Equals(input, RegIce, StringComparison.OrdinalIgnoreCase) && !string.Equals(input, NoIce, StringComparison.OrdinalIgnoreCase) && !string.Equals(input, ExtraIce, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Invalid input. Please select your ice level.");
                input = Console.ReadLine();
            }
            Console.WriteLine("You have chosen: " + input);
            CustomerChoices[2] = input;

            return CustomerChoices;
        }

        public override double GetPrice()
        {
            return Price;
        }
    }
}
