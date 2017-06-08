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

        protected double totalPaid;

        protected bool fullyPaid;

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

            this.totalPaid = -1;

            this.fullyPaid = false;
        }

        public double getPrinciple()
        {
            return this.principle;
        }

        public double getInterest()
        {
            return this.interest;
        }

        public double getTotalOwed()
        {
            return this.totalOwed;
        }

        public double getTotalPaid()
        {
            return this.totalPaid;
        }

        public bool isFullyPaid()
        {
            return fullyPaid;
        }
    }
}
