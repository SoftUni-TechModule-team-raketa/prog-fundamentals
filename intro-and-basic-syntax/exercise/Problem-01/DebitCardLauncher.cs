using System;

namespace SoftUniTechModule
{
    class DebitCardLauncher
    {
        static void Main()
        {   //  receiving 4 integers from a user...
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            //  formatting them into four - digit format for debit cards.
            Console.WriteLine($"{num1:D4} {num2:D4} {num3:D4} {num4:D4}");
        }
    }
}
