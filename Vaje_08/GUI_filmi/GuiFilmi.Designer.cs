
namespace GUI_filmi
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
            this.gumb_prikazi = new System.Windows.Forms.Button();
            this.list_filmov = new System.Windows.Forms.ListBox();
            this.txtbox_katero_leto = new System.Windows.Forms.TextBox();
            this.lbl_katero_leto = new System.Windows.Forms.Label();
            this.lbl_napacen_vnos = new System.Windows.Forms.Label();
            this.lbl_fix_naslov = new System.Windows.Forms.Label();
            this.lbl_naslov = new System.Windows.Forms.Label();
            this.lbl_leto = new System.Windows.Forms.Label();
            this.lbl_fix_leto = new System.Windows.Forms.Label();
            this.lbl_reziser = new System.Windows.Forms.Label();
            this.lbl_fix_reziser = new System.Windows.Forms.Label();
            this.lbl_certifikat = new System.Windows.Forms.Label();
            this.lbl_fix_certifikat = new System.Windows.Forms.Label();
            this.lbl_dolzina = new System.Windows.Forms.Label();
            this.lbl_fix_dolzina = new System.Windows.Forms.Label();
            this.lbl_ocena = new System.Windows.Forms.Label();
            this.lbl_fix_ocena = new System.Windows.Forms.Label();
            this.lbl_navodilo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gumb_prikazi
            // 
            this.gumb_prikazi.Location = new System.Drawing.Point(108, 51);
            this.gumb_prikazi.Name = "gumb_prikazi";
            this.gumb_prikazi.Size = new System.Drawing.Size(126, 46);
            this.gumb_prikazi.TabIndex = 1;
            this.gumb_prikazi.Text = "Prikazi";
            this.gumb_prikazi.UseVisualStyleBackColor = true;
            this.gumb_prikazi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gumb_prikazi_MouseClick);
            // 
            // list_filmov
            // 
            this.list_filmov.FormattingEnabled = true;
            this.list_filmov.ItemHeight = 20;
            this.list_filmov.Location = new System.Drawing.Point(13, 116);
            this.list_filmov.Name = "list_filmov";
            this.list_filmov.Size = new System.Drawing.Size(352, 304);
            this.list_filmov.TabIndex = 2;
            this.list_filmov.SelectedIndexChanged += new System.EventHandler(this.list_filmov_SelectedIndexChanged);
            // 
            // txtbox_katero_leto
            // 
            this.txtbox_katero_leto.Location = new System.Drawing.Point(240, 12);
            this.txtbox_katero_leto.Name = "txtbox_katero_leto";
            this.txtbox_katero_leto.Size = new System.Drawing.Size(125, 27);
            this.txtbox_katero_leto.TabIndex = 3;
            // 
            // lbl_katero_leto
            // 
            this.lbl_katero_leto.AutoSize = true;
            this.lbl_katero_leto.Location = new System.Drawing.Point(13, 13);
            this.lbl_katero_leto.Name = "lbl_katero_leto";
            this.lbl_katero_leto.Size = new System.Drawing.Size(221, 20);
            this.lbl_katero_leto.TabIndex = 4;
            this.lbl_katero_leto.Text = "Filmi katerega leta te zanimajo?";
            // 
            // lbl_napacen_vnos
            // 
            this.lbl_napacen_vnos.AutoSize = true;
            this.lbl_napacen_vnos.ForeColor = System.Drawing.Color.Red;
            this.lbl_napacen_vnos.Location = new System.Drawing.Point(414, 13);
            this.lbl_napacen_vnos.Name = "lbl_napacen_vnos";
            this.lbl_napacen_vnos.Size = new System.Drawing.Size(0, 20);
            this.lbl_napacen_vnos.TabIndex = 5;
            // 
            // lbl_fix_naslov
            // 
            this.lbl_fix_naslov.AutoSize = true;
            this.lbl_fix_naslov.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_fix_naslov.Location = new System.Drawing.Point(414, 87);
            this.lbl_fix_naslov.Name = "lbl_fix_naslov";
            this.lbl_fix_naslov.Size = new System.Drawing.Size(61, 20);
            this.lbl_fix_naslov.TabIndex = 6;
            this.lbl_fix_naslov.Text = "Naslov:";
            // 
            // lbl_naslov
            // 
            this.lbl_naslov.AutoSize = true;
            this.lbl_naslov.Location = new System.Drawing.Point(509, 87);
            this.lbl_naslov.Name = "lbl_naslov";
            this.lbl_naslov.Size = new System.Drawing.Size(0, 20);
            this.lbl_naslov.TabIndex = 7;
            // 
            // lbl_leto
            // 
            this.lbl_leto.AutoSize = true;
            this.lbl_leto.Location = new System.Drawing.Point(509, 130);
            this.lbl_leto.Name = "lbl_leto";
            this.lbl_leto.Size = new System.Drawing.Size(0, 20);
            this.lbl_leto.TabIndex = 9;
            // 
            // lbl_fix_leto
            // 
            this.lbl_fix_leto.AutoSize = true;
            this.lbl_fix_leto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_fix_leto.Location = new System.Drawing.Point(414, 130);
            this.lbl_fix_leto.Name = "lbl_fix_leto";
            this.lbl_fix_leto.Size = new System.Drawing.Size(48, 20);
            this.lbl_fix_leto.TabIndex = 8;
            this.lbl_fix_leto.Text = "Leto: ";
            // 
            // lbl_reziser
            // 
            this.lbl_reziser.AutoSize = true;
            this.lbl_reziser.Location = new System.Drawing.Point(509, 172);
            this.lbl_reziser.Name = "lbl_reziser";
            this.lbl_reziser.Size = new System.Drawing.Size(0, 20);
            this.lbl_reziser.TabIndex = 11;
            // 
            // lbl_fix_reziser
            // 
            this.lbl_fix_reziser.AutoSize = true;
            this.lbl_fix_reziser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_fix_reziser.Location = new System.Drawing.Point(414, 172);
            this.lbl_fix_reziser.Name = "lbl_fix_reziser";
            this.lbl_fix_reziser.Size = new System.Drawing.Size(64, 20);
            this.lbl_fix_reziser.TabIndex = 10;
            this.lbl_fix_reziser.Text = "Reziser:";
            // 
            // lbl_certifikat
            // 
            this.lbl_certifikat.AutoSize = true;
            this.lbl_certifikat.Location = new System.Drawing.Point(509, 211);
            this.lbl_certifikat.Name = "lbl_certifikat";
            this.lbl_certifikat.Size = new System.Drawing.Size(0, 20);
            this.lbl_certifikat.TabIndex = 13;
            // 
            // lbl_fix_certifikat
            // 
            this.lbl_fix_certifikat.AutoSize = true;
            this.lbl_fix_certifikat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_fix_certifikat.Location = new System.Drawing.Point(414, 211);
            this.lbl_fix_certifikat.Name = "lbl_fix_certifikat";
            this.lbl_fix_certifikat.Size = new System.Drawing.Size(78, 20);
            this.lbl_fix_certifikat.TabIndex = 12;
            this.lbl_fix_certifikat.Text = "Certifikat:";
            // 
            // lbl_dolzina
            // 
            this.lbl_dolzina.AutoSize = true;
            this.lbl_dolzina.Location = new System.Drawing.Point(509, 253);
            this.lbl_dolzina.Name = "lbl_dolzina";
            this.lbl_dolzina.Size = new System.Drawing.Size(0, 20);
            this.lbl_dolzina.TabIndex = 15;
            // 
            // lbl_fix_dolzina
            // 
            this.lbl_fix_dolzina.AutoSize = true;
            this.lbl_fix_dolzina.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_fix_dolzina.Location = new System.Drawing.Point(414, 253);
            this.lbl_fix_dolzina.Name = "lbl_fix_dolzina";
            this.lbl_fix_dolzina.Size = new System.Drawing.Size(65, 20);
            this.lbl_fix_dolzina.TabIndex = 14;
            this.lbl_fix_dolzina.Text = "Dolžina:";
            // 
            // lbl_ocena
            // 
            this.lbl_ocena.AutoSize = true;
            this.lbl_ocena.Location = new System.Drawing.Point(509, 294);
            this.lbl_ocena.Name = "lbl_ocena";
            this.lbl_ocena.Size = new System.Drawing.Size(0, 20);
            this.lbl_ocena.TabIndex = 17;
            // 
            // lbl_fix_ocena
            // 
            this.lbl_fix_ocena.AutoSize = true;
            this.lbl_fix_ocena.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_fix_ocena.Location = new System.Drawing.Point(414, 294);
            this.lbl_fix_ocena.Name = "lbl_fix_ocena";
            this.lbl_fix_ocena.Size = new System.Drawing.Size(56, 20);
            this.lbl_fix_ocena.TabIndex = 16;
            this.lbl_fix_ocena.Text = "Ocena:";
            // 
            // lbl_navodilo
            // 
            this.lbl_navodilo.AutoSize = true;
            this.lbl_navodilo.Location = new System.Drawing.Point(414, 64);
            this.lbl_navodilo.Name = "lbl_navodilo";
            this.lbl_navodilo.Size = new System.Drawing.Size(329, 20);
            this.lbl_navodilo.TabIndex = 18;
            this.lbl_navodilo.Text = "Klikni na posamezni film za dodatne informacije";
            this.lbl_navodilo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_navodilo);
            this.Controls.Add(this.lbl_ocena);
            this.Controls.Add(this.lbl_fix_ocena);
            this.Controls.Add(this.lbl_dolzina);
            this.Controls.Add(this.lbl_fix_dolzina);
            this.Controls.Add(this.lbl_certifikat);
            this.Controls.Add(this.lbl_fix_certifikat);
            this.Controls.Add(this.lbl_reziser);
            this.Controls.Add(this.lbl_fix_reziser);
            this.Controls.Add(this.lbl_leto);
            this.Controls.Add(this.lbl_fix_leto);
            this.Controls.Add(this.lbl_naslov);
            this.Controls.Add(this.lbl_fix_naslov);
            this.Controls.Add(this.lbl_napacen_vnos);
            this.Controls.Add(this.lbl_katero_leto);
            this.Controls.Add(this.txtbox_katero_leto);
            this.Controls.Add(this.list_filmov);
            this.Controls.Add(this.gumb_prikazi);
            this.Name = "Form1";
            this.Text = "Filmi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button gumb_prikazi;
        private System.Windows.Forms.ListBox list_filmov;
        private System.Windows.Forms.TextBox txtbox_katero_leto;
        private System.Windows.Forms.Label lbl_katero_leto;
        private System.Windows.Forms.Label lbl_napacen_vnos;
        private System.Windows.Forms.Label lbl_fix_naslov;
        private System.Windows.Forms.Label lbl_naslov;
        private System.Windows.Forms.Label lbl_leto;
        private System.Windows.Forms.Label lbl_fix_leto;
        private System.Windows.Forms.Label lbl_reziser;
        private System.Windows.Forms.Label lbl_fix_reziser;
        private System.Windows.Forms.Label lbl_certifikat;
        private System.Windows.Forms.Label lbl_fix_certifikat;
        private System.Windows.Forms.Label lbl_dolzina;
        private System.Windows.Forms.Label lbl_fix_dolzina;
        private System.Windows.Forms.Label lbl_ocena;
        private System.Windows.Forms.Label lbl_fix_ocena;
        private System.Windows.Forms.Label lbl_navodilo;
    }
}

