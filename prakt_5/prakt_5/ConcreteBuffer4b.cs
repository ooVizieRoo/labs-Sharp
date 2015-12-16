using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_5
{
    class ConcreteBuffer4b: AbstractBuffer
    {
        public ConcreteBuffer4b()
        {
            b = new byte[4];

            busy = false;
        }
    }
}
