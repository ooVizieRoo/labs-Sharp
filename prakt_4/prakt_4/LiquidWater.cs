﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_4
{
    class LiquidWater: State
    {
        public override State Cool()
        {
            return new SolidWater();
        }

        public override State Heat()
        {
            return new GasWater();

        }
        public override void GetState()
        {
            Console.WriteLine("Жидкость");
        }
    }
}
