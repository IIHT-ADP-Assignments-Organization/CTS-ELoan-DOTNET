using E_Loan_Updated.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace E_Loan_Updated.Test.TestCases
{
  public  class BoundaryTest
    {
        [Fact]
        public void BoundaryTest_ForPhoneNo_Length()
        {
            Borrowers borrower = new Borrowers()
            {
                ContectNumber =" 981114564"
            };
            var MinLength = 10;
            var MaxLength = 10;

            //Action
            var actualLength = borrower.ContectNumber.ToString().Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }
        [Fact]
        public void BoundaryTest_ForSanctionedDate()
        {

            LoanAcceptance loanacceptance = new LoanAcceptance()
            {
                SanctionedDate = DateTime.Now
            };

            //Action
            var DatePattern = loanacceptance.SanctionedDate.ToString();


            //Assert
            Assert.Matches(DatePattern, "dd-mm-yyyy");
        }

        [Fact]
        public void BoundaryTest_ForUserName_Length()
        {

            User user = new User()
            {
                UserName = "111"
            };
            //Arrange
            var MinLength = 0;
            var MaxLength = 50;

            //Action
            var actualLength = user.UserName.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }
        [Fact]
        public void BoundaryTest_ForPassword_Length()
        {
            User user = new User()
            {
                UserPassword = "111"
            };
            var MinLength = 8;
            var MaxLength = 25;

            //Action
            var actualLength = user.UserPassword.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

    }
}
