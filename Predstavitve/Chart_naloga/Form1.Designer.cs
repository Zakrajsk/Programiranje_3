
namespace Chart_naloga
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chr_graf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_narisi = new System.Windows.Forms.Button();
            this.txtbox_x = new System.Windows.Forms.TextBox();
            this.txtbox_y = new System.Windows.Forms.TextBox();
            this.lbl_x = new System.Windows.Forms.Label();
            this.lbl_y = new System.Windows.Forms.Label();
            this.lbl_navodilo = new System.Windows.Forms.Label();
            this.btn_random = new System.Windows.Forms.Button();
            this.lbl_napaka = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chr_graf)).BeginInit();
            this.SuspendLayout();
            // 
            // chr_graf
            // 
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.LightGray;
            chartArea1.Name = "ChartArea1";
            this.chr_graf.ChartAreas.Add(chartArea1);
            this.chr_graf.Location = new System.Drawing.Point(240, 13);
            this.chr_graf.Name = "chr_graf";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Name = "Series1";
            this.chr_graf.Series.Add(series1);
            this.chr_graf.Size = new System.Drawing.Size(548, 321);
            this.chr_graf.TabIndex = 0;
            this.chr_graf.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Vse točke";
            this.chr_graf.Titles.Add(title1);
            // 
            // btn_narisi
            // 
            this.btn_narisi.Location = new System.Drawing.Point(108, 160);
            this.btn_narisi.Name = "btn_narisi";
            this.btn_narisi.Size = new System.Drawing.Size(105, 55);
            this.btn_narisi.TabIndex = 1;
            this.btn_narisi.Text = "NARIŠI";
            this.btn_narisi.UseVisualStyleBackColor = true;
            this.btn_narisi.Click += new System.EventHandler(this.btn_narisi_Click);
            // 
            // txtbox_x
            // 
            this.txtbox_x.Location = new System.Drawing.Point(40, 50);
            this.txtbox_x.Name = "txtbox_x";
            this.txtbox_x.Size = new System.Drawing.Size(43, 22);
            this.txtbox_x.TabIndex = 2;
            // 
            // txtbox_y
            // 
            this.txtbox_y.Location = new System.Drawing.Point(40, 90);
            this.txtbox_y.Name = "txtbox_y";
            this.txtbox_y.Size = new System.Drawing.Size(43, 22);
            this.txtbox_y.TabIndex = 3;
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Location = new System.Drawing.Point(13, 50);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(21, 17);
            this.lbl_x.TabIndex = 4;
            this.lbl_x.Text = "X:";
            // 
            // lbl_y
            // 
            this.lbl_y.AutoSize = true;
            this.lbl_y.Location = new System.Drawing.Point(13, 93);
            this.lbl_y.Name = "lbl_y";
            this.lbl_y.Size = new System.Drawing.Size(21, 17);
            this.lbl_y.TabIndex = 5;
            this.lbl_y.Text = "Y:";
            // 
            // lbl_navodilo
            // 
            this.lbl_navodilo.AutoSize = true;
            this.lbl_navodilo.Location = new System.Drawing.Point(13, 13);
            this.lbl_navodilo.Name = "lbl_navodilo";
            this.lbl_navodilo.Size = new System.Drawing.Size(200, 17);
            this.lbl_navodilo.TabIndex = 7;
            this.lbl_navodilo.Text = "Vnesi x in y za izris točke (x, y)";
            // 
            // btn_random
            // 
            this.btn_random.Location = new System.Drawing.Point(40, 263);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(122, 47);
            this.btn_random.TabIndex = 8;
            this.btn_random.Text = "Random";
            this.btn_random.UseVisualStyleBackColor = true;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // lbl_napaka
            // 
            this.lbl_napaka.AutoSize = true;
            this.lbl_napaka.ForeColor = System.Drawing.Color.Red;
            this.lbl_napaka.Location = new System.Drawing.Point(13, 124);
            this.lbl_napaka.Name = "lbl_napaka";
            this.lbl_napaka.Size = new System.Drawing.Size(113, 17);
            this.lbl_napaka.TabIndex = 9;
            this.lbl_napaka.Text = "Napacni podatki!";
            this.lbl_napaka.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 350);
            this.Controls.Add(this.lbl_napaka);
            this.Controls.Add(this.btn_random);
            this.Controls.Add(this.lbl_navodilo);
            this.Controls.Add(this.lbl_y);
            this.Controls.Add(this.lbl_x);
            this.Controls.Add(this.txtbox_y);
            this.Controls.Add(this.txtbox_x);
            this.Controls.Add(this.btn_narisi);
            this.Controls.Add(this.chr_graf);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chr_graf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chr_graf;
        private System.Windows.Forms.Button btn_narisi;
        private System.Windows.Forms.TextBox txtbox_x;
        private System.Windows.Forms.TextBox txtbox_y;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Label lbl_y;
        private System.Windows.Forms.Label lbl_navodilo;
        private System.Windows.Forms.Button btn_random;
        private System.Windows.Forms.Label lbl_napaka;
    }
}

