using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptiondemo_2
{
    internal class WrongException:Exception
    {
        public WrongException(string message) : base(message) { }
        
    }
}
