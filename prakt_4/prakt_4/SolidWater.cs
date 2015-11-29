using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_4
{
    class SolidWater:IState
    {
        public void GetState()
        {
            Console.WriteLine("Лед");
        }
    }
}
