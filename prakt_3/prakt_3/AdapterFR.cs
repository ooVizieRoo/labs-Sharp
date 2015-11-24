using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_3
{
    //Адаптер уровня объктов для французского языка
    class AdapterFR: IGreeter 
    {
        Printer printer1 = new Printer();
        FRGreeter frGr1 = new FRGreeter();

        public string SayHello()
        {
            printer1.Print(frGr1.SayHello());
            return "";
        }
    }
}
