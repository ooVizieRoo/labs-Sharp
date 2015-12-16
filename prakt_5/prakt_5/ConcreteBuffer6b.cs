using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_5
{
    class ConcreteBuffer6b: AbstractBuffer
    {
        public ConcreteBuffer6b()
        {
            b = new byte[6];
            busy = false;
        }
    }
}
