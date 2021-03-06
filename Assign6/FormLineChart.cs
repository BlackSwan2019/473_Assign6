﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace Assign6 {
    /*  
    *  Class:       FormLineChart
    *  
    *  Purpose:     Line chart displaying gas prices over time along with oil prices.
    */
    public partial class FormLineChart : Form {
        string dataLine;            // Single line of data from file.
        string[] dataLineTokens;    // Holds year and gas price.
        
        List<string> x;             // X-axis labels (years).
        List<double> y;             // Y-axis labels (gas prices).

        public FormLineChart() {
            InitializeComponent();
        }

        /*  
        *  Method:     FormLineChart_Load
        *  
        *  Purpose:    Handles loading of line graph window.
        * 
        *  Arguments:  object       UI component sending event.
        *              EventArgs    The event.
        *              
        *  Return:     void
        */
        private void FormLineGraph_Load(object sender, EventArgs e) {
            // Instantiate list of data points.
            x = new List<string>();
            y = new List<double>();

            // Set chart properties.
            chartGas.Series[0].ChartType = SeriesChartType.Line;
            chartGas.Series[1].ChartType = SeriesChartType.Line;
            chartGas.Series[2].ChartType = SeriesChartType.Line;
            chartGas.Series[0].BorderWidth = 3;
            chartGas.Series[1].BorderWidth = 3;
            chartGas.Series[2].BorderWidth = 3;
            chartGas.ChartAreas[0].AxisX.IsMarginVisible = false;
            chartGas.ChartAreas[0].AxisY.LabelStyle.Format = "{0.00}";
            chartGas.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;
            chartGas.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            // Assign series to Y axes.
            chartGas.Series[0].YAxisType = AxisType.Primary;
            chartGas.Series[1].YAxisType = AxisType.Primary;
            chartGas.Series[2].YAxisType = AxisType.Secondary;

            // Construct font for the graph's title.
            FontFamily fontFamily = new FontFamily("Times New Roman");
            Font titleFont = new Font(fontFamily, 18, FontStyle.Bold);
            Title title = new Title("Gas Prices ($/gal) with oil barrel price ($/Barrel)", Docking.Top, titleFont, Color.Black);
            chartGas.Titles.Add(title);

            // Set style of axis titles and labels.
            chartGas.ChartAreas[0].AxisX.Title = "Year";
            chartGas.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            chartGas.ChartAreas[0].AxisX.TitleFont = new Font("Times New Roman", 12, FontStyle.Bold);
            chartGas.ChartAreas[0].AxisY.Title = "Price (USD)";
            chartGas.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            chartGas.ChartAreas[0].AxisY.TitleFont = new Font("Times New Roman", 12, FontStyle.Bold);
            chartGas.ChartAreas[0].AxisY2.Title = "Price (USD)";
            chartGas.ChartAreas[0].AxisY2.LabelStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            chartGas.ChartAreas[0].AxisY2.TitleFont = new Font("Times New Roman", 12, FontStyle.Bold);

            // Label the series (line) in the legend.
            chartGas.Series[0].Name = "Gas Price Not inflation-adjusted (LHS)";
            chartGas.Series[1].Name = "Gas Price Inflation-adjusted (LHS)";
            chartGas.Series[2].Name = "Oil price per barrel Not inflation-adjusted (RHS)";

            // Open the data file for gas prices.
            using (var dataFile = new StreamReader("../../../Data/gasPricesCurrent.txt")) {
                // While file has data in it, consume it.
                while ((dataLine = dataFile.ReadLine())!= null) {
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

            // Reset data points for new data.
            x.Clear();
            y.Clear();

            // Open the data file for gas prices.
            using (var dataFile = new StreamReader("../../../Data/oilPrice.txt")) {
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
            chartGas.Series[2].Points.DataBindXY(x, y);
        }

        /*  
        *  Method:     buttonBack_Click
        *  
        *  Purpose:    Handles when user clicks the back button to go back to Portal.
        * 
        *  Arguments:  object       UI component sending event.
        *              EventArgs    The event.
        *              
        *  Return:     void
        */
        private void buttonBack_Click(object sender, EventArgs e) {
            // Close this window.
            this.Close();
        }
    }
}
