using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Levi_in_desni
{
    public partial class Okno_LD : Form
    {
        public Okno_LD()
        {
            InitializeComponent();
        }

        private void gumb_levo_MouseDown(object sender, MouseEventArgs e)
        {
            label_kam_kaze.Text = "<- pritisnjen";
        }

        private void gumb_levo_MouseUp(object sender, MouseEventArgs e)
        {
            label_kam_kaze.Text = "";
        }

        private void gumb_desni_MouseDown(object sender, MouseEventArgs e)
        {
            label_kam_kaze.Text = "pritisnjen ->";
        }

        private void gumb_desni_MouseUp(object sender, MouseEventArgs e)
        {
            label_kam_kaze.Text = "";
        }
    }
}
