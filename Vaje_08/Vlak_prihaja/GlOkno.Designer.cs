
namespace Vlak_prihaja
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
            this.btnZacni = new System.Windows.Forms.Button();
            this.btnUstavi = new System.Windows.Forms.Button();
            this.picbLeva = new System.Windows.Forms.PictureBox();
            this.picbDesna = new System.Windows.Forms.PictureBox();
            this.Casovnik = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picbLeva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbDesna)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZacni
            // 
            this.btnZacni.Location = new System.Drawing.Point(34, 139);
            this.btnZacni.Name = "btnZacni";
            this.btnZacni.Size = new System.Drawing.Size(124, 63);
            this.btnZacni.TabIndex = 0;
            this.btnZacni.Text = "ZAČNI";
            this.btnZacni.UseVisualStyleBackColor = true;
            this.btnZacni.Click += new System.EventHandler(this.ZacniPritisnjen);
            // 
            // btnUstavi
            // 
            this.btnUstavi.Location = new System.Drawing.Point(245, 139);
            this.btnUstavi.Name = "btnUstavi";
            this.btnUstavi.Size = new System.Drawing.Size(124, 63);
            this.btnUstavi.TabIndex = 0;
            this.btnUstavi.Text = "USTAVI";
            this.btnUstavi.UseVisualStyleBackColor = true;
            this.btnUstavi.Click += new System.EventHandler(this.UstaviPritisnjen);
            // 
            // picbLeva
            // 
            this.picbLeva.BackColor = System.Drawing.Color.White;
            this.picbLeva.Location = new System.Drawing.Point(98, 12);
            this.picbLeva.Name = "picbLeva";
            this.picbLeva.Size = new System.Drawing.Size(100, 100);
            this.picbLeva.TabIndex = 1;
            this.picbLeva.TabStop = false;
            // 
            // picbDesna
            // 
            this.picbDesna.BackColor = System.Drawing.Color.White;
            this.picbDesna.Location = new System.Drawing.Point(204, 12);
            this.picbDesna.Name = "picbDesna";
            this.picbDesna.Size = new System.Drawing.Size(100, 100);
            this.picbDesna.TabIndex = 1;
            this.picbDesna.TabStop = false;
            // 
            // Casovnik
            // 
            this.Casovnik.Interval = 500;
            this.Casovnik.Tick += new System.EventHandler(this.CasovnikTick);
            // 
            // GlOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 232);
            this.Controls.Add(this.picbDesna);
            this.Controls.Add(this.picbLeva);
            this.Controls.Add(this.btnUstavi);
            this.Controls.Add(this.btnZacni);
            this.Name = "GlOkno";
            this.Text = "Vlak prihaja";
            ((System.ComponentModel.ISupportInitialize)(this.picbLeva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbDesna)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZacni;
        private System.Windows.Forms.Button btnUstavi;
        private System.Windows.Forms.PictureBox picbLeva;
        private System.Windows.Forms.PictureBox picbDesna;
        private System.Windows.Forms.Timer Casovnik;
    }
}

