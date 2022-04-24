
namespace GUI_Nobel
{
    partial class gui_nobel
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
            this.listbox_podrocja = new System.Windows.Forms.ListBox();
            this.listbox_nagrajenci = new System.Windows.Forms.ListBox();
            this.gmb_osvezi = new System.Windows.Forms.Button();
            this.txtbox_zacetek = new System.Windows.Forms.TextBox();
            this.txtbox_konec = new System.Windows.Forms.TextBox();
            this.lbl_napaka_vnos = new System.Windows.Forms.Label();
            this.lbl_navodilo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picB_nobel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picB_nobel)).BeginInit();
            this.SuspendLayout();
            // 
            // listbox_podrocja
            // 
            this.listbox_podrocja.FormattingEnabled = true;
            this.listbox_podrocja.ItemHeight = 20;
            this.listbox_podrocja.Location = new System.Drawing.Point(12, 230);
            this.listbox_podrocja.Name = "listbox_podrocja";
            this.listbox_podrocja.Size = new System.Drawing.Size(134, 124);
            this.listbox_podrocja.TabIndex = 0;
            // 
            // listbox_nagrajenci
            // 
            this.listbox_nagrajenci.FormattingEnabled = true;
            this.listbox_nagrajenci.ItemHeight = 20;
            this.listbox_nagrajenci.Location = new System.Drawing.Point(298, 107);
            this.listbox_nagrajenci.Name = "listbox_nagrajenci";
            this.listbox_nagrajenci.Size = new System.Drawing.Size(426, 324);
            this.listbox_nagrajenci.TabIndex = 1;
            // 
            // gmb_osvezi
            // 
            this.gmb_osvezi.Location = new System.Drawing.Point(172, 305);
            this.gmb_osvezi.Name = "gmb_osvezi";
            this.gmb_osvezi.Size = new System.Drawing.Size(120, 49);
            this.gmb_osvezi.TabIndex = 2;
            this.gmb_osvezi.Text = "Osveži";
            this.gmb_osvezi.UseVisualStyleBackColor = true;
            this.gmb_osvezi.Click += new System.EventHandler(this.gmb_osvezi_Click);
            // 
            // txtbox_zacetek
            // 
            this.txtbox_zacetek.Location = new System.Drawing.Point(12, 119);
            this.txtbox_zacetek.Name = "txtbox_zacetek";
            this.txtbox_zacetek.Size = new System.Drawing.Size(125, 27);
            this.txtbox_zacetek.TabIndex = 3;
            // 
            // txtbox_konec
            // 
            this.txtbox_konec.Location = new System.Drawing.Point(143, 119);
            this.txtbox_konec.Name = "txtbox_konec";
            this.txtbox_konec.Size = new System.Drawing.Size(125, 27);
            this.txtbox_konec.TabIndex = 4;
            // 
            // lbl_napaka_vnos
            // 
            this.lbl_napaka_vnos.AutoSize = true;
            this.lbl_napaka_vnos.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_napaka_vnos.ForeColor = System.Drawing.Color.Red;
            this.lbl_napaka_vnos.Location = new System.Drawing.Point(36, 162);
            this.lbl_napaka_vnos.Name = "lbl_napaka_vnos";
            this.lbl_napaka_vnos.Size = new System.Drawing.Size(221, 50);
            this.lbl_napaka_vnos.TabIndex = 5;
            this.lbl_napaka_vnos.Text = "Neveljavni vnos datumov!\r\nIzpis kar vseh nagrajencev.\r\n";
            this.lbl_napaka_vnos.Visible = false;
            // 
            // lbl_navodilo
            // 
            this.lbl_navodilo.AutoSize = true;
            this.lbl_navodilo.Location = new System.Drawing.Point(12, 96);
            this.lbl_navodilo.Name = "lbl_navodilo";
            this.lbl_navodilo.Size = new System.Drawing.Size(216, 20);
            this.lbl_navodilo.TabIndex = 6;
            this.lbl_navodilo.Text = "Vnesi zacetno in koncno letnico";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 60);
            this.label1.TabIndex = 7;
            this.label1.Text = "Program za izpis nobelovih nagrajencev.\r\nVpiši letnici in izberi področje za kate" +
    "rega želiš videti nagrajence.\r\nČe področja ne izbereš, se izpišejo nagrajenci vs" +
    "eh področij.\r\n\r\n\r\n";
            // 
            // picB_nobel
            // 
            this.picB_nobel.Image = global::GUI_Nobel.Properties.Resources.Nobel_Prize;
            this.picB_nobel.Location = new System.Drawing.Point(12, 57);
            this.picB_nobel.Name = "picB_nobel";
            this.picB_nobel.Size = new System.Drawing.Size(608, 608);
            this.picB_nobel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picB_nobel.TabIndex = 8;
            this.picB_nobel.TabStop = false;
            // 
            // gui_nobel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_navodilo);
            this.Controls.Add(this.lbl_napaka_vnos);
            this.Controls.Add(this.txtbox_konec);
            this.Controls.Add(this.txtbox_zacetek);
            this.Controls.Add(this.gmb_osvezi);
            this.Controls.Add(this.listbox_nagrajenci);
            this.Controls.Add(this.listbox_podrocja);
            this.Controls.Add(this.picB_nobel);
            this.Name = "gui_nobel";
            this.Text = "Nobel";
            this.Load += new System.EventHandler(this.gui_nobel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picB_nobel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbox_podrocja;
        private System.Windows.Forms.ListBox listbox_nagrajenci;
        private System.Windows.Forms.Button gmb_osvezi;
        private System.Windows.Forms.TextBox txtbox_zacetek;
        private System.Windows.Forms.TextBox txtbox_konec;
        private System.Windows.Forms.Label lbl_napaka_vnos;
        private System.Windows.Forms.Label lbl_navodilo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picB_nobel;
    }
}

