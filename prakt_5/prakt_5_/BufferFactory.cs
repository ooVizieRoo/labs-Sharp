using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_5_
{
    class BufferFactory
    {
        List<AbstractBuffer> dict = new List<AbstractBuffer>();

        public BufferFactory()
        {

        }

        public AbstractBuffer Get(int key)
        {
            for (int i = 0; i<dict.Count; i++ )// foreach (AbstractBuffer ab in dict)
            {
                if(dict[i].b.Length==key)//if (ab.b.Length == key)
                    if (dict[i].busy)
                    {
                        AbstractBuffer aaa = new AbstractBuffer(key);
                        dict.Add(aaa);
                        return aaa;
                    }
                    else
                    {
                        return dict[i];
                    }
            }
            AbstractBuffer bbb = new AbstractBuffer(key);
            dict.Add(bbb);
            bbb.busy = true;
            return bbb;
        }
    }
}
