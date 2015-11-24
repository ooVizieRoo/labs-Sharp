using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace prakt_3
{
    class NPProxy : IService
    {
        NumPrinter numPrinter;
        int[] arr;

        public NPProxy(int n)
        {
            numPrinter = new NumPrinter(n);
            arr = numPrinter.GetNumbers();
        }

        public int[] GetNumbers()
        {
            Console.WriteLine("Работает метод SayHello() класса Proxy"); 

            int[] newArr;
            int count1 = 0, count2 = 0;

            for (int i = 0; i < arr.Length; i++)
                if (arr[i] % 2 != 0)
                    count1++;

            newArr = new int[count1];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                    newArr[count2++] = arr[i]; 
            }
            return newArr;
        }

    }
}
