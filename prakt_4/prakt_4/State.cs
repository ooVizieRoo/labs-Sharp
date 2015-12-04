using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_4
{
    abstract class State
    {
        abstract public State Heat();
        abstract public State Cool();
        abstract public void GetState();
    } 
}
