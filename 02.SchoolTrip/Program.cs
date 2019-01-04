using System;

namespace _02.SchoolTrip
{
    class Program
    {
        static void Main()
        {
            int daysAniMissing = int.Parse(Console.ReadLine());
            double foodInKg = int.Parse(Console.ReadLine());
            double firstDog = double.Parse(Console.ReadLine());
            double secondDog = double.Parse(Console.ReadLine());
            double thirdDog = double.Parse(Console.ReadLine());

            double totalKg = daysAniMissing * firstDog + daysAniMissing * secondDog + daysAniMissing * thirdDog;

            if (foodInKg >= totalKg)
            {
                Console.WriteLine($"{Math.Floor(foodInKg - totalKg)} kilos of food left.");
            }

            else
            {
                Console.WriteLine($"{Math.Ceiling(totalKg - foodInKg)} more kilos of food are needed.");
            }
        }
    }
}
