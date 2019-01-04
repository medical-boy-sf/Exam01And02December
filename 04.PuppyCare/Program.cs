using System;

namespace _04.PuppyCare
{
    class Program
    {
        static void Main()
        {
            int foodInKg = int.Parse(Console.ReadLine()) * 1000;

            string foodADay = Console.ReadLine().ToLower();
            int sumFood = 0;

            while (foodADay != "adopted")
            {
                int foodADayInt = int.Parse(foodADay);
                sumFood += foodADayInt;
                foodADay = Console.ReadLine().ToLower();
            }

            if (foodInKg >= sumFood)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodInKg - sumFood} grams.");
            }

            else
            {
                Console.WriteLine($"Food is not enough. You need {sumFood - foodInKg} grams more.");
            }
        }
    }
}
