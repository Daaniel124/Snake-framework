﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Snake_framework
{
    public class LengthException : Exception
    {
        public override string Message
        {
            get
            {
                return "Enter at least 3 characters";
            }
        }
    }
}

