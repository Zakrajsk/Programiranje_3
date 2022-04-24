using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Nobel
{
    public partial class gui_nobel : Form
    {
        BazaNobel baza;

        public gui_nobel()
        {
            InitializeComponent();
            this.baza = new BazaNobel();
        }

        private void gui_nobel_Load(object sender, EventArgs e)
        {
            string[] podrocja = baza.VsaPodrocja();
            listbox_podrocja.Items.AddRange(podrocja);
            listbox_podrocja.Items.Add("");
        }

        private void gmb_osvezi_Click(object sender, EventArgs e)
        {
            lbl_napaka_vnos.Visible = false;
            int zacetek = -1, konec = -1;
            string vrsta = (string) listbox_podrocja.SelectedItem;
            listbox_podrocja.ClearSelected();
            if(vrsta == "")
            {
                vrsta = null;
            }
            try
            {
                zacetek = int.Parse(txtbox_zacetek.Text);
                konec = int.Parse(txtbox_konec.Text);
            }
            catch
            {
                lbl_napaka_vnos.Visible = true;
            }
            
            listbox_nagrajenci.Items.Clear();
            string[] nagrajenci = baza.VsiNagrajenciZOmejitvami(zacetek, konec, vrsta);
            if(nagrajenci.Length == 0)
            {
                listbox_nagrajenci.Items.Add("Ni nagrajencev");
            }
            else
            {
                listbox_nagrajenci.Items.AddRange(nagrajenci);
            }
        }
    }
}
