namespace N2
{
    partial class frm_glavno
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
            this.lbl_pravokotnik = new System.Windows.Forms.Label();
            this.Casovnik = new System.Windows.Forms.Timer(this.components);
            this.btn_gibanje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_pravokotnik
            // 
            this.lbl_pravokotnik.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_pravokotnik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_pravokotnik.Location = new System.Drawing.Point(10, 10);
            this.lbl_pravokotnik.Name = "lbl_pravokotnik";
            this.lbl_pravokotnik.Size = new System.Drawing.Size(140, 80);
            this.lbl_pravokotnik.TabIndex = 0;
            // 
            // Casovnik
            // 
            this.Casovnik.Tick += new System.EventHandler(this.Casovnik_Tick);
            // 
            // btn_gibanje
            // 
            this.btn_gibanje.Location = new System.Drawing.Point(90, 147);
            this.btn_gibanje.Name = "btn_gibanje";
            this.btn_gibanje.Size = new System.Drawing.Size(113, 64);
            this.btn_gibanje.TabIndex = 1;
            this.btn_gibanje.Text = "Gibanje";
            this.btn_gibanje.UseVisualStyleBackColor = true;
            this.btn_gibanje.Click += new System.EventHandler(this.btn_gibanje_Click);
            // 
            // frm_glavno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 261);
            this.Controls.Add(this.btn_gibanje);
            this.Controls.Add(this.lbl_pravokotnik);
            this.Name = "frm_glavno";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_pravokotnik;
        private System.Windows.Forms.Timer Casovnik;
        private System.Windows.Forms.Button btn_gibanje;
    }
}

