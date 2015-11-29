using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_4
{
    class Water
    {
        IState state = null;
        sbyte indexState;

        public Water()
        {
            state = new LiquidWater();
            indexState = 1;
        }
        //греем воду
        public void Heat()
        {
            indexState++;
            ChangeState();
        }
        //охлаждаем воду
        public void Cool()
        {
            indexState--;
            ChangeState();
        }

        //меняем агрегатное состояние воды
        void ChangeState()
        {
            switch (indexState)
            {
                case 0:
                    {
                        state = new SolidWater();
                        break;
                    }
                case 1:
                    {
                        state = new LiquidWater();
                        break;
                    }
                case 2:
                    {
                        state = new GasWater();
                        break;
                    }
                default:
                    {
                        if (indexState > 2)
                            indexState = 2;

                        if (indexState < 0)
                            indexState = 0;
                        break;
                    }
            }
        }

        public void Print()
        {
            state.GetState();
        }

    }
}
