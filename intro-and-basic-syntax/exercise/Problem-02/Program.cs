using System;

namespace BeverageLabels
{
    class Program
    {
        static void Main()
        {
            var productName = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyPer100Ml = int.Parse(Console.ReadLine());
            var sugarPer100Ml = int.Parse(Console.ReadLine());
            // reading user input for product info

            var totalKcal = (energyPer100Ml * volume) / 100.0; 
            var totalSugar = (sugarPer100Ml * volume) / 100.0; 

            Console.WriteLine($"{volume}ml {productName}:");
            Console.WriteLine($"{totalKcal}kcal, {totalSugar}g sugars");

        }
    }
}
