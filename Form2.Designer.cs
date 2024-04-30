namespace COMPortTerminal
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tBoxRandom = new System.Windows.Forms.TextBox();
            this.labelRandom = new System.Windows.Forms.Label();
            this.higth = new System.Windows.Forms.Label();
            this.numeric = new System.Windows.Forms.NumericUpDown();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tBoxDataPort = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // tBoxRandom
            // 
            this.tBoxRandom.Location = new System.Drawing.Point(477, 33);
            this.tBoxRandom.Name = "tBoxRandom";
            this.tBoxRandom.Size = new System.Drawing.Size(40, 20);
            this.tBoxRandom.TabIndex = 12;
            // 
            // labelRandom
            // 
            this.labelRandom.AutoSize = true;
            this.labelRandom.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelRandom.Location = new System.Drawing.Point(329, 29);
            this.labelRandom.Name = "labelRandom";
            this.labelRandom.Size = new System.Drawing.Size(128, 19);
            this.labelRandom.TabIndex = 11;
            this.labelRandom.Text = "Рандомное число";
            // 
            // higth
            // 
            this.higth.AutoSize = true;
            this.higth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.higth.Location = new System.Drawing.Point(64, 31);
            this.higth.Name = "higth";
            this.higth.Size = new System.Drawing.Size(117, 19);
            this.higth.TabIndex = 8;
            this.higth.Text = "Данные с порта";
            // 
            // numeric
            // 
            this.numeric.Location = new System.Drawing.Point(748, 28);
            this.numeric.Name = "numeric";
            this.numeric.Size = new System.Drawing.Size(40, 20);
            this.numeric.TabIndex = 7;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 69);
            this.chart.Name = "chart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Black;
            series1.Legend = "Legend1";
            series1.Name = "Data Port";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "Random";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(776, 388);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // tBoxDataPort
            // 
            this.tBoxDataPort.Location = new System.Drawing.Point(200, 33);
            this.tBoxDataPort.Name = "tBoxDataPort";
            this.tBoxDataPort.Size = new System.Drawing.Size(40, 20);
            this.tBoxDataPort.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.tBoxDataPort);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.tBoxRandom);
            this.Controls.Add(this.labelRandom);
            this.Controls.Add(this.higth);
            this.Controls.Add(this.numeric);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxRandom;
        private System.Windows.Forms.Label labelRandom;
        private System.Windows.Forms.Label higth;
        private System.Windows.Forms.NumericUpDown numeric;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TextBox tBoxDataPort;
    }
}