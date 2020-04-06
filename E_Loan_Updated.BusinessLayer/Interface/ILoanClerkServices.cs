using E_Loan_Updated.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Loan_Updated.BusinessLayer.Interface
{
   public interface ILoanClerkServices
    {
        bool NewLoanApplication(Loan loan);
        bool RepaymentsReceived(LoanRepayment loanRepayment, int BorrowerId);
        Loan SearchLoan(int BorrowerId);

        Loan GetLoan(int BorrowerId);
    }
}
