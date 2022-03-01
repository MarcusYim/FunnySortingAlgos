using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnySortingAlgos
{
    static class RandomExtensions
    {
        public static void Shuffle<T>(this Random rng, T[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
    }
    class QuantumBogosort
    {
        private Boolean isSorted(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    return false;
                }
            }

            return true;
        }

        public void oneBogosort(int[] arr)
        {
            if (isSorted(arr))
            {
                return;
            }

            var rng = new Random();
            rng.Shuffle(arr);

            if (isSorted(arr))
            {
                foreach (int i in arr)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void fakeQuantumBogosort(int[] arr)
        {
            var dict = arr.ToDictionary(item => item, item => item);
            while (true)
            {
                Parallel.ForEach(dict, val => oneBogosort(arr));
            }
            
        }
        public void quantumBogosort(int[] arr)
        {
            //TO DO
        }

        public static void Main(string[] args)
        {
            int[] arr = { 1, 3, 2, 25, 10, 9, 14 };

            QuantumBogosort p = new QuantumBogosort();
            p.fakeQuantumBogosort(arr);
        }
    }
}
