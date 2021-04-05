
namespace Stevec_klikov
{
    partial class Okno_st_klikov
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
            this.label_st_klikov = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_st_klikov
            // 
            this.label_st_klikov.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_st_klikov.Location = new System.Drawing.Point(12, 9);
            this.label_st_klikov.Name = "label_st_klikov";
            this.label_st_klikov.Size = new System.Drawing.Size(536, 184);
            this.label_st_klikov.TabIndex = 0;
            this.label_st_klikov.Text = "ŠTEVEC KLIKOV";
            this.label_st_klikov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_st_klikov.Click += new System.EventHandler(this.label_st_klikov_Click);
            // 
            // Okno_st_klikov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 202);
            this.Controls.Add(this.label_st_klikov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Okno_st_klikov";
            this.Text = "Število klikov";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_st_klikov;
    }
}

