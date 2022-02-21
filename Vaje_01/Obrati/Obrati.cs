using System;

namespace Obrati
{
    class Obrati
    {
        static void Main(string[] args)
        {
            string prvo = Console.ReadLine();
            string drugo = Console.ReadLine();

            char[] tab_p = prvo.ToCharArray();
            Array.Reverse(tab_p);
            prvo = new string(tab_p);

            char[] tab_d = drugo.ToCharArray();
            Array.Reverse(tab_d);
            drugo = new string(tab_d);

            Console.WriteLine(prvo + " - " + drugo + " = " + (Convert.ToInt32(prvo) - Convert.ToInt32(drugo)));

        }
    }
}
