namespace Assign6 {
    partial class FormBarChart {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartReligion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartReligion)).BeginInit();
            this.SuspendLayout();
            // 
            // chartReligion
            // 
            chartArea1.Name = "ChartArea1";
            this.chartReligion.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartReligion.Legends.Add(legend1);
            this.chartReligion.Location = new System.Drawing.Point(13, 13);
            this.chartReligion.Name = "chartReligion";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartReligion.Series.Add(series1);
            this.chartReligion.Size = new System.Drawing.Size(775, 425);
            this.chartReligion.TabIndex = 0;
            this.chartReligion.Text = "chart1";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(343, 444);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(130, 39);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "< Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormBarChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.chartReligion);
            this.Name = "FormBarChart";
            this.Text = "FormAreaChart";
            this.Load += new System.EventHandler(this.FormBarChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartReligion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartReligion;
        private System.Windows.Forms.Button buttonBack;
    }
}