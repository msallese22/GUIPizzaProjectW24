
namespace PizzaHAL
{
    internal class VegetarianPizzas: Item
    {
        private const String Small = "Small";
        private const String Medium = "Medium";
        private const String Large = "Large";
        private const String XLarge = "Extra-Large";

        private const String Peppers = "Peppers";
        private const String Pineapple = "Pineapple";
        private const String Mushrooms = "Mushrooms";
        private const String Done = "Done";

        private const double SmPrice = 5.99;
        private const double MdPrice = 7.99;
        private const double LgPrice = 9.99;
        private const double XlgPrice = 11.99;

        private const double SmToppings = .50;
        private const double MdToppings = .70;
        private const double LgToppings = .90;
        private const double XlgToppings = 1.00;

        private String Size;
        private double Price = 0;
        public List<String> Toppings = new List<String>();
        public VegetarianPizzas(String Size, List<String> Toppings)//constructor ooo
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
            else if(string.Equals(Size, Medium, StringComparison.OrdinalIgnoreCase))
            
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
                return Size + " pizza with vegetarian cheese, " + String.Join(", ", Toppings) + ": $" + Price.ToString("0.00");
            }
            else
            {
                return Size + " pizza with vegetarian cheese: $" + Price;
            }
        }

        public static (String, List<String>) PrintVegetarianPizzas()
        {
            String ChosenSize = "";
            Console.WriteLine("We also value our vegetarian customers and provide a meatless cheese alternative." + Environment.NewLine +"Please pick which size vegetarian cheese pizza you'd like. A Small is 10 inches, a Medium is 12 inches, " +Environment.NewLine +
                "a Large is 14 inches, and an Extra-Large is 16 inches.");
            String input = Console.ReadLine();
            while (!string.Equals(input, Small, StringComparison.OrdinalIgnoreCase) && !string.Equals(input, Medium, StringComparison.OrdinalIgnoreCase)
                && !string.Equals(input, Large, StringComparison.OrdinalIgnoreCase) && !string.Equals(input, XLarge, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Invalid input. Please pick which size pizza you'd like.");
                input = Console.ReadLine();
            }
            ChosenSize = input;

            Console.WriteLine("What toppings would you like to add? Please say \"Done\" when you are finished to add the item to the cart.");
            Console.WriteLine(Pineapple);
            Console.WriteLine(Mushrooms);
            Console.WriteLine(Peppers);
            input = Console.ReadLine();
            List<String> ChosenToppings = new List<String>();
            while (!string.Equals(input, Done, StringComparison.OrdinalIgnoreCase))
            {
                while (!string.Equals(input, Pineapple, StringComparison.OrdinalIgnoreCase) && !string.Equals(input, Mushrooms, StringComparison.OrdinalIgnoreCase) && !string.Equals(input, Peppers, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Invalid input. Please select a topping or say \"Done\" if you are done.");
                    input = Console.ReadLine();
                }
                ChosenToppings.Add(input);
                Console.WriteLine("Add more toppings? Enter your next topping or say \"Done\" to be done and add the item to your cart.");
                input = Console.ReadLine();
            }
            return (ChosenSize, ChosenToppings);

        }
        public override double GetPrice()
        {
            return Price;
        }



    }
}
    
