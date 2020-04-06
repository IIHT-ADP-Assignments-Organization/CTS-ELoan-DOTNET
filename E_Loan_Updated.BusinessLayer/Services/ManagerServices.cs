using E_Loan_Updated.BusinessLayer.Interface;
using E_Loan_Updated.DataLayer.NHibernateConfiguration;
using E_Loan_Updated.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Loan_Updated.BusinessLayer.Services
{
    public class ManagerServices : IManagerServices
    {

        private readonly IMapperSession _session;

        public ManagerServices(IMapperSession session)
        {
            _session = session;
        }
        public bool ApproveLoan(LoanAcceptance loanAcceptance, int BorrowerId)
        {
            return true;
        }

        public LoanAcceptance GetLoan(int LoanNumber)
        {
            LoanAcceptance loanAcceptance = new LoanAcceptance();
            return loanAcceptance;
        }

        public LoanAcceptance SearchLoan(int LoanNumber)
        {
            LoanAcceptance loanAcceptance = new LoanAcceptance();
            return loanAcceptance;
        }
    }
}
