
namespace Project2.Components.Pages
{
    public partial class Pizzas
    {
        public String PizzaSize = String.Empty;

        
        public double TotalPrice = 0;

        public bool DisableAddToCart = true;

        public bool Pepperoni = false;
        public bool Pineapple = false;
        public bool Sausage = false;
        public bool Peppers = false;
        public bool Bacon = false;
        public bool Mushrooms = false;

        public static String namePepperoni = "Pepperoni";
        public static String nameBacon = "Bacon";
        public static String namePeppers = "Peppers";
        public static String namePineapple = "Pineapple";
        public static String nameMushrooms = "Mushrooms";
        public static String nameSausage = "Sausage";

        public Models.Pizzas pizza;



        public void Form()
        {
            Console.WriteLine("You submitted the form.");
            Console.WriteLine($"You've selected a {PizzaSize} pizza.");
            Models.Cart.Foods.Add(pizza);
        }

        public void CalcPrice()
        {
            DisableAddToCart = false;
            List<String> toppingList = new List<String>();

            if (Pepperoni)
            {
                toppingList.Add(namePepperoni);
            }
            if (Pineapple)
            {
                toppingList.Add(namePineapple);
            }
            if (Sausage)
            {
                toppingList.Add(nameSausage);
            }
            if (Bacon)
            {
                toppingList.Add(nameBacon);
            }
            if (Peppers)
            {
                toppingList.Add(namePeppers);
            }
            if (Mushrooms)
            {
                toppingList.Add(nameMushrooms);
            }

            pizza = new Models.Pizzas(PizzaSize, toppingList);
            TotalPrice = pizza.GetPrice();
        }

        public bool DisableCalcPrice()
        {
            return PizzaSize == String.Empty;
        }
    }
}
