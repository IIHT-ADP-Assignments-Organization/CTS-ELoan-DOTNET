using E_Loan_Updated.BusinessLayer.Services;
using E_Loan_Updated.DataLayer.NHibernateConfiguration;
using E_Loan_Updated.Entities;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace E_Loan_Updated.Test.TestCases
{
    public class FunctionalTest
    {

        private readonly AdministratorServices _AdministratorServices;
        private readonly LoanClerkServices _LoanClerkServices;
        private readonly ManagerServices _ManagerServices;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public FunctionalTest()
        {
            _AdministratorServices = new AdministratorServices(_session);
            _LoanClerkServices = new LoanClerkServices(_session);
            _ManagerServices=new ManagerServices(_session);
        }

        [Fact]
        public void Test_for_ChangePassword()
        {
            User user = new User()
            {
                UserName = "aa"
            };

            var Result = _AdministratorServices.ChangePassword(user.UserName);
            Assert.True(Result);
        }

        [Fact]
        public void Test_for_DeleteUser()
        {
            User user = new User()
            {
                UserId = 1
            };

            var Result = _AdministratorServices.DeleteUser(user.UserId);
            Assert.True(Result);
        }

        [Fact]
        public void Test_for_Login()
        {
            User user = new User()
            {
             
                UserName = "aa",
                UserPassword="111"

            };

            var Result = _AdministratorServices.Login(user.UserName, user.UserPassword);
            Assert.True(Result);
        }

        [Fact]
        public void Test_for_Register()
        {
            User user = new User()
            {
                UserId=2,
                UserName = "aa",
                UserPassword = "111",
                ReTypePassword="aa",
                Role="Admin"
            };

            var Result = _AdministratorServices.Register(user);
            Assert.True(Result);
        }


        [Fact]
        public void Test_for_NewLoanApplication()
        {
            Loan loan = new Loan()
            {
                LoanName="11",
                BorrowerId=1,
                LoanAmountRequested=11,
                LoanApplicationDate=DateTime.Now,
                LoanApplicationNumber="ss",
                PropertId=1

            };

            var Result = _LoanClerkServices.NewLoanApplication(loan);
            Assert.True(Result);
        }

        [Fact]
        public void Test_for_RepaymentsReceived()
        {
            LoanRepayment loanRepayment = new LoanRepayment()
            {
                LoanNumber = "dd",
                ChequeNumber = "dd",
                AmmountRepaid = 11,
                MadeOfPayment = "dd"

            };

            Borrowers borrowers = new Borrowers()
            {
                BorrowerId = 1
            };

            var Result = _LoanClerkServices.RepaymentsReceived(loanRepayment,borrowers.BorrowerId);
            Assert.True(Result);
        }

        [Fact]
        public void Test_for_SearchLoan()
        {
            

            Borrowers borrowers = new Borrowers()
            {
                BorrowerId = 1
            };

            var Result = _LoanClerkServices.SearchLoan(borrowers.BorrowerId);
            var GetLoan = _LoanClerkServices.GetLoan(borrowers.BorrowerId);
            Assert.Equal(GetLoan,Result);
        }

        [Fact]
        public void Test_for_ApproveLoan()
        {


            LoanAcceptance loanAcceptance = new LoanAcceptance()
            {
               LoanNumber=11,
               PropertId=1,
               SanctionedDate=DateTime.Now,
               SanctioningOfficial="ss",
               RegionalOffice="ss"
            };

            Borrowers borrowers = new Borrowers()
            {
                BorrowerId = 1
            };

            var Result = _ManagerServices.ApproveLoan(loanAcceptance, borrowers.BorrowerId);
          
            Assert.True(Result);
        }


        [Fact]
        public void Test_for_SearchLoanForAcceptLoan()
        {


            LoanAcceptance loanAcceptance = new LoanAcceptance()
            {
                LoanNumber = 11,
               
            };

           

            var Result = _ManagerServices.SearchLoan(loanAcceptance.LoanNumber);
            var GetLoan = _ManagerServices.GetLoan(loanAcceptance.LoanNumber);

            Assert.Equal(GetLoan,Result);
        }


    }
}
