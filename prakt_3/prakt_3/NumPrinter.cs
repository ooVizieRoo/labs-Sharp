using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace prakt_3
{
    internal class NumPrinter : IService 
    {
        private int n;

        public NumPrinter(int n)
        {
            this.n = n; 
        }

        public int[] GetNumbers()
        {

            int[] arr = new int[n+1];

            for (int i = 0; i < arr.Length; i++)
                arr[i] = i;

            Thread.Sleep(10000);
            
            return arr;

        }
    }
}
