using System;
using System.Collections.Generic;
using System.Text;

namespace E_Loan_Updated.Entities
{
   public class LoanAmortization
    {
        public virtual DateTime TimesOfLoan { get; set; }
        public virtual DateTime RepaymentStartDate { get; set; }
        public virtual DateTime LoanClosureDate { get; set; }
        public virtual string InterestRate { get; set; }
        public virtual double MonthlyPayementAmount { get; set; }
    }
}
