﻿using Core.Entities;
using Core.Utilities.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
       List<OperationClaim> GetClaims(User user);
        IResult Add(User user);
        IDataResult<User> GetByEmail(string email);
    }
}
