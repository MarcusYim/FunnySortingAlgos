using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace FunnySortingAlgos
{
    class PowerSort
    {
        public void powerSort(int[] arr)
        {
            BigInteger sum = new BigInteger(0);

            foreach (int i in arr)
            {
                sum += BigInteger.Pow(2, i);
            }

            while (sum > arr[0])
            {
                int currentNum = (int) BigInteger.Log(sum, 2);
                Console.WriteLine(currentNum);
                sum -= BigInteger.Pow(2, currentNum);
            }
        }
        /*
        public static void Main(string[] args)
        {
            int[] arr = { 1, 3, 2, 25, 10, 9, 14 };

            PowerSort p = new PowerSort();
            p.powerSort(arr);
        }
        */
    }
}
