using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Risanje_Martina
{
    public partial class RisanjeOkno : Form
    {
        public RisanjeOkno()
        {
            InitializeComponent();
        }

        private void Naloga1_Click(object sender, EventArgs e)
        {
           
            Graphics platno = RisalnoPano.CreateGraphics();
            platno.Clear(Color.White);

            Pen pisalo = new Pen(Color.Red, 20);

            platno.DrawEllipse(pisalo, 100, 100, 200, 200);
            pisalo.Color = Color.Green;
            platno.DrawEllipse(pisalo, 50, 50, 300, 300);

        }

        private void Naloga2_Click(object sender, EventArgs e)
        {
            Graphics platno = RisalnoPano.CreateGraphics();
            platno.Clear(Color.White);
            Size vel = RisalnoPano.Size;

            SolidBrush pisalo = new SolidBrush(Color.Green);
            PointF[] zelen_trikotnik = new PointF[] { new Point(0, 0), new Point(vel.Width, 0), new Point(vel.Width, vel.Height / 2) };
            platno.FillPolygon(pisalo, zelen_trikotnik);

            PointF[] zelen_trikotnik2 = new PointF[] { new Point(0, vel.Height), new Point(vel.Width, vel.Height / 2), new Point(vel.Width, vel.Height) };
            platno.FillPolygon(pisalo, zelen_trikotnik2);

            pisalo.Color = Color.Yellow;
            PointF[] rumen_trikotnik = new PointF[] { new PointF(0, vel.Height * 0.05F), new PointF(0, vel.Height * 0.95F), new PointF(vel.Width * 0.9F, vel.Height / 2)};
            platno.FillPolygon(pisalo, rumen_trikotnik);

            pisalo.Color = Color.Black;
            PointF[] crn_trikotnik = new PointF[] { new PointF(0, 0), new PointF(0, vel.Height), new PointF(vel.Width * 0.6F, vel.Height / 2) };
            platno.FillPolygon(pisalo, crn_trikotnik);

            pisalo.Color = Color.Red;
            PointF[] rdec_trikotnik = new PointF[] { new PointF(0, vel.Height * 0.1F), new PointF(0, vel.Height * 0.9F), new PointF(vel.Width * 0.5F, vel.Height / 2) };
            platno.FillPolygon(pisalo, rdec_trikotnik);

        }

        private void Naloga3_Click(object sender, EventArgs e)
        {
            Graphics platno = RisalnoPano.CreateGraphics();
            platno.Clear(Color.White);

            SolidBrush pisalo = new SolidBrush(Color.Black);

            platno.FillEllipse(pisalo, 100, 150, 200, 200);
            platno.FillEllipse(pisalo, 50, 75, 120, 120);
            platno.FillEllipse(pisalo, 225, 75, 120, 120);

        }
    }
}
