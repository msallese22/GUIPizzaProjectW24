namespace Project2.Components.Pages
{
    public partial class Desserts
    {
        public String Dessert = String.Empty;

        public void Form()
        {
            Console.WriteLine("You submitted the form.");
            Models.Desserts dessert = new Models.Desserts(Dessert);
            Models.Cart.Foods.Add(dessert);
        }
        public bool DisableAddToCart()
        {
            return Dessert == String.Empty;

        }


    }


}
