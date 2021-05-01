using System;
using System.Collections.Generic;
using System.Linq;

namespace List_T_za_vaje
{
    class Vozilo : IComparable<Vozilo>
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
                if (value < 0)
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

    }
    class Program
    {

        public static void IzpisLista<T>(List<T> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{list[i]}");
            }
        }
        
            static void Main(string[] args)
        {
            string[] tabela_znamk = new string[] { "Peugeot", "Citroen", "Audi", "BMW", "Fiat", "Toyota", "Hyundai", "Opel" };
            Vozilo[] vsa_vozila = new Vozilo[] { new Vozilo("Peugeot", "207", 75), new Vozilo("Citroen", "C3", 60), new Vozilo("Peugeot", "508", 155), new Vozilo("Hyundai", "i30N", 205), new Vozilo("Peugeot", "2008", 90), new Vozilo("Toyota", "Rav4", 150), new Vozilo("Citroen", "Picasso", 80), new Vozilo("Audi", "A4", 105), new Vozilo("BMW", "M4", 205), new Vozilo("Audi", "A1", 95), new Vozilo("Peugeot", "208", 110), new Vozilo("Hyundai", "i10", 40), new Vozilo("Peugeot", "Traveler", 110), new Vozilo("Toyota", "yarris", 55), new Vozilo("Audi", "RS4", 475), new Vozilo("BMW", "530GT", 220), new Vozilo("Hyundai", "i20", 90), new Vozilo("Peugeot", "206", 65), new Vozilo("Citroen", "C4", 75), new Vozilo("Audi", "Q8", 240), new Vozilo("Fiat", "Chroma", 110), new Vozilo("Fiat", "Punto", 45), new Vozilo("Opel", "Meriva", 90), new Vozilo("BMW", "i8", 600) };

            List<Vozilo> garaza = new List<Vozilo>();

            garaza.AddRange(vsa_vozila);

            Console.WriteLine("-----------Po znamkah------------------");

            foreach(string znamka in tabela_znamk)
            {
                Console.WriteLine($"{znamka}: {(garaza.FindAll(x => x.Znamka == znamka).Count)}");
            }


            Console.WriteLine("---------------Brez fiatov z novimi audiji----------------");
            garaza.RemoveAll(x => x.Znamka == "Fiat");
            garaza.AddRange(new Vozilo[] { new Vozilo("Audi", "A4", 105), new Vozilo("Audi", "A4", 105) });



            foreach (string znamka in tabela_znamk)
            {
                Console.WriteLine($"{znamka}: {(garaza.FindAll(x => x.Znamka == znamka).Count)}");
            }


            Console.WriteLine("--------------------------Sortirani----------------------");
            garaza.Sort();
            IzpisLista(garaza);

            Console.WriteLine("------------------------------Nad 200KW-----------------------");

            var mocni = from posamezn in garaza
                        where posamezn.Moc >= 200
                        select posamezn;

            foreach (Vozilo en in mocni)
            {
                Console.WriteLine(en);
            }
            garaza.Clear();
        }
    }
}
