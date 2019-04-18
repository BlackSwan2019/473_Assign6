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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLineChart
            // 
            this.buttonLineChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLineChart.Location = new System.Drawing.Point(291, 67);
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
            this.buttonPieChart.Location = new System.Drawing.Point(291, 141);
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
            this.buttonBarChart.Location = new System.Drawing.Point(291, 218);
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
            this.labelPortal.Location = new System.Drawing.Point(252, 9);
            this.labelPortal.Name = "labelPortal";
            this.labelPortal.Size = new System.Drawing.Size(316, 51);
            this.labelPortal.TabIndex = 3;
            this.labelPortal.Text = "Statistics Portal";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(291, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pyramid Graph";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonPyramidChart_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(291, 390);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(226, 48);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonExit;
    }
}

