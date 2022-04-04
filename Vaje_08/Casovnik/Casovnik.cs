using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casovnik
{
    public partial class Casovnik : Form
    {
        public int cas = 0;
        public Casovnik()
        {
            InitializeComponent();
        }

        private void Stej(object sender, EventArgs e)
        {
            cas++;
            lbl_cas.Text = (cas / 10.0).ToString();
        }

        private void StartStopKlik(object sender, EventArgs e)
        {
            casovnik.Enabled = !casovnik.Enabled;
        }
    }
}
