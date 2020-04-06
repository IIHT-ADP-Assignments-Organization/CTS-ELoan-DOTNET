using System;
using System.Collections.Generic;
using System.Text;

namespace E_Loan_Updated.Test.Exceptions
{
    public class LoandetailsNotFoundException:Exception
    {
        public string Messages =" Loan Details Not Found ";

        public LoandetailsNotFoundException(string message)
        {
            Messages = message;
        }
    }
}
