using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FunnySortingAlgos
{
    class StalinSort
    {
        public void stalinSort(int[] arr)
        {
            Dictionary<int, int> dict = arr.ToDictionary(item => item, item => item);
            Dictionary<int, int> ret = new Dictionary<int, int>();

            for (int i = 1; i < dict.Count; i++)
            {
                ret[i] = dict[i];

                if (dict[i - 1] >= dict[1])
                {
                    ret[i - 1] = dict[i - 1];
                }
            }

            foreach (int i in dict.Keys)
            {
                Console.WriteLine(i);
            }
        }
        /*
        public static void Main(string[] args)
        {
            int[] arr = { 0, 3, 2, 5, 1, 9, 10 };

            StalinSort p = new StalinSort();
            p.stalinSort(arr);
        }
        */
    }
}
