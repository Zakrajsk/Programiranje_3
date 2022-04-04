using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadani_sodo
{
    public partial class ZadaniSodo : Form
    {
        public ZadaniSodo()
        {
            InitializeComponent();
        }

        private void CasovnikTick(object sender, EventArgs e)
        {
            int trenutno = int.Parse(btn_sodo.Text);
            btn_sodo.Text = (trenutno + 1).ToString();
        }

        private void BtnSodoClick(object sender, EventArgs e)
        {
            int st_klikov = int.Parse(lblStKlikov.Text.Split(':')[1]);
            int stevilo = int.Parse(btn_sodo.Text);
            if (stevilo % 2 == 0)
            {
                //Zadeli smo sodo stevilo
                int trenutne_tocke = int.Parse(lblTocke.Text.Split(':')[1]);
                lblTocke.Text = "Točke: " + (trenutne_tocke + 1);
            }
            lblStKlikov.Text = "Število klikov: " + (st_klikov + 1).ToString();

        }
    }
}
