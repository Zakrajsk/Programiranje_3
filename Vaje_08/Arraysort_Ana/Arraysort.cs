using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraysort_Ana
{
    public class Sortirni: IComparer
    {
        public int Compare(object prvi, object drugi)
        {
            int st_a_prvi = prvi.ToString().ToLower().Split('a').Length - 1;
            int st_a_drugi = drugi.ToString().ToLower().Split('a').Length - 1;
            if (st_a_prvi == st_a_drugi)
            {
                int prvi_dol = prvi.ToString().Length;
                int drugi_dol = drugi.ToString().Length;

                if (prvi_dol == drugi_dol)
                {
                    return prvi.ToString().CompareTo(drugi.ToString());
                }

                return prvi_dol.CompareTo(drugi_dol);
            }
            return st_a_prvi.CompareTo(st_a_drugi);
        }
    }
    class Arraysort
    {
        static void Main(string[] args)
        {
            ArrayList imena = new ArrayList();
            imena.Add("Marija");
            imena.Add("Ana");
            imena.Add("Maja");
            imena.Add("Irena");
            imena.Add("Mojca");
            imena.Add("Nina");
            imena.Add("Mateja");
            imena.Add("Nataša");
            imena.Add("Andreja");
            imena.Add("Barbara");

            IComparer primerjalnik = new Sortirni();
            imena.Sort(primerjalnik);

            foreach (string ime in imena)
            {
                Console.WriteLine(ime);
            }


        }
    }
}
