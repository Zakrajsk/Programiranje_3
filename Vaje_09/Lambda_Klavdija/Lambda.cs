using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Klavdija
{
    class Lambda
    {
        static void Main(string[] args)
        {
            List<int> seznam = new List<int>() { 2, 9, 23, 27, 44, 59, 99, 173, 305, 411, 1050, 4020, 5831 };
            var filtriran = seznam.Where(el => el % 3 == 0);
            Console.WriteLine(string.Join(" ", filtriran));
            var kvadriran = filtriran.Select(el => el * el);
            Console.WriteLine(string.Join(" ", kvadriran));
        }
    }
}
