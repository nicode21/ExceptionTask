﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interface
{
    public interface IAccountService
    {
        bool Register(User user);

        User UserGetById(int? id);
    }
}
