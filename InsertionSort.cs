using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class InsertionSort
    {
        public InsertionSort(int[] sequence)
        {
            int key;
            int i;

            for (int j = 1; j < sequence.Length; j++)
            {
                key = sequence[j];
                i = j - 1;
                while (i >= 0 && key < sequence[i])
                {
                    sequence[i + 1] = sequence[i];
                    i--;
                }
                sequence[i + 1] = key;
            }
            Console.WriteLine(HelperMethods.PrintSequence(sequence));
        }
    }
}
