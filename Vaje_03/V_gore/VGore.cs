using System;

namespace V_gore
{

    class VisinaMostu
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Visina : " + globina() + " m.");
        }

        public static double globina()
        {
            double g = 9.8;
            Console.Write("Vnesi cas padanja kamna z mostu do tal (v sekundah): ");
            double t = Double.Parse(Console.ReadLine());
            //izracunamo visino 
            double h = g * Math.Pow(t, 2) / 2;
            //zaokrozimo na dve decimalki 
            h = (int)(h * 100) / 100.0;
            return h;
        }
    }
}
