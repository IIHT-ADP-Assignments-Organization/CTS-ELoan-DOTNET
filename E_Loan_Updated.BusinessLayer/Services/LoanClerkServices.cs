using E_Loan_Updated.BusinessLayer.Interface;
using E_Loan_Updated.DataLayer.NHibernateConfiguration;
using E_Loan_Updated.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Loan_Updated.BusinessLayer.Services
{
    public class LoanClerkServices : ILoanClerkServices
    {
        private readonly IMapperSession _session;

        public LoanClerkServices(IMapperSession session)
        {
            _session = session;
        }

        public Loan GetLoan(int BarrowerId)
        {
            Loan loan = new Loan();
            return loan;
        }

        public bool NewLoanApplication(Loan loan)
        {
            return true;
        }

        public bool RepaymentsReceived(LoanRepayment loanRepayment, int BorrowerId)
        {
            return true;
        }

        public Loan SearchLoan(int BorrowerId)
        {
            Loan loan = new Loan();
            return loan;
        }
    }
}
