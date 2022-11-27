using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Service.Exceptions
{
    public class LoginWorningException : Exception
    {
        public LoginWorningException(string message) : base(message)
        {

        }
    }
}
