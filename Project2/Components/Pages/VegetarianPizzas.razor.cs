namespace Project2.Components.Pages
{
        public partial class VegetarianPizzas
        {
            public String VegetarianPizzaSize = String.Empty;

            public double VegTotalPrice = 0;

            public bool DisableAddToCart = true;

            public bool Pineapple = false;
            public bool Peppers = false;
            public bool Mushrooms = false;

            public static String namePeppers = "Peppers";
            public static String namePineapple = "Pineapple";
            public static String nameMushrooms = "Mushrooms";

            public Models.VegetarianPizzas VegetarianPizza;



        public void Form()
            {
                Models.Cart.Foods.Add(VegetarianPizza);
            }

        public void CalcPrice()
        {
            DisableAddToCart = false;
            List<String> toppingList = new List<String>();

            
            if (Pineapple)
            {
                toppingList.Add(namePineapple);
            }
            
            if (Peppers)
            {
                toppingList.Add(namePeppers);
            }
            if (Mushrooms)
            {
                toppingList.Add(nameMushrooms);
            }

            VegetarianPizza = new Models.VegetarianPizzas(VegetarianPizzaSize, toppingList);
            VegTotalPrice = VegetarianPizza.GetPrice();
        }

        public bool DisableCalcPrice()
        {
            return VegetarianPizzaSize == String.Empty;
        }
    }
}

