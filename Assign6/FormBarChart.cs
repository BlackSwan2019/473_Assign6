using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Assign6 {
    /*  
    *  Class:       FormBarChart
    *  
    *  Purpose:     Bar chart displaying populations of various religions.
    */
    public partial class FormBarChart : Form {
        string dataLine;            // Single line of data from file.
        string[] dataLineTokens;    // Holds religion and population for that religion.

        List<string> x;             // X-axis labels.
        List<double> y;             // Y-axis labels.

        public FormBarChart() {
            InitializeComponent();
        }

        /*  
        *  Method:     FormBarChart_Load
        *  
        *  Purpose:    Handles loading of bar graph window.
        * 
        *  Arguments:  object       UI component sending event.
        *              EventArgs    The event.
        *              
        *  Return:     void
        */
        private void FormBarChart_Load(object sender, EventArgs e) {
            // Instantiate list of data points.
            x = new List<string>();
            y = new List<double>();

            // Construct Font for the graph's title.
            FontFamily fontFamily = new FontFamily("Times New Roman");
            Font titleFont = new Font(fontFamily, 18, FontStyle.Bold);
            Title title = new Title("World Religion Populations", Docking.Top, titleFont, Color.Black);
            chartReligion.Titles.Add(title);

            // Set style of axis titles and labels.
            chartReligion.ChartAreas[0].AxisX.Title = "Religion";
            chartReligion.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            chartReligion.ChartAreas[0].AxisX.TitleFont = new Font("Times New Roman", 12, FontStyle.Bold);
            chartReligion.ChartAreas[0].AxisY.Title = "People (in millions)";
            chartReligion.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            chartReligion.ChartAreas[0].AxisY.TitleFont = new Font("Times New Roman", 12, FontStyle.Bold);
            chartReligion.ChartAreas[0].AxisX.Interval = 1;

            // Label the series (line) in the legend.
            chartReligion.Series[0].Name = "Religions";

            // Make graph a little wider to accomodate longer religion names.
            chartReligion.Legends.Clear();

            // Open the data file for gas prices.
            using (var dataFile = new StreamReader("../../../Data/religions.txt")) {
                // While file has data in it, consume it.
                while ((dataLine = dataFile.ReadLine()) != null) {
                    // Split data line into year token and gas price token.
                    dataLineTokens = dataLine.Split(':');

                    // Add data to respective axis lists.
                    x.Add(dataLineTokens[0]);
                    y.Add(Convert.ToDouble(dataLineTokens[1]));
                }
            }

            // Add data points to the current (non-inflation-adjusted) series points.
            chartReligion.Series[0].Points.DataBindXY(x, y);

            // Reset data points for new data.
            x.Clear();
            y.Clear();

            Color[] colors = new Color[] { Color.Green, Color.LightGreen, Color.YellowGreen, Color.Yellow, Color.Maroon, Color.Red, Color.Bisque, Color.BlueViolet, Color.DarkBlue, Color.DarkGray };
            foreach (Series series in chartReligion.Series) {
                foreach (DataPoint point in series.Points) {
                    //point.LabelBackColor = colors[series.Points.IndexOf(point)];
                    point.Color = colors[series.Points.IndexOf(point)];
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
