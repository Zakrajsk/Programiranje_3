using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2
{
    public partial class frm_glavno : Form
    {
        private int premik = 10;
        public frm_glavno()
        {
            InitializeComponent();
        }

        private void btn_gibanje_Click(object sender, EventArgs e)
        {
            Casovnik.Enabled = !Casovnik.Enabled;
            if(Casovnik.Enabled == true)
            {
                btn_gibanje.Text = "Ustavi";
            }
            else
            {
                btn_gibanje.Text = "Gibanje";
            }
        }

        private void Casovnik_Tick(object sender, EventArgs e)
        {
            if(lbl_pravokotnik.Left == 160) //ker je dolzina enaka 140
            {
                this.premik -= 5;
            }
            if(lbl_pravokotnik.Left == 10)
            {
                this.premik = 5;
            }

            lbl_pravokotnik.Left += premik;


        }
    }
}
