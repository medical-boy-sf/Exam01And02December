using System;

namespace SchoolSupplies
{
    class MainClass
    {
        public static void Main()
        {
            int numberPens = int.Parse(Console.ReadLine());
            int numberMarkers = int.Parse(Console.ReadLine());
            double litresCleaner = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine()) * 0.01;

            double totalExpenses = numberPens * 5.8 + numberMarkers * 7.2 + litresCleaner * 1.2;
            double finalSum = totalExpenses - totalExpenses * discount;

            Console.WriteLine($"{finalSum:F3}");
        }
    }
}
