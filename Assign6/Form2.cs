
/*
 * Program:     Assignment 6
 * Author:      Patrick Klesyk, Ben Lane, Matt Rycraft
 * Z-ID:        Z1782152        Z1806979  Z1818053 
 * Description: A multi-form app that displays various graphs/charts.
 * Due Date:    4//2019
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace Assign6 {
    public partial class Form2 : Form {
        string dataLine;            // Single line of data from file.
        string[] dataLineTokens;    // Holds year and gas price.
        
        List<string> x;                 // X-axis labels (years).
        List<double> y;                 // Y-axis labels (gas prices).

        public Form2() {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {
            // Instantiate list of data points.
            x = new List<string>();
            y = new List<double>();

            // Set chart properties.
            chartGas.Series[0].ChartType = SeriesChartType.Line;
            chartGas.Series[1].ChartType = SeriesChartType.Line;
            chartGas.Series[0].BorderWidth = 3;
            chartGas.Series[1].BorderWidth = 3;
            chartGas.ChartAreas[0].AxisX.IsMarginVisible = false;
            chartGas.ChartAreas[0].AxisY.LabelStyle.Format = "{0.00}";

            // Set style of axis titles and labels.
            chartGas.ChartAreas[0].AxisX.Title = "Year";
            chartGas.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            chartGas.ChartAreas[0].AxisX.TitleFont = new Font("Times New Roman", 12, FontStyle.Bold);
            chartGas.ChartAreas[0].AxisY.Title = "Price (USD)";
            chartGas.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            chartGas.ChartAreas[0].AxisY.TitleFont = new Font("Times New Roman", 12, FontStyle.Bold);

            // Construct Font for the graph's title.
            FontFamily fontFamily = new FontFamily("Times New Roman");
            Font titleFont = new Font(fontFamily, 18, FontStyle.Bold);
            Title title = new Title("Gas Prices ($/gal)", Docking.Top, titleFont, Color.Black);
            chartGas.Titles.Add(title);

            // Label the series (line) in the legend.
            chartGas.Series[0].Name = "Gas Price (Not inflation-adjusted)";
            chartGas.Series[1].Name = "Gas Price (Inflation-adjusted)";

            // Open the data file for gas prices.
            using (var dataFile = new StreamReader("../../../Data/gasPricesCurrent.txt")) {
                // While file has data in it, consume it.
                while ((dataLine  = dataFile.ReadLine())!= null) {
                    // Split data line into year token and gas price token.
                    dataLineTokens = dataLine.Split(':');

                    // Add data to respective axis lists.
                    x.Add(dataLineTokens[0]);
                    y.Add(Convert.ToDouble(dataLineTokens[1]));
                }
            }

            // Add data points to the current (non-inflation-adjusted) series points.
            chartGas.Series[0].Points.DataBindXY(x, y);

            // Reset data points for new data.
            x.Clear();
            y.Clear();

            // Open the data file for gas prices.
            using (var dataFile = new StreamReader("../../../Data/gasPricesReal.txt")) {
                // While file has data in it, consume it.
                while ((dataLine = dataFile.ReadLine()) != null) {
                    // Split data line into year token and gas price token.
                    dataLineTokens = dataLine.Split(':');

                    // Add data to respective axis lists.
                    x.Add(dataLineTokens[0]);
                    y.Add(Convert.ToDouble(dataLineTokens[1]));
                }
            }

            // Add data points to the real (inflation-adjusted) series points.
            chartGas.Series[1].Points.DataBindXY(x, y);
        }

        private void buttonBack_Click(object sender, EventArgs e) {
            // Close this window.
            this.Close();
        }
    }
}
