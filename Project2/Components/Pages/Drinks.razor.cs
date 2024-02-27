namespace Project2.Components.Pages
{
    public partial class Drinks
    {
        public String Drink = String.Empty;


        public String DrinkSize = String.Empty;
        public String Ice = String.Empty;

        public void Form()
        {
            Console.WriteLine("You submitted the form.");

            Models.Drinks drink = new Models.Drinks (Drink, DrinkSize, Ice);
            Models.Cart.Foods.Add (drink);
        }
        public bool DisableAddToCart()
        {
            return Ice == String.Empty;

        }
    }
}
