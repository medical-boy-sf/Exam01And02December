using System;

namespace _04.Everest
{
    class Program
    {
        static void Main()
        {
            int initialHeight = 5364;
            int days = 1;
            string yesOrNo = "";
            string height = "";
            int heightInt = 0;
            int goal = 8848;

            while (true)
            {
                yesOrNo = Console.ReadLine().ToLower();
                if (yesOrNo == "yes")
                {
                    days += 1;
                }
                if (days > 5 || initialHeight >= goal || yesOrNo == "end") break;
                height = Console.ReadLine().ToLower();
                heightInt = int.Parse(height);
                initialHeight += heightInt;
            }

            if (initialHeight >= goal)
            {
                Console.WriteLine($"Goal reached for {days} days!");
            }

            else
            {
                Console.WriteLine($"Failed!\n{initialHeight}");
            }
        }
    }
}
