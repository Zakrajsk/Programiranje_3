using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stevec_klikov
{
    public partial class Okno_st_klikov : Form
    {
        private int st_klikov = 0;

        public Okno_st_klikov()
        {
            InitializeComponent();
        }

        private void label_st_klikov_Click(object sender, EventArgs e)
        {
            st_klikov++;
            label_st_klikov.Text = "ŠTEVEC KLIKOV " + st_klikov;
        }
    }
}
