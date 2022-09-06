using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrezPovezave
{
    public partial class Form1 : Form
    {
        private BazaNaprav baza = new BazaNaprav();
        public Form1()
        {
            InitializeComponent();
            
            //Naredimo poizvedbo
            this.baza.IzvediUkaz("SELECT naslov, leto FROM filmi");

            //Prikazemo podatke
            dgv_podatki.DataSource = baza.ds.Tables[0];
            
        }

        /// <summary>
        /// Ko uporabnik doda film
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            this.baza.NovFilm(tbx_naslov.Text);
            
        }
    }
}
