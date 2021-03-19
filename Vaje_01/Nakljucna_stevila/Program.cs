using System;

namespace Nakljucna_stevila
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine(rand.Next(100, 1000));
        }
    }
}
