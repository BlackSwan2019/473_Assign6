namespace Assign6 {
    partial class Portal {
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
            this.buttonLineChart = new System.Windows.Forms.Button();
            this.buttonPieChart = new System.Windows.Forms.Button();
            this.buttonBarChart = new System.Windows.Forms.Button();
            this.labelPortal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLineChart
            // 
            this.buttonLineChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLineChart.Location = new System.Drawing.Point(295, 100);
            this.buttonLineChart.Name = "buttonLineChart";
            this.buttonLineChart.Size = new System.Drawing.Size(226, 48);
            this.buttonLineChart.TabIndex = 0;
            this.buttonLineChart.Text = "Line Graph";
            this.buttonLineChart.UseVisualStyleBackColor = true;
            this.buttonLineChart.Click += new System.EventHandler(this.buttonLineChart_Click);
            // 
            // buttonPieChart
            // 
            this.buttonPieChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPieChart.Location = new System.Drawing.Point(295, 174);
            this.buttonPieChart.Name = "buttonPieChart";
            this.buttonPieChart.Size = new System.Drawing.Size(226, 48);
            this.buttonPieChart.TabIndex = 1;
            this.buttonPieChart.Text = "Pie Chart";
            this.buttonPieChart.UseVisualStyleBackColor = true;
            this.buttonPieChart.Click += new System.EventHandler(this.buttonPieChart_Click);
            // 
            // buttonBarChart
            // 
            this.buttonBarChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBarChart.Location = new System.Drawing.Point(295, 251);
            this.buttonBarChart.Name = "buttonBarChart";
            this.buttonBarChart.Size = new System.Drawing.Size(226, 48);
            this.buttonBarChart.TabIndex = 2;
            this.buttonBarChart.Text = "Bar Graph";
            this.buttonBarChart.UseVisualStyleBackColor = true;
            this.buttonBarChart.Click += new System.EventHandler(this.buttonBarChart_Click);
            // 
            // labelPortal
            // 
            this.labelPortal.AutoSize = true;
            this.labelPortal.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPortal.Location = new System.Drawing.Point(250, 13);
            this.labelPortal.Name = "labelPortal";
            this.labelPortal.Size = new System.Drawing.Size(316, 51);
            this.labelPortal.TabIndex = 3;
            this.labelPortal.Text = "Statistics Portal";
            // 
            // Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPortal);
            this.Controls.Add(this.buttonBarChart);
            this.Controls.Add(this.buttonPieChart);
            this.Controls.Add(this.buttonLineChart);
            this.Name = "Portal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLineChart;
        private System.Windows.Forms.Button buttonPieChart;
        private System.Windows.Forms.Button buttonBarChart;
        private System.Windows.Forms.Label labelPortal;
    }
}

