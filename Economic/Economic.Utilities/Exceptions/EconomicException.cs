using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.Utilities.Exceptions
{
    public class EconomicException : Exception
    {
        public EconomicException()
        {

        }
        public EconomicException(string message)
        {

        }
        public EconomicException(string messagr, Exception inner) : base(messagr, inner)
        {

        }
    }
}
