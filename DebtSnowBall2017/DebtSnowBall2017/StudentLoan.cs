using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtSnowBall2017
{
    class StudentLoan : Loan
    {
        public StudentLoan(double principle, double interest, double totalOwed, int monthsToPay) : base(principle, interest, totalOwed, monthsToPay)
        {
        }
    }
}
