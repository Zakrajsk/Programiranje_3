using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_filmi
{
    public partial class Form1 : Form
    {
        BazaFilmov baza;

        public Form1()
        {
            InitializeComponent();
            this.baza = new BazaFilmov();
        }

        private void gumb_prikazi_MouseClick(object sender, MouseEventArgs e)
        {
            int leto = 0;
            try
            {
                leto = int.Parse(txtbox_katero_leto.Text);
                lbl_napacen_vnos.Text = "";
            }
            catch
            {
                lbl_napacen_vnos.Text = "Napačen vnos!";
                lbl_navodilo.Visible = false;
            }
            list_filmov.Items.Clear();
            string[] vsi = this.baza.VsiLeta(leto);
            if(vsi.Length == 0)
            {
                list_filmov.Items.Add("NOBEN FILM NI BIL POSNET TEGA LETA");
            }
            else
            {
                list_filmov.Items.AddRange(vsi);
                lbl_navodilo.Visible = true;
            }

        }

        private void list_filmov_SelectedIndexChanged(object sender, EventArgs e)
        {
            string izbran_naslov = (string)list_filmov.SelectedItem;
            string[] podatki = this.baza.PodatkiEnega(izbran_naslov);
            //podatki: 0 - id, 1 - naslov, 2 - leto, 3 - reziser, 4 - certifikat, 5 - dolzina, 6 - ocena
            lbl_naslov.Text = podatki[1];
            lbl_leto.Text = podatki[2];
            lbl_reziser.Text = podatki[3];
            lbl_certifikat.Text = podatki[4];
            lbl_dolzina.Text = podatki[5];
            lbl_ocena.Text = podatki[6];
        }
    }
}
