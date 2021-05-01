using System;
using System.Collections.Generic;
using System.Linq;

namespace List_T
{

    class Vozilo : IComparable<Vozilo>, IEquatable<Vozilo>, IEquatable<string>
    {
        private string znamka;
        private string model;
        private int moc;

        public Vozilo(string znamka, string model, int moc)
        {
            this.znamka = znamka;
            this.model = model;
            this.Moc = moc;
        }

        public string Znamka
        {
            get { return this.znamka; }
        }

        public string Model
        {
            get { return this.model; }
        }

        public int Moc
        {
            get { return this.moc; }
            set
            {
                if(value < 0)
                {
                    throw new Exception("Moč ne more biti negativna.");
                }
                this.moc = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Znamka}: {this.Model} - {this.Moc}KW";
        }

        public int CompareTo(Vozilo primerjani)
        {
            return this.Moc.CompareTo(primerjani.Moc);
        }

        public bool Equals(Vozilo primerjani)
        {
            return this.Znamka.Equals(primerjani.Znamka);
        }

        public bool Equals(string znamka)
        {
            return this.Znamka == znamka;
        }
    }


    class Program
    {

        /// <summary>
        /// Izpise list vsakega v svojo vrsto z indeksi spredaj
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public static void IzpisLista<T>(List<T> list)
        {
            Console.Write("[");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]}");
                if(i != list.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }

