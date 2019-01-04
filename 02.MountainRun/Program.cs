using System;

namespace _02.MountainRun
{
    class Program
    {
        static void Main()
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double time = distance * timeForOneMeter;
            double timeSlowing = Math.Floor((distance / 50)) * 30;
            double totalTime = time + timeSlowing;

            if (totalTime < record)
            {
                Console.WriteLine($"Yes! The new record is {totalTime:F2} seconds.");
            }

            else
            {
                Console.WriteLine($"No! He was {(totalTime - record):F2} seconds slower.");
            }
        }
    }
}
