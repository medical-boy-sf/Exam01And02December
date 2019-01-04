using System;

namespace TrekkingEquipment
{
    class MainClass
    {
        public static void Main()
        {
            int numberOfAlpinists = int.Parse(Console.ReadLine());
            int numberCarabiners = int.Parse(Console.ReadLine());
            int numberRopes = int.Parse(Console.ReadLine());
            int numbersPickels = int.Parse(Console.ReadLine());

            double sum = numberCarabiners * 36 + numberRopes * 3.6 + numbersPickels * 19.8;
            double totalSum = sum * numberOfAlpinists;
            totalSum = totalSum + totalSum * 0.2;
            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
