using E_Loan_Updated.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Loan_Updated.BusinessLayer.Interface
{
   public interface IAdministratorServices
    {
        bool Register(User user);
        bool Login(string UserName, string password);
        bool DeleteUser(int UserId);
        bool ChangePassword(string UserName);
    }
}
