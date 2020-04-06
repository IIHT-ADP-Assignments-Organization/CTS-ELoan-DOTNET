using System;
using System.Collections.Generic;
using System.Text;

namespace E_Loan_Updated.Entities
{
   public class LoanAcceptance
    {
        public virtual int LoanNumber { get; set; }
        public virtual string RegionalOffice { get; set; }
        public virtual DateTime SanctionedDate { get; set; }
        public virtual string SanctioningOfficial { get; set; }
        public virtual int PropertId { get; set; }
    }
}
