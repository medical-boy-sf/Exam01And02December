using System;

namespace _03.EnergyBoosters
{
    class Program
    {
        static void Main()
        {
            var price = 0.0;
            string fruits = Console.ReadLine().ToLower();
            string sizeSets = Console.ReadLine().ToLower();
            short numberSets = short.Parse(Console.ReadLine());
            double sum = 0;

            if (fruits == "watermelon")
            {
                if (sizeSets == "small")
                {
                    price = 56;
                    sum = 2 * price;
                }

                else
                {
                    price = 28.7;
                    sum = 5 * price;
                }
            }

            else if (fruits == "mango")
            {
                if (sizeSets == "small")
                {
                    price = 36.66;
                    sum = 2 * price;
                }

                else
                {
                    price = 19.60;
                    sum = 5 * price;
                }
            }

            else if (fruits == "pineapple")
            {
                if (sizeSets == "small")
                {
                    price = 42.10;
                    sum = 2 * price;
                }

                else
                {
                    price = 24.8;
                    sum = 5 * price;
                }
            }

            else
            {
                if (sizeSets == "small")
                {
                    price = 20;
                    sum = 2 * price;
                }

                else
                {
                    price = 15.2;
                    sum = 5 * price;
                }
            }

            double finalSum = numberSets * sum;

            if (finalSum > 1000)
            {
                finalSum = finalSum - 0.5 * finalSum;
            }

            else if (finalSum >= 400)
            {
                finalSum = finalSum - finalSum * 0.15;
            }

            Console.WriteLine($"{finalSum:F2} lv.");
        }
    }
}
