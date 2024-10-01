using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class StringFormatException : Exception
    {
        public StringFormatException(string ex) : base(ex) 
        {
        }
    }
}
