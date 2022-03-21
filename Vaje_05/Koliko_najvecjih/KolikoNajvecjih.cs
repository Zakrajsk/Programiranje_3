using System;

namespace Koliko_najvecjih
{
    public class KolikoNajvecjih
    {

        public static int PrestejNajvecje<T>(T[] tabela) where T : IComparable
        {
            if (tabela.Length == 0)
            {
                return 0;
            }
            int st_najvecjih = 1;
            T trenutno_najvecji = tabela[0];
            for (int i = 1; i < tabela.Length; i++)
            {
                if (tabela[i].CompareTo(trenutno_najvecji) > 0){
                    //Nasli smo vecjega
                    st_najvecjih = 1;
                    trenutno_najvecji = tabela[i];
                }
                else if(tabela[i].CompareTo(trenutno_najvecji) == 0){
                    st_najvecjih++;
                }
            }
            return st_najvecjih;
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
