namespace Project2.Components.Pages
{
    public partial class Sandwiches
    {
        public String Paninis = String.Empty;//they're a kind of sandwich

        public void Form()
        {
            Console.WriteLine("You submitted the form.");
            Models.Sandwiches sandwich = new Models.Sandwiches(Paninis);
            Models.Cart.Foods.Add(sandwich);
        }

        public bool DisableAddToCart()
        {
            return Paninis == String.Empty;
            
        }

    }
}
