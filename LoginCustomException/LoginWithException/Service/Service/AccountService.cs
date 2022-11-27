using Domain.Models;
using Service.Exceptions;
using Service.Exceptions.ExceptionMessages;
using Service.Regexes;
using Service.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Service.Service
{
    public class AccountService : IAccountService
    {
        public bool CheckLogin(User user)
        {
            if (!MyRegexCommands.reg1.IsMatch(user.UserName))
            {
                if (MyRegexCommands.reg2.IsMatch(user.Email))
                {
                    if (!MyRegexCommands.reg1.IsMatch(user.Password))
                    {
                        return true;
                    }
                }
            }

            throw new LoginWorningException(ExceptionMessages.LoginWarning);
        }

        
    }
}
