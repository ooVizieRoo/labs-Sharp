﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_3
{
    class RUGreeter:IGreeter 
    {
        string intro = "Здорово!";
        public void SayHello()
        {
            Console.WriteLine(intro);
        }
    }
}
