using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
            Title title = new Title("Largest Pyramid Schemes by millions USD swindled.", Docking.Top, titleFont, Color.Black);
            chartScheme.Titles.Add(title);

            // Set style of axis titles and labels.
            chartScheme.ChartAreas[0].AxisX.Title = "Scheme";
            chartScheme.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            chartScheme.ChartAreas[0].AxisX.TitleFont = new Font("Times New Roman", 12, FontStyle.Bold);
            chartScheme.ChartAreas[0].AxisY.Title = "Money Swindled";
            chartScheme.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            chartScheme.ChartAreas[0].AxisY.TitleFont = new Font("Times New Roman", 12, FontStyle.Bold);

            // Read data from file and parse it into tokens to add to graph.
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

        /*  
        *  Method:     chartScheme_Paint
        *  
        *  Purpose:    Draws labels on the pyramid's layers to show how much each 
        *              pyramid scheme swindled from users (in millions USD).
        * 
        *  Arguments:  object           UI component sending event.
        *              PaintEventArgs   The paint event.
        *              
        *  Return:     void
        */
        private void chartScheme_Paint(object sender, PaintEventArgs e) {
            List<string> labelList = new List<string>();    // Pyramid layer labels.

            // Set up graphics, label font, and brush for drawing labels on pyramid layers.
            Graphics g = e.Graphics;
            FontFamily fontFamily = new FontFamily("Times New Roman");
            Font titleFont = new Font(fontFamily, 12, FontStyle.Bold);
            SolidBrush brush = new SolidBrush(Color.Black);

            // Read in from file to get values (amount of money swindled by pyramid schemes).
            using (var dataFile = new StreamReader("../../../Data/pyramidSchemes.txt")) {
                while ((dataLine = dataFile.ReadLine()) != null) {
                    dataLineTokens = dataLine.Split(':');

                    labelList.Add(dataLineTokens[1]);
                }
            }

            // Draw labels on pyramid layers (since C# pyramid charts don't seem to support labels naturally...).
            e.Graphics.DrawString(labelList[0], titleFont, brush, new PointF(290, 370));
            e.Graphics.DrawString(labelList[1], titleFont, brush, new PointF(290, 315));
            e.Graphics.DrawString(labelList[2], titleFont, brush, new PointF(290, 265));
            e.Graphics.DrawString(labelList[3], titleFont, brush, new PointF(290, 219));
            e.Graphics.DrawString(labelList[4], titleFont, brush, new PointF(290, 178));
            e.Graphics.DrawString(labelList[5], titleFont, brush, new PointF(290, 145));
            e.Graphics.DrawString(labelList[6], titleFont, brush, new PointF(290, 115));
            e.Graphics.DrawString(labelList[7], titleFont, brush, new PointF(290, 90));
            e.Graphics.DrawString(labelList[8], titleFont, brush, new PointF(285, 70));
            e.Graphics.DrawString(labelList[9], titleFont, brush, new PointF(290, 45));
        }
    }
}
