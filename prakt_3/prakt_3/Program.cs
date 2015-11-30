using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_3
{
    public interface IGreeter
    {
        void SayHello();
    }
    public interface IService
    {
        int[] GetNumbers();
    }

    class Program
    {
        static void Main(string[] args)
        {
            IGreeter iGr1 = new AdapterGE(); 
            iGr1.SayHello();
            
            int n = 5;
            NPProxy prx1 = new NPProxy(n);

            int[] arr = prx1.GetNumbers();

            arr = prx1.GetNumbers();
            arr = prx1.GetNumbers();
            arr = prx1.GetNumbers();
            arr = prx1.GetNumbers();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }

    }
}
