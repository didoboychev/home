using System;


namespace _06NumberGenerator
{
    class NumberGenerator
    {
        static void Main()
        {

            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());

            int specialNumber = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());

            for (int Mrow = M; Mrow >= 1; Mrow--)
            {
                for (int Nrow = N; Nrow >= 1; Nrow--)
                {
                    for (int Lrow = L; Lrow >= 1; Lrow--)
                    {
                        int number = (Mrow * 100) + (Nrow * 10) + Lrow;

                        if (number % 3 == 0)
                        {
                            specialNumber += 5;
                        }
                        else if (number % 5 == 0)
                        {
                            specialNumber -= 2;
                        }
                        else if (number % 2 == 0)
                        {
                            specialNumber *= 2;
                        }

                        if (specialNumber >= controlNumber)
                        {
                            Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNumber}.");
                            return;

                        }
                    }
                }
            }
            if (specialNumber < controlNumber)
            {
                Console.WriteLine($"No! {specialNumber} is the last reached special number.");
            }

        }
    }
}
