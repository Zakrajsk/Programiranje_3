using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace GUI_Nobel
{
    /// <summary>
    /// Razred za delanje z bazo prejetih nobelovih nagrad
    /// </summary>
    class BazaNobel
    {
        NpgsqlConnection povezava;
        Dictionary<string, string> prevodi = new Dictionary<string, string>();

        public BazaNobel()
        {
            string niz_povezave = "Server= baza.fmf.uni-lj.si; User Id= student11; Password= student; Database= nobel2012;";
            this.povezava = new NpgsqlConnection(niz_povezave);

            prevodi.Add("Medicine", "Medicina");
            prevodi.Add("Chemistry", "Kemija");
            prevodi.Add("Physics", "Fizika");
            prevodi.Add("Economics", "Ekonomija");
            prevodi.Add("Literature", "Literatura");
            prevodi.Add("Peace", "Mir");
        }

        /// <summary>
        /// Vrne vsa podana podrocja v bazi z nobelovimi nagradami
        /// </summary>
        /// <returns>return string[]</returns>
        public string[] VsaPodrocja()
        {
            this.povezava.Open();
            NpgsqlCommand ukaz = new NpgsqlCommand();
            ukaz.Connection = this.povezava;

            ukaz.CommandType = CommandType.Text;
            ukaz.CommandText = "SELECT count(DISTINCT subject) FROM nobel";
            int st_vrstic = Convert.ToInt32(ukaz.ExecuteScalar());
            string[] tabela_podrocij = new string[st_vrstic];

            ukaz.CommandText = "SELECT DISTINCT subject FROM nobel";
            NpgsqlDataReader rezultat = ukaz.ExecuteReader();

            string prevod;
            int i = 0;
            while (rezultat.Read())
            {
                prevod = rezultat[0].ToString();
                prevodi.TryGetValue(rezultat[0].ToString(), out prevod);
                tabela_podrocij[i] = prevod;
                i++;
            }

            this.povezava.Close();
            return tabela_podrocij;
        }

        /// <summary>
        /// Vrne vse dobitnike nobelovih nagrad z podanimi letnicami na nacin "ime priimek letnica"
        /// Katere je odvisno od parametrov in sicer ce so podani zac in kon vrne vse dobitnike med temi leti
        /// Ce je podana vrsta nagrade vrne samo tiste z to vrsto nagrade
        /// Ce so podani vsi vrne samo dobitnike te vrste nagrade v danem casovnem odbodnju
        /// </summary>
        /// <param name="zac"></param>
        /// <param name="kon"></param>
        /// <param name="vrsta_nagrade"></param>
        /// <returns></returns>
        public string[] VsiNagrajenciZOmejitvami(int zac, int kon, string vrsta_nagrade)
        {
            this.povezava.Open();
            NpgsqlCommand ukaz = new NpgsqlCommand();
            ukaz.Connection = this.povezava;
            string del_ukaza = "";

            if(zac != -1)
            {
                del_ukaza += "yr >= @Zacetek";
                NpgsqlParameter par_zac = new NpgsqlParameter();
                par_zac.ParameterName = "@Zacetek";
                par_zac.Value = zac;
                ukaz.Parameters.Add(par_zac);
            }
            if(kon != -1)
            {
                del_ukaza += del_ukaza != "" ? " AND yr <= @Konec" : "yr <= @Konec";
                NpgsqlParameter par_kon = new NpgsqlParameter();
                par_kon.ParameterName = "@Konec";
                par_kon.Value = kon;
                ukaz.Parameters.Add(par_kon);
            }
            if(vrsta_nagrade != null)
            {
                del_ukaza += del_ukaza != "" ? " AND subject = @Vrsta" : "subject = @Vrsta";
                NpgsqlParameter par_vrsta = new NpgsqlParameter();
                par_vrsta.ParameterName = "@Vrsta";

                //iskanje prevoda
                string najden_prevod = "";
                foreach (KeyValuePair<string, string> en in prevodi)
                {
                    if (en.Value == vrsta_nagrade)
                    {
                        najden_prevod = en.Key; 
                    }
                }

                par_vrsta.Value = najden_prevod;
                ukaz.Parameters.Add(par_vrsta);
            }
            string celoten_ukaz;
            if(del_ukaza != "")
            {
                celoten_ukaz = "SELECT count(*) FROM nobel WHERE " + del_ukaza;
            }
            else
            {
                celoten_ukaz = "SELECT count(*) FROM nobel";
            }
            ukaz.CommandType = CommandType.Text;
            ukaz.CommandText = celoten_ukaz;
            int st_vrstic = Convert.ToInt32(ukaz.ExecuteScalar());
            string[] tabela_nagrajencev = new string[st_vrstic];

            if (del_ukaza != "")
            {
                celoten_ukaz = "SELECT * FROM nobel WHERE " + del_ukaza;
            }
            else
            {
                celoten_ukaz = "SELECT * FROM nobel";
            }

            ukaz.CommandText = celoten_ukaz;
            NpgsqlDataReader rezultat = ukaz.ExecuteReader();

            int i = 0;
            string prevod;
            while (rezultat.Read())
            {
                prevod = prevodi[rezultat[1].ToString()];
                tabela_nagrajencev[i] = $"{rezultat[2]} Področje: {prevod} Leta: {rezultat[0]}";
                i++;
            }

            this.povezava.Close();
            return tabela_nagrajencev;
        }
    }
}
