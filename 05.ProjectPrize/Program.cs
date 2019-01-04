using System;

namespace _05.ProjectPrize
{
    class Program
    {
        static void Main()
        {
            int projectParts = int.Parse(Console.ReadLine());
            double prize = double.Parse(Console.ReadLine());
            int points = 0;
            int sum = 0;

            for (int i = 1; i <= projectParts; i++)
            {
                points = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sum += points * 2;
                }

                else
                {
                    sum += points;
                }
            }

            prize *= sum;
            Console.WriteLine($"The project prize was {prize:F2} lv.");
        }
    }
}
