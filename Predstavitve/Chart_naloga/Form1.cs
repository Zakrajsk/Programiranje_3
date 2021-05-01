using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart_naloga
{
    public partial class Form1 : Form
    {
        Random rng = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_narisi_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(txtbox_x.Text);
                double y = double.Parse(txtbox_y.Text);
                chr_graf.Series[0].Points.AddXY(x, y);
                lbl_napaka.Visible = false;
            }
            catch
            {
                lbl_napaka.Visible = true;
            }
        }

        private void btn_random_Click(object sender, EventArgs e)
        {
            const int max_vrednost = 10;

            double x = rng.NextDouble() * rng.Next(max_vrednost);
            double y = rng.NextDouble() * rng.Next(max_vrednost);

            chr_graf.Series[0].Points.AddXY(x, y);
        }
    }
}
