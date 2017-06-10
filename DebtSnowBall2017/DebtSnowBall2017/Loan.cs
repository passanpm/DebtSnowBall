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

        public Loan(double principle, double interest, int monthsToPay)
        {
            this.principle = principle;

            this.totalOwed = principle;

            this.monthsToPay = monthsToPay;

            if(interest > 1.0)
            {
                interest *= 0.01;
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

        public int getMonthsToPay()
        {
            return this.monthsToPay;
        }

        public bool isFullyPaid()
        {
            return fullyPaid;
        }

        public void payExtra(double payment)
        {
            
            if(this.totalOwed < payment)
            {
                this.fullyPaid = true;
                this.totalPaid += totalOwed;
            }
            this.totalOwed -= payment;
            this.totalPaid += payment;
        }

        public virtual double payMonthlyBill(double payment)
        {

            return 0.0;
        }
    }
}
