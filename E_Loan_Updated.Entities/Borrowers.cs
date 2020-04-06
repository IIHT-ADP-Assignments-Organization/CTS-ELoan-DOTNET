using System;
using System.Collections.Generic;
using System.Text;

namespace E_Loan_Updated.Entities
{
    public class Borrowers
    {
        public virtual int BorrowerId { get; set; }
        public virtual string BorroweName { get; set; }
        public virtual string BusinessStructure { get; set; }
        public virtual string BillingIndicator { get; set; }
        public virtual string TaxIndicator { get; set; }
        public virtual string ContectNumber { get; set; }
        public virtual string Email { get; set; }
        public virtual int LoanNumber { get; set; }
    }
}
