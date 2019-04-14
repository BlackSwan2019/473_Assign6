
/*
 * Program:     Assignment 6
 * Author:      Patrick Klesyk, Ben Lane, Matt Rycraft
 * Z-ID:        Z1782152        Z1806979  Z1818053 
 * Description: A multi-form app that displays various graphs/charts.
 * Due Date:    4/25/2019
 */

using System;
using System.Windows.Forms;

namespace Assign6 {
    public partial class Portal : Form {
        public Portal() {
            InitializeComponent();
        }

        /*  
        *  Method:     buttonLineChart_Click
        *  
        *  Purpose:    Handles when user clicks Line Graph button.
        * 
        *  Arguments:  object       UI component sending event.
        *              EventArgs    The event.
        *              
        *  Return:     void
        */
        private void buttonLineChart_Click(object sender, EventArgs e) {
            // Create and then load new form for the line chart depicting gas prices.
            LoadForm(new FormLineChart());
        }

        /*  
        *  Method:     buttonPieChart_Click
        *  
        *  Purpose:    Handles when user clicks Pie Chart button.
        * 
        *  Arguments:  object       UI component sending event.
        *              EventArgs    The event.
        *              
        *  Return:     void
        */
        private void buttonPieChart_Click(object sender, EventArgs e) {
            // Create and then load new form for the pie chart depicting world energy use (in BTUs) by source.
            LoadForm(new FormPieChart());
        }

        /*  
        *  Method:     buttonBarChart_Click
        *  
        *  Purpose:    Handles when user clicks Bar Graph button.
        * 
        *  Arguments:  object       UI component sending event.
        *              EventArgs    The event.
        *              
        *  Return:     void
        */
        private void buttonBarChart_Click(object sender, EventArgs e) {
            // Create and then load new form for the area chart depicting 
            LoadForm(new FormBarChart());
        }

        /*  
        *  Method:     LoadForm
        *  
        *  Purpose:    Handles loading of graph windows.
        * 
        *  Arguments:  Form       Form to load.
        *              
        *  Return:     void
        */
        private void LoadForm(Form form) {
            // Attach custom window-closing event to the window we're about to go to.
            form.FormClosed += new FormClosedEventHandler(formClosed);

            // Hide Portal window.
            this.Hide();

            // Show graph window.
            form.Show();
        }

        /*  
        *  Method:     formClosed
        *  
        *  Purpose:    Handles when user closes graph window.
        * 
        *  Arguments:  object       UI component sending event.
        *              EventArgs    The event.
        *              
        *  Return:     void
        */
        private void formClosed(object sender, FormClosedEventArgs args) {
            // Show Portal window again.
            this.Show();
        }
    }
}
