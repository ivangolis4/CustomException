﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class NumberFormatException : Exception
    {
        public NumberFormatException(string ex) : base(ex)
        {
            
        }
        
    }
}
