using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vlak_prihaja
{
    public partial class GlOkno : Form
    {
        public GlOkno()
        {
            InitializeComponent();
        }

        private void ZacniPritisnjen(object sender, EventArgs e)
        {
            picbLeva.BackColor = Color.Red;
            Casovnik.Enabled = true;

        }

        private void UstaviPritisnjen(object sender, EventArgs e)
        {
            picbLeva.BackColor = Color.White;
            picbDesna.BackColor = Color.White;
            Casovnik.Enabled = false;
        }

        private void CasovnikTick(object sender, EventArgs e)
        {
            if (picbLeva.BackColor == Color.Red)
            {
                picbLeva.BackColor = Color.White;
                picbDesna.BackColor = Color.Red;
            }
            else
            {
                picbLeva.BackColor = Color.Red;
                picbDesna.BackColor = Color.White;
            }
        }
    }
}
