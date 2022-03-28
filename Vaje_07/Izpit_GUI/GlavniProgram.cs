using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Izpit_GUI
{
    public partial class Form1 : Form
    {
        private static Color[] barve = new Color[] { Color.Red, Color.Green, Color.Blue };
        private static Random rng = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Pobarvaj(object sender, EventArgs e)
        {
            Panel izbran = (Panel)sender;
             Color nova_barva = barve[rng.Next(barve.Length)];
            izbran.BackColor = nova_barva;
        }
    }
}
