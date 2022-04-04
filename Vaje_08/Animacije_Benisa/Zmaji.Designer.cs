
namespace Animacija
{
    partial class Zmaji
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zmaji));
            this.zeleni_zmaj = new System.Windows.Forms.PictureBox();
            this.rdeci_zmaj = new System.Windows.Forms.PictureBox();
            this.Casovnik = new System.Windows.Forms.Timer(this.components);
            this.lblDiamantiZelen = new System.Windows.Forms.Label();
            this.lblDiamantiRdec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zeleni_zmaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdeci_zmaj)).BeginInit();
            this.SuspendLayout();
            // 
            // zeleni_zmaj
            // 
            this.zeleni_zmaj.Image = ((System.Drawing.Image)(resources.GetObject("zeleni_zmaj.Image")));
            this.zeleni_zmaj.Location = new System.Drawing.Point(9, 10);
            this.zeleni_zmaj.Margin = new System.Windows.Forms.Padding(2);
            this.zeleni_zmaj.Name = "zeleni_zmaj";
            this.zeleni_zmaj.Size = new System.Drawing.Size(158, 146);
            this.zeleni_zmaj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zeleni_zmaj.TabIndex = 0;
            this.zeleni_zmaj.TabStop = false;
            // 
            // rdeci_zmaj
            // 
            this.rdeci_zmaj.Image = ((System.Drawing.Image)(resources.GetObject("rdeci_zmaj.Image")));
            this.rdeci_zmaj.Location = new System.Drawing.Point(720, 365);
            this.rdeci_zmaj.Margin = new System.Windows.Forms.Padding(2);
            this.rdeci_zmaj.Name = "rdeci_zmaj";
            this.rdeci_zmaj.Size = new System.Drawing.Size(139, 110);
            this.rdeci_zmaj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rdeci_zmaj.TabIndex = 1;
            this.rdeci_zmaj.TabStop = false;
            // 
            // Casovnik
            // 
            this.Casovnik.Enabled = true;
            this.Casovnik.Interval = 10;
            this.Casovnik.Tick += new System.EventHandler(this.CasovnikTick);
            // 
            // lblDiamantiZelen
            // 
            this.lblDiamantiZelen.AutoSize = true;
            this.lblDiamantiZelen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiamantiZelen.Location = new System.Drawing.Point(243, 6);
            this.lblDiamantiZelen.Name = "lblDiamantiZelen";
            this.lblDiamantiZelen.Size = new System.Drawing.Size(158, 20);
            this.lblDiamantiZelen.TabIndex = 2;
            this.lblDiamantiZelen.Text = "Diamanti zelenega: 0";
            // 
            // lblDiamantiRdec
            // 
            this.lblDiamantiRdec.AutoSize = true;
            this.lblDiamantiRdec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiamantiRdec.Location = new System.Drawing.Point(452, 6);
            this.lblDiamantiRdec.Name = "lblDiamantiRdec";
            this.lblDiamantiRdec.Size = new System.Drawing.Size(151, 20);
            this.lblDiamantiRdec.TabIndex = 2;
            this.lblDiamantiRdec.Text = "Diamanti rdecega: 0";
            // 
            // Zmaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 497);
            this.Controls.Add(this.lblDiamantiRdec);
            this.Controls.Add(this.lblDiamantiZelen);
            this.Controls.Add(this.rdeci_zmaj);
            this.Controls.Add(this.zeleni_zmaj);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Zmaji";
            this.Text = "Zmaji";
            ((System.ComponentModel.ISupportInitialize)(this.zeleni_zmaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdeci_zmaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox zeleni_zmaj;
        private System.Windows.Forms.PictureBox rdeci_zmaj;
        private System.Windows.Forms.Timer Casovnik;
        private System.Windows.Forms.Label lblDiamantiZelen;
        private System.Windows.Forms.Label lblDiamantiRdec;
    }
}

