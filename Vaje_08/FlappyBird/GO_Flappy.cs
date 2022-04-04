using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class GO_Flappy : Form
    {
        const int ENOTAGORDOL = 15;
        const int ZAC_HITROST = 8;
        const int ZAMIK_LEVO = -100;
        const int ZAMIK_DESNO = 50;
        int premik_gordol = 0;
        int premik_levodesno = 0;
        int hitrost = ZAC_HITROST;
        int tocke = 0;

        public GO_Flappy()
        {
            InitializeComponent();
        }

        private void tipkaDol(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                premik_gordol = -ENOTAGORDOL;
            }

            if (e.KeyCode == Keys.Down)
            {
                premik_gordol = ENOTAGORDOL;
            }

            if (e.KeyCode == Keys.Left)
            {
                premik_levodesno = -ENOTAGORDOL;
            }

            if (e.KeyCode == Keys.Right)
            {
                premik_levodesno = ENOTAGORDOL;
            }
        }

        private void tipkaGor(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left)
            {
                premik_levodesno = 0;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                premik_gordol = 0;
            }
        }

        private void timerIgra_Tick(object sender, EventArgs e)
        {
            // premaknemo ptiča
            ptic.Top += premik_gordol;
            ptic.Left += premik_levodesno;
            oviraDol.Left -= hitrost;
            oviraGor.Left -= hitrost;

            if(oviraDol.Top > ptic.Top)
            {
                oviraDol.Top -= 1;
            }

            if (oviraDol.Top < ptic.Top)
            {
                oviraDol.Top += 1;
            }


            // ko smo dovolj levo, gremo na desni rob
            if (oviraDol.Left < ZAMIK_LEVO)
            {
                oviraDol.Left = this.Width + ZAMIK_DESNO;
                hitrost += 2;
                tocke++;
            }
            if (oviraGor.Left < ZAMIK_LEVO - 30)
            {
                oviraGor.Left = this.Width + ZAMIK_DESNO + 50;
                tocke++;
            }
            lbl_tocke.Text = tocke.ToString();

            if (ptic.Bounds.IntersectsWith(tla.Bounds) ||
                ptic.Bounds.IntersectsWith(oviraDol.Bounds) ||
                ptic.Bounds.IntersectsWith(oviraGor.Bounds) ||
                ptic.Top < -20 || ptic.Left < -20 || ptic.Left > this.Width - 20)
            {
                konecIgre();
            }
        }

        private void konecIgre()
        {
            timerIgra.Stop();
            konec.Text = "KONEC IGRE";
        }

        private void GO_Flappy_Load(object sender, EventArgs e)
        {

        }
    }
}

