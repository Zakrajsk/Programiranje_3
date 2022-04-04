using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

// Ime slike rdečega zmaja: rdeci_zmaj
// Ime slike zelenega zmaja: zeleni_zmaj

// 1.NALOGA

// Na začetku ustvari timer, nato napiši program, v katerem se bosta zmaja srečala. 
// Pri tem upoštevaj, da je rdeči zmaj močnejši in bo premagal zelenega.
// To pokažeš na tak način, da ob srečanju zmajev zeleni zmaj izgine, rdeči pa odleti naprej.
// Zaželeno je, da začetnih položajev zmajev ne spreminjaš.

// Namig: Za premike uporabi kombinacijo: premik.Left in premik.Top
// npr: premik.Left += 1, premik.Top -= 1; 



// 2.NALOGA (dodatek prvi nalogi)

// V Design dodaj še poljubno število diamantov. Najdeš jih v Animacija\Animacija\bin\Debug.
// Za vsakega izmed zmajev naj se v zgornjem levem, oziroma desnem kotu izpiše število diamantov, ki jih je osvojil.
// Sedaj je močnejši tisti zmaj, ki ima več diamantov. Ob srečanju izgine slabši.




namespace Animacija
{
    public partial class Zmaji : Form
    {
        private Random rng = new Random();
        private List<PictureBox> diamanti = new List<PictureBox>();

        public Zmaji()
        {
            InitializeComponent();
            GenerirajDiamante();
            

        }

        public void GenerirajDiamante()
        {
            Size vel = this.Size;
            //generiraj diamante
            for (int i = 0; i < 2 + rng.Next(10); i++)
            {
                PictureBox picbox = new PictureBox();
                picbox.SizeMode = PictureBoxSizeMode.StretchImage;
                picbox.Image = Image.FromFile(@"U:\ZakrajsekGal\Programiranje_3\Vaje_08\Animacije_Benisa\bin\Debug\gif_diamant.gif");
                picbox.Location = new Point(rng.Next(vel.Height), rng.Next(vel.Width));
                picbox.Size = new Size(100, 100);
                //picbox.BackColor = Color.Black;
                diamanti.Add(picbox);

                this.Controls.Add(picbox);

           
            }

        }

        private void CasovnikTick(object sender, EventArgs e)
        {
            rdeci_zmaj.Left -= 2;
            rdeci_zmaj.Top -= 1;

            zeleni_zmaj.Left += 2;
            zeleni_zmaj.Top += 1;

            if (rdeci_zmaj.Bounds.IntersectsWith(zeleni_zmaj.Bounds))
            {
                zeleni_zmaj.Hide();
            }
        }
    }
}
