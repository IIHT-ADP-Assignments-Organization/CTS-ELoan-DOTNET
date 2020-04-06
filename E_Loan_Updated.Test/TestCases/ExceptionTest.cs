using E_Loan_Updated.BusinessLayer.Services;
using E_Loan_Updated.DataLayer.NHibernateConfiguration;
using E_Loan_Updated.Entities;
using E_Loan_Updated.Test.Exceptions;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace E_Loan_Updated.Test.TestCases
{
   public class ExceptionTest
    {

        private readonly AdministratorServices _AdministratorServices;
        private readonly LoanClerkServices _LoanClerkServices;
        private readonly ManagerServices _ManagerServices;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public ExceptionTest()
        {
            _AdministratorServices = new AdministratorServices(_session);
            _LoanClerkServices = new LoanClerkServices(_session);
            _ManagerServices = new ManagerServices(_session);
        }

        [Fact]
        public void ExceptionTestFor_UserNotFound()
        {
            User user = new User()
            {
                UserName = "abc",
                UserPassword = "123"

            };
            //Assert
            var ex = Assert.Throws<UserNotFoundException>(() => _AdministratorServices.Login(user.UserName, user.UserPassword));
            Assert.Equal("User Not Found ", ex.Messages);
        }
        [Fact]
        public void ExceptionTestFor_LoanDetailsNotFoundforLoanAcceptence()
        {
            LoanAcceptance loanacceptance = new LoanAcceptance()
            {
                LoanNumber = 123

            };
            //Assert
            var ex = Assert.Throws<LoandetailsNotFoundException>(() => _ManagerServices.SearchLoan(loanacceptance.LoanNumber));
            Assert.Equal("Loan Details Not Found ", ex.Messages);
        }



        [Fact]
        public void ExceptionTestFor_UserCannotblank()
        {
            User user = new User()
            {
                UserName = "",
                UserPassword = "123",
                ReTypePassword = "123",
                Role = ""
            };
            //Assert
            var ex = Assert.Throws<FieldscannotEmptyException>(() => _AdministratorServices.Register(user));
            Assert.Equal("Fields can not be blank ", ex.Messages);
        }
        [Fact]
        public void ExceptionTestFor_LoanCannotblank()
        {
            Loan loan = new Loan()
            {
                LoanName = "",
                LoanApplicationNumber = "123",
                LoanAmountRequested = 10000,
                LoanApplicationDate = DateTime.Now,
            };
            //Assert
            var ex = Assert.Throws<FieldscannotEmptyException>(() => _LoanClerkServices.NewLoanApplication(loan));
            Assert.Equal("Fields can not be blank ", ex.Messages);
        }
        [Fact]
        public void ExceptionTestFor_LoanDetailsNotFoundforLoan()
        {
            Loan loan = new Loan()
            {
                BorrowerId = 2

            };
            //Assert
            var ex = Assert.Throws<LoandetailsNotFoundException>(() => _LoanClerkServices.SearchLoan(loan.BorrowerId));
            Assert.Equal("Loan Details Not Found ", ex.Messages);
        }
    }
}
