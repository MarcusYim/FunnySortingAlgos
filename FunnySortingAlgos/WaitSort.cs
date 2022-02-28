using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FunnySortingAlgos
{
    class WaitSort
    {
        public void waitAndPrint(int val)
        {
            Thread.Sleep(val * 1000);
            Console.WriteLine(val);
        }

        private void waitSort(int[] arr)
        {
            var dict = arr.ToDictionary(item => item, item => item);
            Parallel.ForEach(dict, val => waitAndPrint(val.Key));
        }

        public static void Main(string[] args)
        {
            int[] arr = { 0, 3, 2, 5, 1, 9, 10 };

            WaitSort p = new WaitSort();
            p.waitSort(arr);
        }
    }
}
