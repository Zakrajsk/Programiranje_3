using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slovar_Don
{
    class BoljsiSlovar<TKey, TValue> : Dictionary<TKey, TValue>
    {
        public BoljsiSlovar() : base() { }
        public BoljsiSlovar(BoljsiSlovar<TKey, TValue> prvo) : base(prvo) { }

        /// <summary>
        /// Metoda TryAdd vrne true, če ključ in vrednost uspešno doda v slovar in false sicer.
        /// </summary>
        /// <param name="kljuc">kljuc v slovarju</param>
        /// <param name="vrednost">vrednost v slovarju</param>
        /// <returns>vrne bool</returns>
        public bool TryAdd(TKey kljuc, TValue vrednost)
        {
            try
            {
                this.Add(kljuc, vrednost);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Metoda Remove pa ključ iz slovarja odstrani ter vrednost shrani v tisto
        /// spremenljivko, ki jo podamo kot out argument.Če ključa, ki ga želimo odstraniti,
        /// ni v slovarju, se ne zgodi nič.
        /// </summary>
        /// <param name="kljuc"></param>
        /// <param name="vrednost"></param>
        public void Remove(TKey kljuc, ref TValue vrednost)
        {
            if (this.ContainsKey(kljuc))
            {
                vrednost = this[kljuc];
                this.Remove(kljuc);
            }
        }


        public static BoljsiSlovar<TKey, TValue> zdruzi(BoljsiSlovar<TKey, TValue> prvi, BoljsiSlovar<TKey, TValue> drugi)
        {
            BoljsiSlovar<TKey, TValue> koncni = new BoljsiSlovar<TKey, TValue>(prvi);
            foreach (KeyValuePair<TKey, TValue> el in drugi)
            {
                koncni.TryAdd(el.Key, el.Value);
            }
            return koncni;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BoljsiSlovar<string, string> prvi = new BoljsiSlovar<string, string>();
            prvi["Janez"] = "35";
            prvi["bonboni"] = "avto";

            BoljsiSlovar<string, string> drugi = new BoljsiSlovar<string, string>();
            drugi["očala"] = "miza";
            drugi["Janez"] = "bager";
            drugi["šah"] = "mat";

            BoljsiSlovar<string, string> zdruzen = BoljsiSlovar<string, string>.zdruzi(prvi, drugi);
            foreach (KeyValuePair<string, string> el in zdruzen)
            {
                Console.WriteLine(el);
            }
            
        }
    }
}
