
namespace Zadani_sodo
{
    partial class ZadaniSodo
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
            this.btn_sodo = new System.Windows.Forms.Button();
            this.lblTocke = new System.Windows.Forms.Label();
            this.lblStKlikov = new System.Windows.Forms.Label();
            this.Casovnik = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_sodo
            // 
            this.btn_sodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sodo.Location = new System.Drawing.Point(46, 30);
            this.btn_sodo.Name = "btn_sodo";
            this.btn_sodo.Size = new System.Drawing.Size(106, 98);
            this.btn_sodo.TabIndex = 0;
            this.btn_sodo.Text = "0";
            this.btn_sodo.UseVisualStyleBackColor = true;
            this.btn_sodo.Click += new System.EventHandler(this.BtnSodoClick);
            // 
            // lblTocke
            // 
            this.lblTocke.AutoSize = true;
            this.lblTocke.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTocke.Location = new System.Drawing.Point(29, 149);
            this.lblTocke.Name = "lblTocke";
            this.lblTocke.Size = new System.Drawing.Size(83, 24);
            this.lblTocke.TabIndex = 1;
            this.lblTocke.Text = "Točke: 0";
            // 
            // lblStKlikov
            // 
            this.lblStKlikov.AutoSize = true;
            this.lblStKlikov.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStKlikov.Location = new System.Drawing.Point(29, 184);
            this.lblStKlikov.Name = "lblStKlikov";
            this.lblStKlikov.Size = new System.Drawing.Size(136, 24);
            this.lblStKlikov.TabIndex = 2;
            this.lblStKlikov.Text = "Število klikov: 0";
            // 
            // Casovnik
            // 
            this.Casovnik.Enabled = true;
            this.Casovnik.Interval = 250;
            this.Casovnik.Tick += new System.EventHandler(this.CasovnikTick);
            // 
            // ZadaniSodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 217);
            this.Controls.Add(this.lblStKlikov);
            this.Controls.Add(this.lblTocke);
            this.Controls.Add(this.btn_sodo);
            this.Name = "ZadaniSodo";
            this.Text = "Zadani sodo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sodo;
        private System.Windows.Forms.Label lblTocke;
        private System.Windows.Forms.Label lblStKlikov;
        private System.Windows.Forms.Timer Casovnik;
    }
}

