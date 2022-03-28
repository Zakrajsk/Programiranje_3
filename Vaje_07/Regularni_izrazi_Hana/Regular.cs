using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regularni_izrazi_Hana
{
    class Regular
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi email: ");
            string vnos = Console.ReadLine();

            Regex vzorec_gmail = new Regex(@"[a-z0-9.]{6,30}@gmail.com");
            Regex vzorec_str_fmf = new Regex(@"[a-z0-9.]{6,30}@student.fmf.uni-lj.si");
            Regex vzorec_nov_fmf = new Regex(@"[a-z]{2}[0-9]{4}@student.uni-lj.si");

            if(vzorec_gmail.Match(vnos).Success)
            {
                Console.WriteLine("Vnesen je gmail racun");
            }

            if (vzorec_str_fmf.Match(vnos).Success)
            {
                Console.WriteLine("Vnesen je star fmf racun");
            }

            if (vzorec_nov_fmf.Match(vnos).Success)
            {
                Console.WriteLine("Vnesen je nov fmf racun");
            }

        }
    }
}
