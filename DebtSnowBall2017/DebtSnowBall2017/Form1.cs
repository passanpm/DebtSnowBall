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
            /*
            Label []test = new Label[17];

            int counter = 0;
            for(int i=0; i<test.Length; i++)
            {

                test[i] = new Label();
                test[i].Text = "test phrase " + i;
                if(counter == 3)
                {
                    //RowStyle temp = tableLayoutPanel1.RowStyles[tableLayoutPanel1.RowCount - 1];
                    tableLayoutPanel1.RowCount++;
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute,50));
                    counter = 0;
                }
                tableLayoutPanel1.Controls.Add(test[i]);
                counter++;
                
            }

            /*
            test.Text = "test";
            test2.Text = "another test phrase";
            test3.Text = "another test phrase";
            test4.Text = "another test phrase";
            test5.Text = "another test phrase";

            tableLayoutPanel1.Controls.Add(test);
            tableLayoutPanel1.Controls.Add(test2);
            tableLayoutPanel1.Controls.Add(test3);
            tableLayoutPanel1.Controls.Add(test4);
            tableLayoutPanel1.Controls.Add(test5);
            */



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
