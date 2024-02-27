using Microsoft.AspNetCore.Components;
using Project2.Models;
using System.Diagnostics.Eventing.Reader;

namespace Project2.Components.Pages
{
    partial class Soups : ComponentBase
    {
        public string Stews = string.Empty;
        private static List<int> YourSoups = new List<int>();
        public static List<String> Stew = new List<String>();
        private static int SoupOfDay = -1;

        public static String BroccoliCheddarSoup = "Broccoli Cheddar";
        public static String ChickenNoodleSoup = "Chicken Noodle";
        public static String ItalianWeddingSoup = "Italian Wedding";
        public static String ClamChowder = "Clam Chowder";
        public static String TomatoBasil = "Tomato Basil";

        private const double RegularPrice = 4.49;
        private const double DailySoupPrice = 3.49;
        private static String SoupOfDayName = String.Empty;

        public void Form()
        {
            Soup soup;
            String soupName = Stews.Split("$")[0].TrimEnd(' ');
            if (soupName == SoupOfDayName)
            {
                soup = new Soup(soupName, true, DailySoupPrice);

            }
            else
            {
                soup = new Soup(soupName, false, RegularPrice);
            }

            Models.Cart.Foods.Add( soup );
        }
        private enum SoupOptions
        {
            BroccoliCheddarSoup,
            ChickenNoodleSoup,
            ItalianWeddingSoup,
            ClamChowder,
            TomatoBasil
        }
        public static void DailySoups()
        {
            Random random = new Random();

            while (YourSoups.Count < 3)
            {

                int chosenSoup = random.Next(0, 6);
                while (YourSoups.Contains(chosenSoup))
                {
                    chosenSoup = random.Next(0, 6);
                }
                switch (chosenSoup)
                {
                    case (int)SoupOptions.BroccoliCheddarSoup:
                        YourSoups.Add(chosenSoup);
                        break;
                    case (int)SoupOptions.ChickenNoodleSoup:
                        YourSoups.Add(chosenSoup);
                        break;
                    case (int)SoupOptions.ItalianWeddingSoup:
                        YourSoups.Add(chosenSoup);
                        break;
                    case (int)SoupOptions.ClamChowder:
                        YourSoups.Add(chosenSoup);
                        break;
                    case (int)SoupOptions.TomatoBasil:
                        YourSoups.Add(chosenSoup);
                        break;

                }

            }
            if (SoupOfDay== -1 ) 
            {
                SoupOfDay = YourSoups[random.Next(0, 3)];
            }
           
        }
        public static void PrintSoups()
        {
           
            
            YourSoups.ForEach(s =>
            {
                switch (s)
                {
                    case (int)SoupOptions.BroccoliCheddarSoup:
                        if (SoupOfDay == s)
                        {
                            SoupOfDayName = BroccoliCheddarSoup;
                            Stew.Add($"{BroccoliCheddarSoup} ${DailySoupPrice}");
                        }
                        else
                            Stew.Add($"{BroccoliCheddarSoup} ${RegularPrice}");
                        break;

                    case (int)SoupOptions.ChickenNoodleSoup:
                        if (SoupOfDay == s) 
                        {
                            SoupOfDayName = ChickenNoodleSoup;
                            Stew.Add($"{ChickenNoodleSoup} ${DailySoupPrice}");
                        }
                        else
                            Stew.Add($"{ChickenNoodleSoup} ${RegularPrice}");
                        break;

                    case (int)SoupOptions.ItalianWeddingSoup:
                        if (SoupOfDay == s)
                        {
                                SoupOfDayName = ItalianWeddingSoup;
                                Stew.Add($"{ItalianWeddingSoup} ${DailySoupPrice}");
                        }
                        else
                            Stew.Add($"{ItalianWeddingSoup} ${RegularPrice}");
                        break;

                    case (int)SoupOptions.ClamChowder:
                        if (SoupOfDay == s)
                        {
                            SoupOfDayName = ClamChowder;
                            Stew.Add($"{ClamChowder} ${DailySoupPrice}");
                        }
                        else
                            Stew.Add($"{ClamChowder} ${RegularPrice}");
                        break;

                    case (int)SoupOptions.TomatoBasil:
                        if (SoupOfDay == s)
                        {
                            SoupOfDayName = TomatoBasil;
                            Stew.Add($"{TomatoBasil} ${DailySoupPrice}");
                        }
                        else
                            Stew.Add($"{TomatoBasil} ${RegularPrice}");
                        break;

                }
            });
        }

        public bool DisableAddToCart()
        {
            return Stews == String.Empty;

        }
    }
}
