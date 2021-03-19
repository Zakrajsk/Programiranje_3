using System;

namespace Popravi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Za števila a, b in c seveda velja a+(b+c)=(a+b)+c, saj je " + (a + (b + c)) + " = " + ((a + b) + c) + ".");
        }
    }
}
