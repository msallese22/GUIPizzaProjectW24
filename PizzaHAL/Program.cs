/*
 * Name: Michaela
 * South Hills Username: mpartsch01
 */


namespace PizzaHAL
{
    public class Program
    {
        public const String Cart = "Cart";
        public const String PickUp = "Pick Up";
        public const String Delivery = "Delivery";
        public static void Main()
        {
            SelectCategory();
        }
        public static void SelectCategory()
        {
            List<Item> Itemize = new List<Item>();
            Console.WriteLine("Welcome to PizzaHal! Please choose a category. Say \"Cart\" when " +
                "you're ready to view your cart and check out.");
            Categories.PrintCategories();
            String input = Console.ReadLine();
            Item currentItem = null;
            bool DeterminedSoups = false;
            while (!string.Equals(input,Cart, StringComparison.OrdinalIgnoreCase))
            {
                while (!string.Equals(input, Categories.Pizzas,StringComparison.OrdinalIgnoreCase) && !string.Equals(input, Categories.VegetarianPizzas, StringComparison.OrdinalIgnoreCase)
                    && !string.Equals(input, Categories.Sandwiches, StringComparison.OrdinalIgnoreCase)&& !string.Equals(input, Categories.Soups, StringComparison.OrdinalIgnoreCase)
                    && !string.Equals(input, Categories.Desserts, StringComparison.OrdinalIgnoreCase) && !string.Equals(input, Categories.Drinks, StringComparison.OrdinalIgnoreCase)
                    && !string.Equals(input, Cart, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Sorry, I don't know what you're trying to say. Please choose a category or say \"Cart\" to" +
                        "view your cart to check out.");
                    input = Console.ReadLine();
                }
                if (string.Equals(input, Categories.Pizzas, StringComparison.OrdinalIgnoreCase))
                {
                    (string ChosenSize, List<String>ChosenToppings) = Pizzas.PrintPizzas();
                    Pizzas ChosenPizza = new Pizzas(ChosenSize, ChosenToppings);
                    Console.WriteLine("You've selected " + ChosenPizza.ToString());
                   currentItem = ChosenPizza;
                }
                else if (string.Equals(input, Categories.VegetarianPizzas, StringComparison.OrdinalIgnoreCase))
                {
                    (String ChosenSize, List<String>ChosenToppings) = VegetarianPizzas.PrintVegetarianPizzas();
                    VegetarianPizzas ChosenVegetarianPizza = new VegetarianPizzas(ChosenSize, ChosenToppings);
                    Console.WriteLine("You've selected " + ChosenVegetarianPizza.ToString());
                    currentItem = ChosenVegetarianPizza;
                }
                else if (string.Equals(input, Categories.Sandwiches, StringComparison.OrdinalIgnoreCase))
                {
                    String Sandwich = Sandwiches.PrintSandwiches();
                    Sandwiches ChosenSandwich = new Sandwiches(Sandwich);
                    Console.WriteLine("You've selected " + ChosenSandwich.ToString());
                    currentItem = ChosenSandwich;

                }
                else if (string.Equals(input, Categories.Soups, StringComparison.OrdinalIgnoreCase))
                {
                    if (!DeterminedSoups)
                    {
                        Soups.DailySoups();
                        DeterminedSoups = true;
                    }
                    (String SoupName,bool IsSoupOfDay) = Soups.PrintSoups();//made it a var because it needed to return a String AND a bool.
                    Soups ChosenSoup = new Soups(SoupName, IsSoupOfDay);
                    Console.WriteLine("You've selected " + ChosenSoup.ToString());
                    currentItem= ChosenSoup;
                }
                else if (string.Equals(input, Categories.Drinks, StringComparison.OrdinalIgnoreCase))
                {

                    String[] Drink = Drinks.PrintDrinks();
                    Drinks ChosenDrink = new Drinks(Drink[0], Drink[1], Drink[2]);
                    Console.WriteLine("You've selected " + ChosenDrink.ToString());
                    currentItem = ChosenDrink;
                }
                else if (string.Equals(input, Categories.Desserts, StringComparison.OrdinalIgnoreCase))
                {
                    String Dessert = Desserts.PrintDesserts();
                    Desserts ChosenDessert = new Desserts(Dessert);
                    Console.WriteLine("You've selected " + ChosenDessert.ToString());
                    currentItem = ChosenDessert;
                }
                if (!string.Equals(input, Cart, StringComparison.OrdinalIgnoreCase) && AddToCart())
                {
                    Itemize.Add(currentItem);
                }
                Console.WriteLine("Please choose a category. Say \"Cart\" when " +
                "you're ready to view your cart and check out.");
                Categories.PrintCategories();
                input = Console.ReadLine();
            }
            
            CheckOut(Itemize);
        }

        public static bool AddToCart()
        {
            Console.WriteLine("Would you like to add this item to your cart? Please say \"Yes\" or \"No\".");
            String input = Console.ReadLine();
            while (!string.Equals(input,"Yes",StringComparison.OrdinalIgnoreCase) && !string.Equals(input, "No", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Invalid input. Would you like to add this item to your cart? Please say \"Yes\"" +
                    "or \"No\".");
                input = Console.ReadLine();
            }return string.Equals(input,"Yes",StringComparison.OrdinalIgnoreCase);
        }
        public static void CheckOut(List<Item> Itemize)
        {
            double Total = 0;
            if (Itemize.Count == 0)
            {
                Console.WriteLine("Your cart is empty. Please add something to the cart to proceed with your order.");
                SelectCategory();
                return;
            }
            foreach (Item Item in Itemize)
            {
                Console.WriteLine(Item.ToString());
                Total += Item.GetPrice();
            }
            Console.WriteLine("Will this be for pick up or delivery? For delivery add $8.00");
            String input = Console.ReadLine();
            while (!string.Equals(input, Delivery, StringComparison.OrdinalIgnoreCase) 
                && !string.Equals(input, PickUp, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Invalid input. Please say \"Delivery\" for Delivery or \"Pick Up\" for Pick Up.");
                input = Console.ReadLine();
            }
            if (string.Equals(input,Delivery,StringComparison.OrdinalIgnoreCase))
            {
                Total += 8;
                Console.WriteLine("You have chosen for your order to be delivered. No need to input your address, we know where you live.");
            }
            else
            {
                Console.WriteLine("We will be tracking your location while we await your arrival for your order.");
            }
            Total += Total * .06;
            Console.WriteLine("Your total including tax is: $" + Total.ToString("0.00") );
        }
    }
}

