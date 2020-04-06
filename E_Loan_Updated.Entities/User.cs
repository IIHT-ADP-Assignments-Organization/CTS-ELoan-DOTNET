using System;
using System.Collections.Generic;
using System.Text;

namespace E_Loan_Updated.Entities
{
    public class User
    {
        public virtual int UserId { get; set; }
        public virtual string UserName { get; set; }
        public virtual string UserPassword { get; set; }
        public virtual string ReTypePassword { get; set; }
        public virtual string Role { get; set; }
        
       

    }
}
