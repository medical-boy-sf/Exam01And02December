using System;

namespace _06.MathPuzzle
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int a = 1; a <= 30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        if (a * b * c == number && (a > b && b > c))
                        {
                            Console.WriteLine($"{a} * {b} * {c} = {number}");
                            counter += 1;
                        }

                        if (a + b + c == number && (c > b && b > a))
                        {
                            Console.WriteLine($"{a} + {b} + {c} = {number}");
                            counter += 1;
                        }
                    }
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
