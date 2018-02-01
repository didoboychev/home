using System;


namespace _04FootballLeague
{
    class FootballLeague
    {
        static void Main()
        {
            double AmountOfTheStadium = double.Parse(Console.ReadLine());
            double countOfFans = double.Parse(Console.ReadLine());
            string A = "A";
            string B = "B";
            string V = "V";
            string G = "G";

            double CountA = 0;
            double CountB = 0;
            double CountV = 0;
            double CountG = 0;
            for (int i = 0; i < countOfFans; i++)
            {
                string KindOfFan = Console.ReadLine();
                if (KindOfFan == A)
                {
                    CountA++;

                }
                else if (KindOfFan == B)
                {
                    CountB++;
                }
                else if (KindOfFan == V)
                {
                    CountV++;
                }
                else if (KindOfFan == G)
                {
                    CountG++;

                }
            }
            Console.WriteLine($"{CountA / countOfFans * 100:f2}%");
            Console.WriteLine($"{CountB / countOfFans * 100:f2}%");
            Console.WriteLine($"{CountV / countOfFans * 100:f2}%");
            Console.WriteLine($"{CountG / countOfFans * 100:f2}%");
            Console.WriteLine($"{countOfFans / AmountOfTheStadium * 100:f2}%");
        }
    }
}