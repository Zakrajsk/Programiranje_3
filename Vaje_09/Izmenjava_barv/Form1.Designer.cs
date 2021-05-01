
namespace Izmenjava_barv
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_barvni = new System.Windows.Forms.Label();
            this.Casovnik = new System.Windows.Forms.Timer(this.components);
            this.lbl_oranzna = new System.Windows.Forms.Label();
            this.lbl_vijolicna = new System.Windows.Forms.Label();
            this.lbl_zelena = new System.Windows.Forms.Label();
            this.btn_start_stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_barvni
            // 
            this.lbl_barvni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_barvni.Location = new System.Drawing.Point(12, 9);
            this.lbl_barvni.Name = "lbl_barvni";
            this.lbl_barvni.Size = new System.Drawing.Size(180, 180);
            this.lbl_barvni.TabIndex = 0;
            // 
            // Casovnik
            // 
            this.Casovnik.Enabled = true;
            this.Casovnik.Interval = 500;
            this.Casovnik.Tick += new System.EventHandler(this.Osvezitev);
            // 
            // lbl_oranzna
            // 
            this.lbl_oranzna.AutoSize = true;
            this.lbl_oranzna.Location = new System.Drawing.Point(199, 13);
            this.lbl_oranzna.Name = "lbl_oranzna";
            this.lbl_oranzna.Size = new System.Drawing.Size(83, 20);
            this.lbl_oranzna.TabIndex = 1;
            this.lbl_oranzna.Text = "Oranžna: 0 ";
            // 
            // lbl_vijolicna
            // 
            this.lbl_vijolicna.AutoSize = true;
            this.lbl_vijolicna.Location = new System.Drawing.Point(199, 49);
            this.lbl_vijolicna.Name = "lbl_vijolicna";
            this.lbl_vijolicna.Size = new System.Drawing.Size(81, 20);
            this.lbl_vijolicna.TabIndex = 2;
            this.lbl_vijolicna.Text = "Vijolična: 0";
            // 
            // lbl_zelena
            // 
            this.lbl_zelena.AutoSize = true;
            this.lbl_zelena.Location = new System.Drawing.Point(199, 87);
            this.lbl_zelena.Name = "lbl_zelena";
            this.lbl_zelena.Size = new System.Drawing.Size(69, 20);
            this.lbl_zelena.TabIndex = 3;
            this.lbl_zelena.Text = "Zelena: 0";
            // 
            // btn_start_stop
            // 
            this.btn_start_stop.Location = new System.Drawing.Point(299, 126);
            this.btn_start_stop.Name = "btn_start_stop";
            this.btn_start_stop.Size = new System.Drawing.Size(100, 63);
            this.btn_start_stop.TabIndex = 4;
            this.btn_start_stop.Text = "Start / Stop";
            this.btn_start_stop.UseVisualStyleBackColor = true;
            this.btn_start_stop.Click += new System.EventHandler(this.StartStop_klik);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 206);
            this.Controls.Add(this.btn_start_stop);
            this.Controls.Add(this.lbl_zelena);
            this.Controls.Add(this.lbl_vijolicna);
            this.Controls.Add(this.lbl_oranzna);
            this.Controls.Add(this.lbl_barvni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_barvni;
        private System.Windows.Forms.Timer Casovnik;
        private System.Windows.Forms.Label lbl_oranzna;
        private System.Windows.Forms.Label lbl_vijolicna;
        private System.Windows.Forms.Label lbl_zelena;
        private System.Windows.Forms.Button btn_start_stop;
    }
}

