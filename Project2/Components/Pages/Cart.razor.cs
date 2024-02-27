using MatBlazor;
using Microsoft.JSInterop;
using Project2.Models;
namespace Project2.Components.Pages
{
    public partial class Cart
    {
        public bool PickUp = true;
        

        private double Subtotal = 0;

        MatTheme theme1 = new MatTheme()
        {
            Primary = MatThemeColors.Green._900.Value,
            Secondary = MatThemeColors.Red._900.Value
        };
        public double CalculateGrandTotal()
        {
            double Total=0;
            foreach (Item Item in Models.Cart.Foods)
            {

                Total += Item.GetPrice();

            }
            Subtotal = Total;
            return Total;
        }

        public double CalcTotalWithTax()
        {
            if (!PickUp)
            {
                Subtotal += 8;
            }
            return Subtotal += Subtotal * .06;
        }

        

    }
}
