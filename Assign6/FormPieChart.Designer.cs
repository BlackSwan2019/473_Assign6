namespace Assign6 {
    partial class FormPieChart {
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
            this.chartEnergy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartEnergy)).BeginInit();
            this.SuspendLayout();
            // 
            // chartEnergy
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEnergy.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartEnergy.Legends.Add(legend1);
            this.chartEnergy.Location = new System.Drawing.Point(13, 13);
            this.chartEnergy.Name = "chartEnergy";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartEnergy.Series.Add(series1);
            this.chartEnergy.Size = new System.Drawing.Size(775, 425);
            this.chartEnergy.TabIndex = 0;
            this.chartEnergy.Text = "chart1";
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.chartEnergy);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FormPieChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartEnergy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartEnergy;
        private System.Windows.Forms.Button buttonBack;
    }
}