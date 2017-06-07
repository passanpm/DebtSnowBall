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

            loanTypeBox.Items.Add("Student Loan");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vp = principleTextBox.Text;

            var vi = interestTextBox.Text;

            var vto = totalOwedTextBox.Text;

           if(vp.Equals("") || vi.Equals("") || vto.Equals(""))
            {
                return;
            }

            double principle = Convert.ToDouble(vp);

            double interest = Convert.ToDouble(vi);

            double totalOwed = Convert.ToDouble(vto);

            Loan newLoan;

            if(loanTypeBox.Text.Equals("Student Loan"))
            {
                newLoan = new StudentLoan(principle, interest, totalOwed, 120);
            } else
            {
                newLoan = new Loan(principle, interest, totalOwed, 120);
            }
            Label test = new Label();


            test.Text = "test";
            tableLayoutPanel1.Controls.Add(test);


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
