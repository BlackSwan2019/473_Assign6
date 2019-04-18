using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Assign6 {
    public partial class FormPyramidChart : Form {
        string dataLine;            // Single line of data from file.
        string[] dataLineTokens;    // Holds pyramid scheme name and amount of money swindled (millions USD).

        List<string> x;             // X-axis labels.
        List<double> y;             // Y-axis labels.

        public FormPyramidChart() {
            InitializeComponent();
        }

        /*  
        *  Method:     FormPyramidChart_Load
        *  
        *  Purpose:    Handles loading of pyramid graph window.
        * 
        *  Arguments:  object       UI component sending event.
        *              EventArgs    The event.
        *              
        *  Return:     void
        */
        private void FormPyramidChart_Load(object sender, EventArgs e) {
            // Instantiate list of data points.
            x = new List<string>();
            y = new List<double>();

            chartScheme.Series[0].ChartType = SeriesChartType.Pyramid;

            // Construct Font for the graph's title.
            FontFamily fontFamily = new FontFamily("Times New Roman");
            Font titleFont = new Font(fontFamily, 18, FontStyle.Bold);
            Title title = new Title("Largest Pyramid Schemes.", Docking.Top, titleFont, Color.Black);
            chartScheme.Titles.Add(title);

            // Set style of axis titles and labels.
            chartScheme.ChartAreas[0].AxisX.Title = "Scheme";
            chartScheme.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            chartScheme.ChartAreas[0].AxisX.TitleFont = new Font("Times New Roman", 12, FontStyle.Bold);
            chartScheme.ChartAreas[0].AxisY.Title = "Money Swindled";
            chartScheme.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            chartScheme.ChartAreas[0].AxisY.TitleFont = new Font("Times New Roman", 12, FontStyle.Bold);

            using (var dataFile = new StreamReader("../../../Data/pyramidSchemes.txt")) {
                while ((dataLine = dataFile.ReadLine()) != null) {
                    dataLineTokens = dataLine.Split(':');

                    x.Add(dataLineTokens[0]);
                    y.Add(Convert.ToInt32(dataLineTokens[1]));
                }
            }

            chartScheme.Series[0].Points.DataBindXY(x, y);
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
