namespace Assign6 {
    partial class FormPyramidChart {
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
            this.chartScheme = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartScheme)).BeginInit();
            this.SuspendLayout();
            // 
            // chartScheme
            // 
            chartArea1.Name = "ChartArea1";
            this.chartScheme.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartScheme.Legends.Add(legend1);
            this.chartScheme.Location = new System.Drawing.Point(12, 12);
            this.chartScheme.Name = "chartScheme";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartScheme.Series.Add(series1);
            this.chartScheme.Size = new System.Drawing.Size(776, 426);
            this.chartScheme.TabIndex = 0;
            this.chartScheme.Text = "chart1";
            this.chartScheme.Paint += new System.Windows.Forms.PaintEventHandler(this.chartScheme_Paint);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(343, 444);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(130, 39);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "< Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormPyramidChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.chartScheme);
            this.Name = "FormPyramidChart";
            this.Text = "FormPyramidChart";
            this.Load += new System.EventHandler(this.FormPyramidChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartScheme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartScheme;
        private System.Windows.Forms.Button buttonBack;
    }
}