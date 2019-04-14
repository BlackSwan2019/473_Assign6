using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;


namespace Assign6 {
    public partial class Form3 : Form {
        string dataLine;            // Single line of data from file.
        string[] dataLineTokens;    // Holds year and gas price.

        public Form3() {
            InitializeComponent();
        }

        /*  
        *  Method:     drawGame
        *  
        *  Purpose:    Draws game field. 
        * 
        *  Arguments:  none
        *              
        *  Return:     void
        */
        private void Form3_Load(object sender, EventArgs e) {
            chartEnergy.Series[0].ChartType = SeriesChartType.Pie;

            // Set chart properties.
            chartEnergy.Series[0].Font = new Font("Comic Sans MS", 12);
            chartEnergy.Series[0].IsValueShownAsLabel = true;

            // Construct Font for the graph's title.
            FontFamily fontFamily = new FontFamily("Times New Roman");
            Font titleFont = new Font(fontFamily, 18, FontStyle.Bold);
            Title title = new Title("2016 World Energy Consumption by Source (quadrillion BTU)", Docking.Top, titleFont, Color.Black);
            chartEnergy.Titles.Add(title);

            // Open the data file for world energy use.
            using (var dataFile = new StreamReader("../../../Data/worldEnergyUse.txt")) {
                // While file has data in it, consume it.
                while ((dataLine = dataFile.ReadLine()) != null) {
                    Console.WriteLine(dataLine);
                    // Split data line into year token and gas price token.
                    dataLineTokens = dataLine.Split(':');

                    // Add points to chart.
                    chartEnergy.Series[0].Points.AddXY(dataLineTokens[0], dataLineTokens[1]);
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e) {
            // Close this window.
            this.Close();
        }
    }
}
