
namespace Risanje_Martina
{
    partial class RisanjeOkno
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
            this.btnNal1 = new System.Windows.Forms.Button();
            this.RisalnoPano = new System.Windows.Forms.Panel();
            this.btnNal2 = new System.Windows.Forms.Button();
            this.btnNal3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNal1
            // 
            this.btnNal1.Location = new System.Drawing.Point(29, 31);
            this.btnNal1.Name = "btnNal1";
            this.btnNal1.Size = new System.Drawing.Size(114, 62);
            this.btnNal1.TabIndex = 0;
            this.btnNal1.Text = "Naloga 1";
            this.btnNal1.UseVisualStyleBackColor = true;
            this.btnNal1.Click += new System.EventHandler(this.Naloga1_Click);
            // 
            // RisalnoPano
            // 
            this.RisalnoPano.Location = new System.Drawing.Point(192, 31);
            this.RisalnoPano.Name = "RisalnoPano";
            this.RisalnoPano.Size = new System.Drawing.Size(425, 385);
            this.RisalnoPano.TabIndex = 1;
            // 
            // btnNal2
            // 
            this.btnNal2.Location = new System.Drawing.Point(29, 172);
            this.btnNal2.Name = "btnNal2";
            this.btnNal2.Size = new System.Drawing.Size(114, 62);
            this.btnNal2.TabIndex = 0;
            this.btnNal2.Text = "Naloga 2";
            this.btnNal2.UseVisualStyleBackColor = true;
            this.btnNal2.Click += new System.EventHandler(this.Naloga2_Click);
            // 
            // btnNal3
            // 
            this.btnNal3.Location = new System.Drawing.Point(29, 314);
            this.btnNal3.Name = "btnNal3";
            this.btnNal3.Size = new System.Drawing.Size(114, 62);
            this.btnNal3.TabIndex = 0;
            this.btnNal3.Text = "Naloga 3";
            this.btnNal3.UseVisualStyleBackColor = true;
            this.btnNal3.Click += new System.EventHandler(this.Naloga3_Click);
            // 
            // RisanjeOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.RisalnoPano);
            this.Controls.Add(this.btnNal3);
            this.Controls.Add(this.btnNal2);
            this.Controls.Add(this.btnNal1);
            this.Name = "RisanjeOkno";
            this.Text = "Risanje";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNal1;
        private System.Windows.Forms.Panel RisalnoPano;
        private System.Windows.Forms.Button btnNal2;
        private System.Windows.Forms.Button btnNal3;
    }
}

