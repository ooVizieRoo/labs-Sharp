using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_5
{
    class BufferFactory
    {
        Dictionary<int, AbstractBuffer> dict = new Dictionary<int, AbstractBuffer>();

        public BufferFactory()
        {
            dict.Add(2, new ConcreteBuffer2b());
            dict.Add(4, new ConcreteBuffer4b());
            dict.Add(6, new ConcreteBuffer6b());
        }

        public AbstractBuffer Get(int key)
        {

            if (dict[key].busy)
            {
                switch (key)
                {
                    case 2:
                        return new ConcreteBuffer2b();
                    case 4:
                        return new ConcreteBuffer4b();
                    case 6:
                        return new ConcreteBuffer6b();
                }
            }

            dict[key].busy = true;
            return dict[key];
        }
    }
}
