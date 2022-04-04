using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Izmenjava_barv
{
    public partial class Form1 : Form
    {
        string[] tabela_barv = new string[] { "orange", "purple", "green" };
        int[] stevci = new int[3];
        Random rng = new Random();

        /// <summary>
        /// Osvezi stevce barv
        /// </summary>
        public void Osvezi_stevce()
        {
            lbl_oranzna.Text = $"Oranžna: {stevci[0]}";
            lbl_vijolicna.Text = $"Vijolična: {stevci[1]}";
            lbl_zelena.Text = $"Zelena: {stevci[2]}";

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void StartStop_klik(object sender, EventArgs e)
        {
            Casovnik.Enabled = !Casovnik.Enabled;
        }

        private void Osvezitev(object sender, EventArgs e)
        {
            int stevilka = rng.Next(3);
            lbl_barvni.BackColor = Color.FromName(tabela_barv[stevilka]);
            stevci[stevilka]++;
            Osvezi_stevce();
        }
    }
}
