// Confirmed from <mayaema>
using System;
using System.Linq;

namespace Character_Stats
{
    class Program
    {
        static void Main()
        {
            // Read the input in the apropriate types
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{new string ('|', currentHealth) + new string ('.', (maxHealth - currentHealth))}|");
            Console.WriteLine($"Energy: |{new string('|', currentEnergy) + new string('.', (maxEnergy - currentEnergy))}|");
        }
    }
}
