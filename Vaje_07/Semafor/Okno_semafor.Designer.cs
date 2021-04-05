
namespace Semafor
{
    partial class Okno_semafor
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
            this.gumb_rdeca = new System.Windows.Forms.Button();
            this.gumb_rumena = new System.Windows.Forms.Button();
            this.gumb_zelena = new System.Windows.Forms.Button();
            this.label_barva = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gumb_rdeca
            // 
            this.gumb_rdeca.Location = new System.Drawing.Point(24, 19);
            this.gumb_rdeca.Name = "gumb_rdeca";
            this.gumb_rdeca.Size = new System.Drawing.Size(94, 29);
            this.gumb_rdeca.TabIndex = 0;
            this.gumb_rdeca.Text = "Rdeča";
            this.gumb_rdeca.UseVisualStyleBackColor = true;
            this.gumb_rdeca.Click += new System.EventHandler(this.gumb_rdeca_Click);
            // 
            // gumb_rumena
            // 
            this.gumb_rumena.Location = new System.Drawing.Point(24, 76);
            this.gumb_rumena.Name = "gumb_rumena";
            this.gumb_rumena.Size = new System.Drawing.Size(94, 29);
            this.gumb_rumena.TabIndex = 1;
            this.gumb_rumena.Text = "Rumena";
            this.gumb_rumena.UseVisualStyleBackColor = true;
            this.gumb_rumena.Click += new System.EventHandler(this.gumb_rumena_Click);
            // 
            // gumb_zelena
            // 
            this.gumb_zelena.Location = new System.Drawing.Point(24, 132);
            this.gumb_zelena.Name = "gumb_zelena";
            this.gumb_zelena.Size = new System.Drawing.Size(94, 29);
            this.gumb_zelena.TabIndex = 2;
            this.gumb_zelena.Text = "Zelena";
            this.gumb_zelena.UseVisualStyleBackColor = true;
            this.gumb_zelena.Click += new System.EventHandler(this.gumb_zelena_Click);
            // 
            // label_barva
            // 
            this.label_barva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_barva.Location = new System.Drawing.Point(143, 19);
            this.label_barva.Name = "label_barva";
            this.label_barva.Size = new System.Drawing.Size(146, 142);
            this.label_barva.TabIndex = 3;
            // 
            // Okno_semafor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 187);
            this.Controls.Add(this.label_barva);
            this.Controls.Add(this.gumb_zelena);
            this.Controls.Add(this.gumb_rumena);
            this.Controls.Add(this.gumb_rdeca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Okno_semafor";
            this.Text = "Semafor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gumb_rdeca;
        private System.Windows.Forms.Button gumb_rumena;
        private System.Windows.Forms.Button gumb_zelena;
        private System.Windows.Forms.Label label_barva;
    }
}

