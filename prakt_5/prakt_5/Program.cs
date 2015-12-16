using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_5
{
    /*
        interface Window {}
        class XWindow : Window {}
        class WaylandWindow : Window {}
        interface IconWindow : Window {}
        class XIconWindow : XWindow, IconWindow {}
        class WaylandIconWindow : WaylandWindow, IconWindow {}
        interface ModalWindow : Window {}
        class XModalWIndow : XWindow, ModalWindow {}
        class WaylandModalWindow : WaylandWindow, ModalWindow {}
     * */

    interface Window { }
    interface WindowImplementor : Window { }
    

    class Program
    {
        static void Main(string[] args)
        {
            MessageSender ms = new MessageSender();

            ms.SendMessage("OOP");

            ms.SendMessage("12");

            ms.SendMessage("123");

            Console.Read();
        }
    }
}
