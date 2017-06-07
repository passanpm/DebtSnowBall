using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtSnowBall2017
{
    class Loan
    {
        protected double principle;

        protected double interest;

        protected double totalOwed;

        protected int monthsToPay;

        public Loan(double principle, double interest, double totalOwed, int monthsToPay)
        {
            this.principle = principle;

            this.totalOwed = totalOwed;

            this.monthsToPay = monthsToPay;

            if(interest > 1.0)
            {
                interest *= 0.1;
            }

            this.interest = interest;
        }
    }
}
