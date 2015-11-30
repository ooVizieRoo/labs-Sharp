using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_3
{
    //Адаптер уровня объктов для французского языка
    class AdapterGE: IGreeter 
    {
        Printer printer1 = new Printer();
        string intro = "Hallo";

        public void SayHello()
        {
            printer1.Print(intro);
        }
    }
}
