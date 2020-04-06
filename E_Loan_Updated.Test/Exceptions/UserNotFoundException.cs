using System;
using System.Collections.Generic;
using System.Text;

namespace E_Loan_Updated.Test.Exceptions
{
   public class UserNotFoundException:Exception
    {

        public string Messages = "User Not Found";

        public UserNotFoundException(string message)
        {
            Messages = message;
        }
    }
}
