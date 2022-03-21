using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Webclient_Tit
{
    class WebClient
    {
        /// <summary>
        /// Funckija prebere podatke iz spletne strani in vrne seznam besed
        /// </summary>
        /// <param name="url">link do spletne strani</param>
        /// <returns>tabela besed</returns>
        public static string[] ParsePage(string url)
        {
            System.Net.WebClient client = new System.Net.WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            string koda_strani = client.DownloadString(url).Split(new string[] { "</center>" }, StringSplitOptions.None)[1].Split(new string[] { "<hr noshade width=\"80 % \"><br>" }, StringSplitOptions.None)[0];
            //Zamenjamo \n z praznim znakom, da se znebimo novih vrstic
            string brez_novihvrsti = koda_strani.Replace("\n", "");
            //besede so trenutno locene samo se z <br> tako da locimo samo z tem
            string[] besede = brez_novihvrsti.Split(new string[] { "<br>" }, StringSplitOptions.None);

            return besede;
            
        }
        static void Main(string[] args)
        {
            string[] besede = ParsePage("http://bos.zrc-sazu.si/sbsj.html");
            Console.Write("Vnesi iskan niz znakov: ");
            string vnos = Console.ReadLine();
            for (int i = 0; i < besede.Length; i++)
            {
                //preverimo, da lahko naredimo substring, saj ce bi bila beseda krajsa bi dobili error
                if(besede[i].Length > vnos.Length)
                {
                    //Iz besede naredimo delček, ki se zacne na zacetku in je dolg enako kot vnos 
                    string prvi_del = besede[i].Substring(1, vnos.Length);
                    if (prvi_del == vnos)
                    {
                        Console.WriteLine(besede[i]);
                    }
                }
            }     
            
        }
    }
}
