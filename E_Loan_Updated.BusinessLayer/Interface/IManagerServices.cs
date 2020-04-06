using E_Loan_Updated.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Loan_Updated.BusinessLayer.Interface
{
    public interface IManagerServices
    {
        bool ApproveLoan(LoanAcceptance loanAcceptance, int BorrowerId);
        LoanAcceptance SearchLoan(int LoanNumber);
        LoanAcceptance GetLoan(int LoanNumber);
    }
}
