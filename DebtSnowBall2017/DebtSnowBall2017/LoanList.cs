using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
