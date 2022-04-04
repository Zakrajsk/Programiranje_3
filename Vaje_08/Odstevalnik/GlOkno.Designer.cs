
namespace Odstevalnik
{
    partial class GlOkno
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
            this.btnPonastavi = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnUstavi = new System.Windows.Forms.Button();
            this.btnZacni = new System.Windows.Forms.Button();
            this.lblCas = new System.Windows.Forms.Label();
            this.Casovnik = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnPonastavi
            // 
            this.btnPonastavi.Location = new System.Drawing.Point(12, 166);
            this.btnPonastavi.Name = "btnPonastavi";
            this.btnPonastavi.Size = new System.Drawing.Size(86, 46);
            this.btnPonastavi.TabIndex = 0;
            this.btnPonastavi.Text = "Ponastavi";
            this.btnPonastavi.UseVisualStyleBackColor = true;
            this.btnPonastavi.Click += new System.EventHandler(this.PonastaviPritisnjen);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(104, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 46);
            this.button3.TabIndex = 0;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnUstavi
            // 
            this.btnUstavi.Location = new System.Drawing.Point(104, 166);
            this.btnUstavi.Name = "btnUstavi";
            this.btnUstavi.Size = new System.Drawing.Size(86, 46);
            this.btnUstavi.TabIndex = 0;
            this.btnUstavi.Text = "Ustavi";
            this.btnUstavi.UseVisualStyleBackColor = true;
            this.btnUstavi.Click += new System.EventHandler(this.UstaviPritisnjen);
            // 
            // btnZacni
            // 
            this.btnZacni.Location = new System.Drawing.Point(196, 166);
            this.btnZacni.Name = "btnZacni";
            this.btnZacni.Size = new System.Drawing.Size(86, 46);
            this.btnZacni.TabIndex = 0;
            this.btnZacni.Text = "Začni";
            this.btnZacni.UseVisualStyleBackColor = true;
            this.btnZacni.Click += new System.EventHandler(this.ZacniPritisnjen);
            // 
            // lblCas
            // 
            this.lblCas.Font = new System.Drawing.Font("MS UI Gothic", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCas.Location = new System.Drawing.Point(91, 19);
            this.lblCas.Name = "lblCas";
            this.lblCas.Size = new System.Drawing.Size(114, 144);
            this.lblCas.TabIndex = 1;
            this.lblCas.Text = "9";
            // 
            // Casovnik
            // 
            this.Casovnik.Interval = 1000;
            this.Casovnik.Tick += new System.EventHandler(this.CasovniTick);
            // 
            // GlOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 223);
            this.Controls.Add(this.lblCas);
            this.Controls.Add(this.btnZacni);
            this.Controls.Add(this.btnUstavi);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnPonastavi);
            this.Name = "GlOkno";
            this.Text = "Odštevalnik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPonastavi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnUstavi;
        private System.Windows.Forms.Button btnZacni;
        private System.Windows.Forms.Label lblCas;
        private System.Windows.Forms.Timer Casovnik;
    }
}

