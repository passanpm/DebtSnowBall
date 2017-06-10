using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtSnowBall2017
{
    class StudentLoan : Loan
    {
        private double monthlyDebt;
        public StudentLoan(double principle, double interest, int monthsToPay) : base(principle, interest, monthsToPay)
        {
            double monthlyInterestRate = this.interest / 12.0;
            this.monthlyDebt = (monthlyInterestRate * this.principle * Math.Pow(1.0 + monthlyInterestRate, this.monthsToPay))/ (Math.Pow(1.0 + monthlyInterestRate, this.monthsToPay) - 1);
            //System.Windows.Forms.MessageBox.Show(Convert.ToString(this.monthlyDebt));
        }


        public override double payMonthlyBill(double payment)
        {
            this.totalOwed += (this.totalOwed * this.interest) / 12.0;

            this.totalOwed -= this.monthlyDebt;

            this.totalPaid += this.monthlyDebt;

            if(this.totalOwed < this.monthlyDebt)
            {
                this.monthlyDebt = this.totalOwed;
            }

            if(this.totalOwed + 1.0 == 1.0)
            {
                this.fullyPaid = true;
            }
            this.monthsToPay++;

            return payment - this.monthlyDebt;
        }


    }
}
