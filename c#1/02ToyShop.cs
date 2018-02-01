using System;


namespace _02ToyShop
{
    class _02ToyShop
    {
        static void Main()
        {
            double price = double.Parse(Console.ReadLine());
            double puzzels = double.Parse(Console.ReadLine());
            double speakingDolls = double.Parse(Console.ReadLine());
            double teddyBears = double.Parse(Console.ReadLine());
            double minions = double.Parse(Console.ReadLine());
            double trucks = double.Parse(Console.ReadLine());
            double money = puzzels * 2.60 + speakingDolls * 3.00 + teddyBears * 4.10 + minions * 8.20 + trucks * 2.00;
            double toys = puzzels + speakingDolls + teddyBears + minions + trucks;
            if (toys >= 50)
            {
                money = money - money * 0.25;
            }
            money = money - money * 0.10;
            double difference = Math.Abs(price - money);
            if (money >= price)
            {
                Console.WriteLine($"Yes! {difference:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {difference:f2} lv needed.");
            }



        }
    }
}