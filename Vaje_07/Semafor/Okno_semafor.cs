using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semafor
{
    public partial class Okno_semafor : Form
    {
        public Okno_semafor()
        {
            InitializeComponent();
        }

        private void gumb_rdeca_Click(object sender, EventArgs e)
        {
            label_barva.BackColor = Color.Red;
        }

        private void gumb_rumena_Click(object sender, EventArgs e)
        {
            label_barva.BackColor = Color.Yellow;
        }

        private void gumb_zelena_Click(object sender, EventArgs e)
        {
            label_barva.BackColor = Color.Green;
        }
    }
}
