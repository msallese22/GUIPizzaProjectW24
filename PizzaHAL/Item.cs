

namespace PizzaHAL
{
    public abstract class Item
    {
        public override String ToString()
        {
            return ("Wrong to string");
        }

        public abstract double GetPrice();
        
    }
}
