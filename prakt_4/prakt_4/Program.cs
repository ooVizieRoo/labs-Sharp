using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "The quick brown fox jumps over the lazy dog";

            Console.WriteLine("Оригинал: {0}", text);
            StringPrinter strPr = new StringPrinter(new NCPrint());
            Console.Write("NCPrint: ");
            strPr.Print(text);

            strPr.strategy = new UCPrint();
            Console.Write("UCPrint: ");
            strPr.Print(text);

            strPr.strategy = new LCPrint();
            Console.Write("LCPrint: ");
            strPr.Print(text);


            Water water = new Water();
            water.Print();

            water.Heat();
            water.Heat();
            water.Heat();
            water.Print();

            water.Cool();
            water.Cool();
            water.Print();

            Console.ReadKey();
        }
    }
}
