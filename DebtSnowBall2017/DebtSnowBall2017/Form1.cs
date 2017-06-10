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
        private LoanList theLoanList;

        public mainWindow()
        {
            InitializeComponent();

            loanTypeBox.Items.Add("Student Loan");

            theLoanList = new LoanList();
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

            var vto = monthsInPaymentTextBox.Text;

           if(vp.Equals("") || vi.Equals("") || vto.Equals(""))
            {
                return;
            }

            double principle = Convert.ToDouble(vp);

            double interest = Convert.ToDouble(vi);

            int monthsInPayment = Convert.ToInt32(vto);

            Loan newLoan;

            if(loanTypeBox.Text.Equals("Student Loan"))
            {
                newLoan = new StudentLoan(principle, interest, monthsInPayment);
            } else
            {
                newLoan = new Loan(principle, interest, monthsInPayment);
            }

            this.theLoanList.addLoan(newLoan);
            this.theLoanList.printToScreen(tableLayoutPanel1);

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double salary = Convert.ToDouble(monthlySalaryBox.Text);
            this.theLoanList.calculate(salary);
            this.theLoanList.printToScreen(tableLayoutPanel1);
        }
    }
}
