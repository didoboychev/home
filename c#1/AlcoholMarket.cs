using System;


namespace AlcoholMarket
{
    class AlcoholMarket
    {
        static void Main()
        {

            double whiskeyBGN = double.Parse(Console.ReadLine());
            double beer = double.Parse(Console.ReadLine());
            double wine = double.Parse(Console.ReadLine());
            double rakia = double.Parse(Console.ReadLine());
            double whiskey = double.Parse(Console.ReadLine());
            double RakiaBGN = whiskeyBGN / 2;
            double WineBGN = RakiaBGN - RakiaBGN * 0.40;
            double BeerBGN = RakiaBGN - RakiaBGN * 0.80;
            RakiaBGN *= rakia;
            WineBGN *= wine;
            BeerBGN *= beer;
            whiskeyBGN *= whiskey;
            Console.WriteLine($"{(RakiaBGN + WineBGN + BeerBGN + whiskeyBGN):f2}");

        }
    }
}