        public static bool liho(int st)
        {
            return st % 2 != 0;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("------------lastnosti-----------------");

            List<int> list_interger = new List<int>();
            int[] tabela = new int[] { 3, 2, 5, 6, 1 };
            list_interger.AddRange(tabela);
            Console.WriteLine("Capacity: " + list_interger.Capacity);
            list_interger.Add(8);
            Console.WriteLine("Capacity: " + list_interger.Capacity);

            Console.WriteLine("Count: " + list_interger.Count);
            Console.WriteLine(list_interger[2]);
            Console.WriteLine(list_interger[5]);

            Console.WriteLine("--------------Konstruktorji-----------------");

            List<int> kon_1 = new List<int>();
            Console.WriteLine("Capacity list<int>(): " + kon_1.Capacity);

            List<int> kon_2 = new List<int>(5);
            Console.WriteLine("Capacity list<int>(5): " + kon_2.Capacity);

            int[] tabela_kon3 = new int[] { 4, 2, 1, 5, 6, 8 };
            List<int> kon_3 = new List<int>(tabela_kon3);
            Console.WriteLine("Capacity list<int>(tabela): " + kon_3.Capacity);

            Console.WriteLine("----------------Vstavljanje------------------");

            Console.WriteLine("List preden add(5)");
            IzpisLista(kon_3);
            Console.WriteLine("Vstavimo 5)");
            kon_3.Add(5);
            IzpisLista(kon_3);

            Console.WriteLine("List preden addRange(tabela) tabela = [4, 2, 1]");
            int[] vstav_tabela = new int[] { 4, 2, 1 };
            IzpisLista(kon_3);
            Console.WriteLine("Vstavimo tabelo");
            kon_3.AddRange(vstav_tabela);
            IzpisLista(kon_3);

            Console.WriteLine("List pred vstavitvijo z insert");
            IzpisLista(kon_3);
            kon_3.Insert(4, 42);
            Console.WriteLine("Vstavimo 42 na 5 mesto");
            IzpisLista(kon_3);


            Console.WriteLine("List pred vstavitvijo z indeksom");
            IzpisLista(kon_3);
            kon_3[2] = 42;
            Console.WriteLine("Vstavimo 42 na 2 mesto");
            IzpisLista(kon_3);

            Console.WriteLine("List pred vstavitvijo tabele z insert");
            IzpisLista(kon_3);
            int[] inser_tabela = new int[] { 99, 88, 77 };
            Console.WriteLine("Vstavimo tabelo na 6 mesto");
            kon_3.InsertRange(5, inser_tabela);
            IzpisLista(kon_3);


            Console.WriteLine("-------------Branje podatkov v listu---------------");
            Console.WriteLine("Branje z lastnostjo list[4])");
            Console.WriteLine(kon_3[4]);


            Console.WriteLine("----------------------Foreach---------------------");
            Console.WriteLine("Tabela avtomobilov");
            List<Vozilo> vozila = new List<Vozilo>();
            vozila.Add(new Vozilo("Peugeot", "207", 75));
            vozila.Add(new Vozilo("Citroen", "C3", 60));
            vozila.Add(new Vozilo("Hyundai", "i30N", 220));

            IzpisLista(vozila);

            Console.WriteLine("-------------------Iskanje z LINQ-----------------");

            var iskana = from posamezn in vozila
                         where posamezn.Moc < 100
                         select posamezn;
            
            foreach(Vozilo en in iskana)
            {
                Console.WriteLine(en);
            }

            Console.WriteLine("----------------------Brisanje-----------------------");
            IzpisLista(kon_3);

            Console.WriteLine("Izbrisemo prvo 42ko");
            kon_3.Remove(42);

            IzpisLista(kon_3);

            Console.WriteLine("izbrisemo at indeks 3");

            kon_3.RemoveAt(3);

            IzpisLista(kon_3);

            Console.WriteLine("izbrisemo vse dvojke");
            kon_3.RemoveAll(x => x == 2);

            IzpisLista(kon_3);

            Console.WriteLine("izbrisemo vsa liha");
            kon_3.RemoveAll(liho);

            IzpisLista(kon_3);

            Console.WriteLine("--------------Iskanje-----------------");
            List<int> podatki = new List<int>(new int[]{ 1, 4, 3, 7, 5, 9, 13, 23, 45 });

            Console.WriteLine("Ali vsebuje 3: " + podatki.Contains(3));
            Console.WriteLine("Ali vsebuje 42: " + podatki.Contains(42));

            List<int> lihi = podatki.FindAll(liho);

            Console.WriteLine("Vsi lihi");
            IzpisLista(lihi);

            Console.WriteLine("---------------Reverse--------------------");
            IzpisLista(podatki);

            Console.WriteLine("obrnemo celoten list");
            podatki.Reverse();

            IzpisLista(podatki);

            Console.WriteLine("obrnemo med indeksi 4 in 7");

            podatki.Reverse(4, 4);

            IzpisLista(podatki);

            Console.WriteLine("------------------True for all-----------------");

            Console.WriteLine(podatki.TrueForAll(liho));

            Console.WriteLine("------------------Sortiranje in binary search--------------------");

            Console.WriteLine("tab pred sortiranjem");
            IzpisLista(podatki);

            podatki.Sort();

            Console.WriteLine("tabela po sortiranju");

            IzpisLista(podatki);

            Console.WriteLine("stevilka 6 je na indeksu " + podatki.BinarySearch(100));

            Console.WriteLine("tab pred sortiranjem");
            IzpisLista(vozila);

            vozila.Sort();

            Console.WriteLine("tabela po sortiranju");

            IzpisLista(vozila);

            Console.WriteLine("----------------------Vmesniki-----------------------------------");

            vozila.Add(new Vozilo("Peugeot", "508", 150));
            vozila.Add(new Vozilo("Peugeot", "2008", 90));
            vozila.Add(new Vozilo("Toyota", "Raw4", 170));

            IzpisLista(vozila);

            Console.WriteLine("iskanje peugeojev");

            List<Vozilo> peugeoji = vozila.FindAll(x => x.Equals("Peugeot"));

            IzpisLista(peugeoji);

            vozila.Remove(new Vozilo("Citroen", "", 40));


            Console.WriteLine("izbrisan prvi citroen");
            IzpisLista(vozila);

            vozila.RemoveAll(x => x.Equals("Peugeot"));
            vozila.RemoveAll(x => x.Equals(new Vozilo("Hyundai", "", 100)));

            IzpisLista(vozila);


        }
    }
}
