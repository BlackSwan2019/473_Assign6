using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace Assign6 {
    public partial class Form2 : Form {
        string dataLine;            // Single line of data from file.
        string[] dataLineTokens;    // Holds year and gas price.
        
        List<string> x;                 // X-axis labels (years).
        List<double> y;                 // Y-axis labels (gas prices).

        Series series;

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
            chartGas.ChartAreas[0].AxisX.IsMarginVisible = false;
            chartGas.ChartAreas[1].AxisX.IsMarginVisible = false;

            // Construct Font for the graph's title.
            FontFamily fontFamily = new FontFamily("Comic Sans MS");
            Font titleFont = new Font(fontFamily, 18, FontStyle.Bold);
            Title title = new Title("Gas Prices", Docking.Top, titleFont, Color.Black);
            chartGas.Titles.Add(title);

            // Label the series (line) in the legend.
            Series series = new Series();
            chartGas.Series[0].Name = "Gas Price";

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

            chartGas.Series[1].Points.DataBindXY(x, y);


            for (int i  = 0;  i < x.Count(); i++) {
                series.Points.Add(i, y[i]);
            }

        }
    }
}
