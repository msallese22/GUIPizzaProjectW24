

namespace PizzaHAL
{
    internal class Categories
    {
        public const String Pizzas = "Pizzas";
        public const String VegetarianPizzas = "Vegetarian Pizzas";
        public const String Sandwiches = "Sandwiches";
        public const String Soups = "Soups";
        public const String Drinks = "Drinks";
        public const String Desserts = "Desserts";

        public const ConsoleColor PizzasColor = ConsoleColor.Red;
        public const ConsoleColor VegetarianPizzasColor = ConsoleColor.Green;
        public const ConsoleColor SandwichesColor = ConsoleColor.DarkYellow;
        public const ConsoleColor SoupsColor = ConsoleColor.Yellow;
        public const ConsoleColor DessertsColor = ConsoleColor.Magenta;
        public const ConsoleColor DrinksColor = ConsoleColor.Blue;

        public static void PrintCategories()
        {
            PrintWColor(Pizzas.ToString()+ Environment.NewLine, PizzasColor);
            PrintWColor(VegetarianPizzas.ToString() + Environment.NewLine, VegetarianPizzasColor);
            PrintWColor(Sandwiches.ToString() + Environment.NewLine, SandwichesColor);
            PrintWColor(Soups.ToString() + Environment.NewLine, SoupsColor);
            PrintWColor(Desserts.ToString() + Environment.NewLine, DessertsColor);
            PrintWColor(Drinks.ToString() + Environment.NewLine, DrinksColor);
        }
        public static void PrintWColor(String text, ConsoleColor color)
        {
            Console.ForegroundColor = color;//change color
            Console.Write(text);//print with color
            Console.ForegroundColor = ConsoleColor.White;//reset to white
        }
        

    }
}
