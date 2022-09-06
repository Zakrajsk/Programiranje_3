using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace BrezPovezave
{
    class BazaNaprav
    {
        private string lokacija_baze = @"C:\Users\galza\Desktop\Faks\Programiranje_3\Vaje_10\BrezPovezave\filmi.sqlite";
        SQLiteDataAdapter data_adapter;

        public DataSet ds
        {
            get;
            set;
        }


        /// <summary>
        /// Izvedemo sql ukaz in shranimo vse podatke iz baze v dataset
        /// </summary>
        /// <param name="sql_ukaz"></param>
        public void IzvediUkaz(string sql_ukaz)
        {
            //Povezemo bazo
            SQLiteConnection povezi = new SQLiteConnection("Data source=" + lokacija_baze);
            //Izvedemo ukaz
            this.data_adapter = new SQLiteDataAdapter(sql_ukaz, povezi);

            this.ds = new DataSet();
            //Prenesemo vse podatke v naše tabele v programu
            data_adapter.Fill(this.ds);
        }

        /// <summary>
        /// Dodamo nov film v bazo
        /// </summary>
        /// <param name="ime"></param>
        public void NovFilm(string ime)
        {
            //Dodajanje nove vrstice
            DataRow vrsta = ds.Tables[0].NewRow();
            vrsta["naslov"] = ime;

            ds.Tables[0].Rows.Add(vrsta);
        }

        /// <summary>
        /// Prenesemo vse spremembe v bazo
        /// </summary>
        public void PrenesiSpremembe()
        {
            this.data_adapter.Update(this.ds);
        }
            
    }


}
