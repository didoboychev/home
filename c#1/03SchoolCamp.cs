using System;


namespace _03SchoolCamp
{
    class SchoolCamp
    {
        static void Main()
        {
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            double students = double.Parse(Console.ReadLine());
            double nights = double.Parse(Console.ReadLine());
            string sport = string.Empty;
            double price = 0;

            if (season == "Spring")
            {
                if (group == "girls")
                {
                    sport = "Athletics";
                    price = students * 7.20 * nights; ;
                }
                else if (group == "boys")
                {
                    sport = "Tennis";
                    price = students * 7.20 * nights; ;
                }
                else if (group == "mixed")
                {
                    sport = "Cycling";
                    price = students * 9.50 * nights; ;
                }
            }
            else if (season == "Winter")
            {
                if (group == "girls")
                {
                    sport = "Gymnastics";
                    price = students * 9.60 * nights; ;
                }
                else if (group == "boys")
                {
                    sport = "Judo";
                    price = students * 9.60 * nights; ;
                }
                else if (group == "mixed")
                {
                    sport = "Ski";
                    price = students * 10.00 * nights; ;
                }

            }
            else if (season == "Summer")
            {
                if (group == "girls")
                {
                    sport = "Volleyball";
                    price = students * 15.00 * nights; ;
                }
                else if (group == "boys")
                {
                    sport = "Football";
                    price = students * 15.00 * nights; ;
                }
                else if (group == "mixed")
                {
                    sport = "Swimming";
                    price = students * 20.00 * nights; ;
                }
            }
            if (students >= 50)
            {
                price = price - price * 0.50;
            }
            else if (students >= 20 && students < 50)
            {
                price = price - price * 0.15;
            }
            else if (students >= 10 && students < 20)
            {
                price = price - price * 0.05;
            }
            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}
