using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebtSnowBall2017
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double principle = Convert.ToDouble(principleTextBox.Text);

            double interest = Convert.ToDouble(interestTextBox.Text);

            double totalOwed = Convert.ToDouble(totalOwedTextBox.Text);

            


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
