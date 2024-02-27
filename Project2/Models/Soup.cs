namespace Project2.Models
{
    public class Soup : Item
    {
        public String Flavor;
        public double Price;
        public bool SoupOfDay;

        public Soup(String Flavor, bool SoupOfDay, double Price)
        {
            this.Flavor = Flavor;
            this.SoupOfDay = SoupOfDay;
            this.Price = Price;
        }

        public override String ToString()
        {
            
            return Flavor + ": $" + Price;

        }
     
        public override double GetPrice()
        {
            return Price;
        }
    }
}
