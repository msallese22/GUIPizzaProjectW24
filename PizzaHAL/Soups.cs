

namespace PizzaHAL
{
    internal class Soups : Item
    {
        private const double RegularPrice = 4.49;
        private const double DailySoupPrice = 3.49;
        private String Flavor;
        private bool IsSoupOfDay = false;
        private static List<int> YourSoups = new List<int>();
        private static int SoupOfDay = 0;

        private const String BroccoliCheddarSoup = "Broccoli Cheddar";
        private const String ChickenNoodleSoup = "Chicken Noodle";
        private const String ItalianWeddingSoup = "Italian Wedding";
        private const String ClamChowder = "Clam Chowder";
        private const String TomatoBasil = "Tomato Basil";

        private enum SoupOptions
        {
            BroccoliCheddarSoup,
            ChickenNoodleSoup,
            ItalianWeddingSoup,
            ClamChowder,
            TomatoBasil
        }

        public Soups(String Flavor, bool IsSoupOfDay)
        {
            this.Flavor = Flavor;
            this.IsSoupOfDay = IsSoupOfDay;
        }

        public override String ToString()
        {
            //DailySoupPrice
            if (IsSoupOfDay)
            {
                return Flavor + ": $" + DailySoupPrice;
            }
            else
                return Flavor + ": $" + RegularPrice;

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
            SoupOfDay = YourSoups[random.Next(0, 3)];
        }


        public static (String, bool) PrintSoups()
        {
            Console.WriteLine("Please make a selection from our soups.");
            String SoupOfDayName = String.Empty;
            YourSoups.ForEach(s =>
            {
                switch (s)
                {
                    case (int)SoupOptions.BroccoliCheddarSoup:
                        if (SoupOfDay == s)
                        {
                            SoupOfDayName = BroccoliCheddarSoup;
                            Console.WriteLine(BroccoliCheddarSoup + " is the soup of the day for: $" + DailySoupPrice);
                        }
                        else
                            Console.WriteLine(BroccoliCheddarSoup + ": $" + RegularPrice);
                        break;

                    case (int)SoupOptions.ChickenNoodleSoup:
                        if (SoupOfDay == s)
                        {
                            SoupOfDayName = ChickenNoodleSoup;
                            Console.WriteLine(ChickenNoodleSoup + " is the soup of the day for: $" + DailySoupPrice);
                        }
                        else
                            Console.WriteLine(ChickenNoodleSoup + ": $" + RegularPrice);
                        break;

                    case (int)SoupOptions.ItalianWeddingSoup:
                        if (SoupOfDay == s)
                        {
                            SoupOfDayName = ItalianWeddingSoup;
                            Console.WriteLine(ItalianWeddingSoup + " is the soup of the day for: $" + DailySoupPrice);
                        }
                        else
                            Console.WriteLine(ItalianWeddingSoup + ": $" + RegularPrice);
                        break;

                    case (int)SoupOptions.ClamChowder:
                        if (SoupOfDay == s)
                        {
                            SoupOfDayName = ClamChowder;
                            Console.WriteLine(ClamChowder + " is the soup of the day for: $" + DailySoupPrice);
                        }
                        else
                            Console.WriteLine(ClamChowder + ": $" + RegularPrice);
                        break;

                    case (int)SoupOptions.TomatoBasil:
                        if (SoupOfDay == s)
                        {
                            SoupOfDayName = TomatoBasil;
                            Console.WriteLine(TomatoBasil + " is the soup of the day for: $" + DailySoupPrice);
                        }
                        else
                            Console.WriteLine(TomatoBasil + ": $" + RegularPrice);
                        break;

                }
            });
            String input = Console.ReadLine();
            while (!string.Equals(input, BroccoliCheddarSoup, StringComparison.OrdinalIgnoreCase) && !string.Equals(input, ChickenNoodleSoup, StringComparison.OrdinalIgnoreCase) && !string.Equals(input, ItalianWeddingSoup, StringComparison.OrdinalIgnoreCase) &&
                !string.Equals(input, ClamChowder, StringComparison.OrdinalIgnoreCase) && !string.Equals(input, TomatoBasil, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Invalid input. Please make a selection from our soups.");
                input = Console.ReadLine();
            }
            if (string.Equals(input, SoupOfDayName, StringComparison.OrdinalIgnoreCase))
            {
                return (input, true);
            }
            return (input, false);
        }
        public override double GetPrice()
        {
            return IsSoupOfDay ? DailySoupPrice : RegularPrice;
        }
    }
}
