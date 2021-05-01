
namespace Casovnik
{
    partial class Casovnik
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
            this.casovnik = new System.Windows.Forms.Timer(this.components);
            this.lbl_cas = new System.Windows.Forms.Label();
            this.btn_start_stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // casovnik
            // 
            this.casovnik.Tick += new System.EventHandler(this.Stej);
            // 
            // lbl_cas
            // 
            this.lbl_cas.AutoSize = true;
            this.lbl_cas.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cas.Location = new System.Drawing.Point(195, 34);
            this.lbl_cas.Name = "lbl_cas";
            this.lbl_cas.Size = new System.Drawing.Size(70, 50);
            this.lbl_cas.TabIndex = 0;
            this.lbl_cas.Text = "0.0";
            // 
            // btn_start_stop
            // 
            this.btn_start_stop.Location = new System.Drawing.Point(12, 21);
            this.btn_start_stop.Name = "btn_start_stop";
            this.btn_start_stop.Size = new System.Drawing.Size(140, 73);
            this.btn_start_stop.TabIndex = 1;
            this.btn_start_stop.Text = "Start / Stop";
            this.btn_start_stop.UseVisualStyleBackColor = true;
            this.btn_start_stop.Click += new System.EventHandler(this.StartStopKlik);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 121);
            this.Controls.Add(this.btn_start_stop);
            this.Controls.Add(this.lbl_cas);
            this.Name = "Form1";
            this.Text = "Casovnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer casovnik;
        private System.Windows.Forms.Label lbl_cas;
        private System.Windows.Forms.Button btn_start_stop;
    }
}

