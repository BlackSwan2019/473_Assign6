using System;
using System.Windows.Forms;

namespace Assign6 {
    public partial class Form1 : Form {
        Form2 form2;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            form2 = new Form2();
        }

        private void buttonLineChart_Click(object sender, EventArgs e) {
            LoadForm(new Form2());
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
