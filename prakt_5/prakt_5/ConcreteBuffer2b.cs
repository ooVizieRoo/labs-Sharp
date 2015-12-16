using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_5
{
    class ConcreteBuffer2b: AbstractBuffer
    {
        public ConcreteBuffer2b()
        {
            b = new byte[2];

            busy = false;
        }
    }
}
