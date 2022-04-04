using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odstevalnik
{
    public partial class GlOkno : Form
    {
        public GlOkno()
        {
            InitializeComponent();
        }

        private void ZacniPritisnjen(object sender, EventArgs e)
        {
            Casovnik.Enabled = true;
        }

        private void UstaviPritisnjen(object sender, EventArgs e)
        {
            Casovnik.Enabled = false;
        }

        private void PonastaviPritisnjen(object sender, EventArgs e)
        {
            lblCas.Text = "9";
        }

        private void CasovniTick(object sender, EventArgs e)
        {
            int trenutno = int.Parse(lblCas.Text);
            if (trenutno <= 0)
            {
                lblCas.Text = "9";
            }
            else
            {
                lblCas.Text = (trenutno - 1).ToString();
            }
        }
    }
}
