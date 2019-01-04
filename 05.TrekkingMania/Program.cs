using System;

namespace _05.TrekkingMania
{
    class Program
    {
        static void Main()
        {
            int numberGroups = int.Parse(Console.ReadLine());
            int everest = 0;
            int k2 = 0;
            int kilimanjaro = 0;
            int monblan = 0;
            int musala = 0;

            for (int i = 0; i < numberGroups; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number >= 41)
                {
                    everest += number;
                }

                else if (number >= 26)
                {
                    k2 += number;
                }

                else if (number >= 13)
                {
                    kilimanjaro += number;
                }

                else if (number >= 6)
                {
                    monblan += number;
                }

                else if (number > 0)
                {
                    musala += number;
                }

            }

            int total = everest + k2 + kilimanjaro + monblan + musala;
            Console.WriteLine($"{((musala / (double)total) * 100):F2}%");
            Console.WriteLine($"{((monblan / (double)total) * 100):F2}%");
            Console.WriteLine($"{((kilimanjaro / (double)total) * 100):F2}%");
            Console.WriteLine($"{((k2 / (double)total) * 100):F2}%");
            Console.WriteLine($"{(((double)everest / total) * 100):F2}%");
        }
    }
}
