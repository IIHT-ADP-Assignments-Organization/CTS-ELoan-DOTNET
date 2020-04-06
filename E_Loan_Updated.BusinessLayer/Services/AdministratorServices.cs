using E_Loan_Updated.BusinessLayer.Interface;
using E_Loan_Updated.DataLayer.NHibernateConfiguration;
using E_Loan_Updated.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Loan_Updated.BusinessLayer.Services
{
    public class AdministratorServices : IAdministratorServices
    {

        private readonly IMapperSession _session;

        public AdministratorServices(IMapperSession session)
        {
            _session = session;
        }

        public bool ChangePassword(string UserName)
        {
            return true;
        }

        public bool DeleteUser(int UserId)
        {
            return true;
        }

        public bool Login(string UserName, string password)
        {
            return true;
        }

        public bool Register(User user)
        {
            return true;
        }
    }
}
