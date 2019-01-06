using System;

namespace _06.SafePasswords
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxNumberPasswords = int.Parse(Console.ReadLine());
            int counter = 0;
            char i = '#';
            char j = '@';

            for (int k = 1; k <= a; k++)
            {
                for (int d = 1; d <= b; d++)
                {
                    if (i > '7')
                    {
                        i = '#';
                    }

                    if (j > '`')
                    {
                        j = '@';
                    }

                    if (counter < maxNumberPasswords)
                    {
                        Console.Write($"{i}{j}{k}{d}{j}{i}|");
                    }

                    else
                    {
                        return;
                    }
                    j++;
                    i++;
                    counter++;
                }
            }
        }
    }
}
