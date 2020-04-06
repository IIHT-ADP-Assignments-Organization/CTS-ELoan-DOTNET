using System;
using System.Collections.Generic;
using System.Text;

namespace E_Loan_Updated.Entities
{
    public class LoanRepayment
    {
        public virtual string LoanNumber { get; set; }
        public virtual double AmmountRepaid { get; set; }
        public virtual string MadeOfPayment { get; set; }
        public virtual string ChequeNumber { get; set; }

    }
}
