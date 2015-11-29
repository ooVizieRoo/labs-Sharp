using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_4
{
    class StringPrinter
    {
        public IStrategy strategy;

        public StringPrinter(IStrategy strategy)
        {
            this.strategy = strategy;
        }
        public void Print(string str)
        {
            Console.WriteLine(strategy.Change(str));
        }
    }
}
