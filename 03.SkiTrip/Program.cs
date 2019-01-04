using System;

namespace _03.SkiTrip
{
    class Program
    {
        static void Main()
        {
            int dayStaying = int.Parse(Console.ReadLine()) - 1;
            string kindRoom = Console.ReadLine().ToLower();
            string assignment = Console.ReadLine().ToLower();
            double discount = 0;
            double pricePerDay = 0;

            if (kindRoom == "room for one person")
            {
                pricePerDay = 18;
                if (dayStaying > 15)
                {
                    discount = 0;
                }

                else if (dayStaying > 10)
                {
                    discount = 0;
                }

                else
                {
                    discount = 0;
                }
            }

            else if (kindRoom == "apartment")
            {
                pricePerDay = 25;
                if (dayStaying > 15)
                {
                    discount = 0.5;
                }

                else if (dayStaying > 10)
                {
                    discount = 0.35;
                }

                else
                {
                    discount = 0.30;
                }
            }

            else
            {
                pricePerDay = 35;
                if (dayStaying > 15)
                {
                    discount = 0.2;
                }

                else if (dayStaying > 10)
                {
                    discount = 0.15;
                }

                else
                {
                    discount = 0.10;
                }
            }
            double totalSum = pricePerDay * dayStaying;
            totalSum = totalSum - discount * totalSum;

            if (assignment == "positive")
            {
                totalSum = totalSum + totalSum * 0.25;
            }

            else
            {
                totalSum = totalSum - totalSum * 0.1;
            }

            Console.WriteLine($"{totalSum:F2}");
            
        }
    }
}
