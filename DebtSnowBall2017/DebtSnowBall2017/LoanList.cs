using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebtSnowBall2017
{
    class LoanList
    {
        private List<Loan> loanList;

        public LoanList()
        {
            this.loanList = new List<Loan>();
        }

        public void addLoan(Loan newLoan)
        {
            this.loanList.Add(newLoan);

            this.loanList.Sort(delegate(Loan L1, Loan L2){ return L1.getTotalOwed().CompareTo(L2.getTotalOwed()); });
        }

        public void printToScreen(TableLayoutPanel panel)
        {
            panel.Controls.Clear();
            foreach(Loan loan in loanList)
            {
                Label principle = new Label();
                principle.Text = Convert.ToString(loan.getPrinciple());
                panel.Controls.Add(principle);

                Label interest = new Label();
                interest.Text = Convert.ToString(loan.getInterest() * 10) + "%";
                panel.Controls.Add(interest);

                Label totalOwed = new Label();
                totalOwed.Text = Convert.ToString(loan.getTotalOwed());
                panel.Controls.Add(totalOwed);

                Label totalPaid = new Label();
                if (loan.getTotalPaid() < 0)
                {
                    totalPaid.Text = "Not Yet Calculated";
                }
                else
                {
                    totalPaid.Text = Convert.ToString(loan.getTotalPaid());
                }
                panel.Controls.Add(totalPaid);
            }
        }

        public void calculate(double salary)
        {

        }
    }
}
