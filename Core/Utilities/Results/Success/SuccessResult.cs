﻿using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Success
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true,message) 
        {

        }

        public SuccessResult() : base(true)
        {

        }
    }
}
