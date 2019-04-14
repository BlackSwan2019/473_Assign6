using System;
using System.Windows.Forms;

namespace Assign6 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void buttonLineChart_Click(object sender, EventArgs e) {
            // Create and then load new form for the line chart depicting gas prices.
            LoadForm(new Form2());
        }

        private void buttonBarChart_Click(object sender, EventArgs e) {
            // Create and then load new form for the pie chart depicting world energy use (in BTUs) by source.
            LoadForm(new Form3());
        }

        private void buttonAreaChart_Click(object sender, EventArgs e) {
            // Create and then load new form for the area chart depicting 
            LoadForm(new FormBarChart());
        }

        private void LoadForm(Form form) {
            form.FormClosed += new FormClosedEventHandler(formClosed);
            this.Hide();
            form.Show();
        }

        private void formClosed(object sender, FormClosedEventArgs args) {
            this.Show();
        }
    }
}
