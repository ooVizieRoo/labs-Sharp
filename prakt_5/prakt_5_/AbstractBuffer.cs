using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_5_
{
    class AbstractBuffer
    {
        public byte[] b;

        public bool busy = false;

        public AbstractBuffer(int key)
        {
            b = new byte[key];
        }
    }
}
