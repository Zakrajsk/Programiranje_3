
namespace FlappyBird
{
    partial class GO_Flappy
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
            this.timerIgra = new System.Windows.Forms.Timer(this.components);
            this.konec = new System.Windows.Forms.Label();
            this.tla = new System.Windows.Forms.PictureBox();
            this.oviraDol = new System.Windows.Forms.PictureBox();
            this.oviraGor = new System.Windows.Forms.PictureBox();
            this.ptic = new System.Windows.Forms.PictureBox();
            this.lbl_tocke = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oviraDol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oviraGor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptic)).BeginInit();
            this.SuspendLayout();
            // 
            // timerIgra
            // 
            this.timerIgra.Enabled = true;
            this.timerIgra.Interval = 20;
            this.timerIgra.Tick += new System.EventHandler(this.timerIgra_Tick);
            // 
            // konec
            // 
            this.konec.AutoSize = true;
            this.konec.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konec.Location = new System.Drawing.Point(327, 235);
            this.konec.Name = "konec";
            this.konec.Size = new System.Drawing.Size(0, 91);
            this.konec.TabIndex = 2;
            // 
            // tla
            // 
            this.tla.Image = global::FlappyBird.Properties.Resources.tla;
            this.tla.Location = new System.Drawing.Point(-4, 530);
            this.tla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tla.Name = "tla";
            this.tla.Size = new System.Drawing.Size(1072, 67);
            this.tla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tla.TabIndex = 0;
            this.tla.TabStop = false;
            // 
            // oviraDol
            // 
            this.oviraDol.Image = global::FlappyBird.Properties.Resources.raketa;
            this.oviraDol.Location = new System.Drawing.Point(698, 118);
            this.oviraDol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oviraDol.Name = "oviraDol";
            this.oviraDol.Size = new System.Drawing.Size(216, 43);
            this.oviraDol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oviraDol.TabIndex = 1;
            this.oviraDol.TabStop = false;
            // 
            // oviraGor
            // 
            this.oviraGor.Image = global::FlappyBird.Properties.Resources.raketa;
            this.oviraGor.Location = new System.Drawing.Point(590, 307);
            this.oviraGor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oviraGor.Name = "oviraGor";
            this.oviraGor.Size = new System.Drawing.Size(268, 125);
            this.oviraGor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oviraGor.TabIndex = 1;
            this.oviraGor.TabStop = false;
            // 
            // ptic
            // 
            this.ptic.Image = global::FlappyBird.Properties.Resources.Ptic;
            this.ptic.Location = new System.Drawing.Point(156, 226);
            this.ptic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptic.Name = "ptic";
            this.ptic.Size = new System.Drawing.Size(69, 40);
            this.ptic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptic.TabIndex = 0;
            this.ptic.TabStop = false;
            // 
            // lbl_tocke
            // 
            this.lbl_tocke.AutoSize = true;
            this.lbl_tocke.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tocke.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_tocke.Location = new System.Drawing.Point(468, 9);
            this.lbl_tocke.Name = "lbl_tocke";
            this.lbl_tocke.Size = new System.Drawing.Size(64, 69);
            this.lbl_tocke.TabIndex = 3;
            this.lbl_tocke.Text = "0";
            // 
            // GO_Flappy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1047, 595);
            this.Controls.Add(this.lbl_tocke);
            this.Controls.Add(this.konec);
            this.Controls.Add(this.tla);
            this.Controls.Add(this.oviraDol);
            this.Controls.Add(this.oviraGor);
            this.Controls.Add(this.ptic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GO_Flappy";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.GO_Flappy_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tipkaDol);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tipkaGor);
            ((System.ComponentModel.ISupportInitialize)(this.tla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oviraDol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oviraGor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptic;
        private System.Windows.Forms.PictureBox tla;
        private System.Windows.Forms.PictureBox oviraGor;
        private System.Windows.Forms.PictureBox oviraDol;
        private System.Windows.Forms.Timer timerIgra;
        private System.Windows.Forms.Label konec;
        private System.Windows.Forms.Label lbl_tocke;
    }
}

