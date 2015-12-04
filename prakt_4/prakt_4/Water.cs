using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_4
{
    class Water
    {
        public  State state = null;

        public Water()
        {
            state = state = new LiquidWater();
        }
        //греем воду
        public void Heat()
        {
            state = state.Heat();
        }
        //охлаждаем воду
        public void Cool()
        {
            state = state.Cool();
        }

        //Выводим состояние на экран
        public void Print()
        {
            state.GetState();
        }

    }
}
