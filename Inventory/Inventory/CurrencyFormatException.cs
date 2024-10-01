using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class CurrencyFormatException : Exception
    {
        public CurrencyFormatException(string ex) : base(ex) 
        {
        }

    }
}
