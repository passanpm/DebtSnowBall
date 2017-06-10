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
        private double monthlyInterestRate;
        public StudentLoan(double principle, double interest, int monthsToPay) : base(principle, interest, monthsToPay)
        {
            this.monthlyInterestRate = this.interest / 12.0;
            this.monthlyDebt = (this.monthlyInterestRate * this.principle * Math.Pow(1.0 + this.monthlyInterestRate, this.monthsToPay))/ (Math.Pow(1.0 + this.monthlyInterestRate, this.monthsToPay) - 1);
            this.monthsToPay = 0;
            //System.Windows.Forms.MessageBox.Show(Convert.ToString(this.monthlyDebt));
        }


        public override double payMonthlyBill(double payment)
        {
            double towardInterest = this.totalOwed * this.monthlyInterestRate;

            double towardPrinciple = this.monthlyDebt - towardInterest;

            this.totalPaid += this.monthlyDebt;

            this.totalOwed -= towardPrinciple;

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
