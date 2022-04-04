using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace GUI_filmi
{
    /// <summary>
    /// Razred namenjen upravljanju baze filmov
    /// </summary>
    class BazaFilmov
    {
        SQLiteConnection povezava;

        public BazaFilmov()
        {
            string niz_povezave = @"Data Source=..\..\..\filmi.sqlite; Verrsion=3;";
            SQLiteConnection povezava = new SQLiteConnection(niz_povezave);
            this.povezava = povezava;
        }


        /// <summary>
        /// Vrne imena vseh filmov, ki so izšli podanega leta
        /// </summary>
        /// <param name="leto"></param>
        /// <returns>return string[]</returns>
        public string[] VsiLeta(int leto)
        {
            this.povezava.Open();
            SQLiteCommand ukaz = new SQLiteCommand();
            ukaz.Connection = this.povezava;
            ukaz.CommandText = "SELECT COUNT(naslov) FROM Filmi WHERE leto = @Leto";

            SQLiteParameter parameter = new SQLiteParameter();
            parameter.ParameterName = "@Leto";
            parameter.Value = leto;

            ukaz.Parameters.Add(parameter);

            int st_zadetkov = Convert.ToInt32(ukaz.ExecuteScalar());
            string[] tabela_filmov = new string[st_zadetkov];

            ukaz.CommandText = "SELECT naslov FROM Filmi WHERE leto = @Leto";
            SQLiteDataReader rezultat = ukaz.ExecuteReader();

            int i = 0;
            while (rezultat.Read())
            {
                tabela_filmov[i] = rezultat[0].ToString();
                i++;
            }

            this.povezava.Close();
            return tabela_filmov;
        }

        /// <summary>
        /// Vrne vse podatke filma, ki ima podan naslov
        /// </summary>
        /// <param name="naslov"></param>
        /// <returns>return string[]</returns>
        public string[] PodatkiEnega(string naslov)
        {
            this.povezava.Open();
            SQLiteCommand ukaz = new SQLiteCommand();
            ukaz.Connection = this.povezava;
            ukaz.CommandText = "SELECT * FROM Filmi WHERE naslov = @Naslov";

            SQLiteParameter parameter = new SQLiteParameter();
            parameter.ParameterName = "@Naslov";
            parameter.Value = naslov;

            ukaz.Parameters.Add(parameter);

            SQLiteDataReader rezultat = ukaz.ExecuteReader();
            rezultat.Read();
            string[] podatki = new string[rezultat.VisibleFieldCount];
            for (int i = 0; i < rezultat.VisibleFieldCount; i++)
            {
                podatki[i] = rezultat[i].ToString();
            }
            this.povezava.Close();

            return podatki;
        }
    }
}
