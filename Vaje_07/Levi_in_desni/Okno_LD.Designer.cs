
namespace Levi_in_desni
{
    partial class Okno_LD
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
            this.gumb_levo = new System.Windows.Forms.Button();
            this.gumb_desni = new System.Windows.Forms.Button();
            this.label_kam_kaze = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gumb_levo
            // 
            this.gumb_levo.Location = new System.Drawing.Point(12, 24);
            this.gumb_levo.Name = "gumb_levo";
            this.gumb_levo.Size = new System.Drawing.Size(94, 29);
            this.gumb_levo.TabIndex = 0;
            this.gumb_levo.Text = "Levi";
            this.gumb_levo.UseVisualStyleBackColor = true;
            this.gumb_levo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gumb_levo_MouseDown);
            this.gumb_levo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gumb_levo_MouseUp);
            // 
            // gumb_desni
            // 
            this.gumb_desni.Location = new System.Drawing.Point(261, 24);
            this.gumb_desni.Name = "gumb_desni";
            this.gumb_desni.Size = new System.Drawing.Size(94, 29);
            this.gumb_desni.TabIndex = 1;
            this.gumb_desni.Text = "Desni";
            this.gumb_desni.UseVisualStyleBackColor = true;
            this.gumb_desni.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gumb_desni_MouseDown);
            this.gumb_desni.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gumb_desni_MouseUp);
            // 
            // label_kam_kaze
            // 
            this.label_kam_kaze.Location = new System.Drawing.Point(136, 28);
            this.label_kam_kaze.Name = "label_kam_kaze";
            this.label_kam_kaze.Size = new System.Drawing.Size(100, 20);
            this.label_kam_kaze.TabIndex = 2;
            // 
            // OknoLD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 78);
            this.Controls.Add(this.label_kam_kaze);
            this.Controls.Add(this.gumb_desni);
            this.Controls.Add(this.gumb_levo);
            this.Name = "OknoLD";
            this.Text = "Levi in desni";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gumb_levo;
        private System.Windows.Forms.Button gumb_desni;
        private System.Windows.Forms.Label label_kam_kaze;
    }
}

