
namespace BrezPovezave
{
    partial class Form1
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
            this.dgv_podatki = new System.Windows.Forms.DataGridView();
            this.tbx_naslov = new System.Windows.Forms.TextBox();
            this.btn_dodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_podatki)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_podatki
            // 
            this.dgv_podatki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_podatki.Location = new System.Drawing.Point(12, 12);
            this.dgv_podatki.Name = "dgv_podatki";
            this.dgv_podatki.RowHeadersWidth = 51;
            this.dgv_podatki.RowTemplate.Height = 24;
            this.dgv_podatki.Size = new System.Drawing.Size(523, 426);
            this.dgv_podatki.TabIndex = 1;
            // 
            // tbx_naslov
            // 
            this.tbx_naslov.Location = new System.Drawing.Point(592, 37);
            this.tbx_naslov.Name = "tbx_naslov";
            this.tbx_naslov.Size = new System.Drawing.Size(149, 22);
            this.tbx_naslov.TabIndex = 2;
            this.tbx_naslov.Text = "Naslov novega filma";
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Location = new System.Drawing.Point(606, 78);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(111, 64);
            this.btn_dodaj.TabIndex = 3;
            this.btn_dodaj.Text = "Dodaj film";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.tbx_naslov);
            this.Controls.Add(this.dgv_podatki);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_podatki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_podatki;
        private System.Windows.Forms.TextBox tbx_naslov;
        private System.Windows.Forms.Button btn_dodaj;
    }
}

