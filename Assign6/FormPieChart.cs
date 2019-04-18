using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace Assign6 {
    public partial class FormPieChart : Form {
        string dataLineBTU, dataLineName;            // Single line of data from file.
        string[] dataLineTokens;    // Hold energy source and amount of quadrillion BTUs.

        int totalBTU = 0;
        double percentage = 0;

        string percentageLabel;

        public FormPieChart() {
            InitializeComponent();
        }

        /*  
        *  Method:     FormPieChart_Load
        *  
        *  Purpose:    Handles loading of pie chart window.
        * 
        *  Arguments:  object       UI component sending event.
        *              EventArgs    The event.
        *              
        *  Return:     void
        */
        private void FormPieChart_Load(object sender, EventArgs e) {
            chartEnergy.Series[0].ChartType = SeriesChartType.Pie;

            // Set chart properties.
            chartEnergy.Series[0].Font = new Font("Comic Sans MS", 12);
            chartEnergy.Series[0].IsValueShownAsLabel = true;
            chartEnergy.Series[0].LabelFormat = "{0:#0.00}%";

            // Construct Font for the graph's title.
            FontFamily fontFamily = new FontFamily("Times New Roman");
            Font titleFont = new Font(fontFamily, 18, FontStyle.Bold);
            Title title = new Title("2016 World Energy Consumption by Source (quadrillion BTU)", Docking.Top, titleFont, Color.Black);
            chartEnergy.Titles.Add(title);

            using (var dataFileBTU = new StreamReader("../../../Data/worldEnergyUse.txt")) {
                // Get the total value of quadrillion BTUs.
                while ((dataLineBTU = dataFileBTU.ReadLine()) != null) {
                    dataLineTokens = dataLineBTU.Split(':');

                    // Accumulate total BTUs to get the denominator for the percentage.
                    totalBTU += Convert.ToInt32(dataLineTokens[1]);
                }
            }

            // Open the data file for world energy use.
            using (var dataFile = new StreamReader("../../../Data/worldEnergyUse.txt")) {
                // While file has data in it, consume it.
                while ((dataLineName = dataFile.ReadLine()) != null) {
                    // Split data line into year token and gas price token.
                    dataLineTokens = dataLineName.Split(':');

                    // Convert proportions to percentage for pie slice labels.
                    percentage = Convert.ToDouble(dataLineTokens[1]) / totalBTU;
                    percentage = percentage * 100;

                    // Add points to chart.
                    chartEnergy.Series[0].Points.AddXY(dataLineTokens[0], percentage);
                }
            }
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
