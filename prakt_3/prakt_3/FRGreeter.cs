using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_3
{
    class FRGreeter: IGreeter
    {
        string intro = "Salut!";
        public void SayHello()
        {
            Console.WriteLine(intro);
        }
    }
}
