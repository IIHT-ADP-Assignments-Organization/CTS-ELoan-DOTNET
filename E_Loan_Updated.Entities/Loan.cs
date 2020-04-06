using System;
using System.Collections.Generic;
using System.Text;

namespace E_Loan_Updated.Entities
{
    public class Loan
    {
        public virtual string LoanName { get; set; }
        public virtual string LoanApplicationNumber { get; set; }
        public virtual double LoanAmountRequested { get; set; }
        public virtual DateTime LoanApplicationDate { get; set; }
        public virtual int PropertId { get; set; }
        public virtual int BorrowerId { get; set; }


    }
}
