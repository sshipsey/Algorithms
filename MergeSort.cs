using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class MergeSort
    {
        public MergeSort()
        {
        }

        public int[] Sort(int[] seq, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                seq = Sort(seq, p, q);
                seq = Sort(seq, q + 1, r);
                seq = Merge(seq, p, q, r);
            }
            return seq;
        }
        //    Original
        //    { 5, 2, 4, 6, 1, 3 };
        public int[] Merge(int[] seq, int p, int q, int r)
        {
            List<int> retVal = new List<int>();
            int n = q - p + 1;
            int m = r - q;

            int j = 0, i = 0;

            int[] left = new int[n + 1];
            int[] right = new int[m + 1];

            for (i = 0; i < n; i++)
            {
                left[i] = seq[p + i];
            }
            for (i = 0; i < m; i++)
            {
                right[i] = seq[q + i + 1];
            }
            i = 0;
            j = 0;
            left[left.Length - 1] = 500;
            right[right.Length - 1] = 500;

            for (int k = p; k < r + 1; k++)
            {
                if (left[i] <= right[j])
                {
                    retVal.Add(left[i]);
                    i += 1;
                }
                else
                {
                    retVal.Add(right[j]);
                    j += 1;
                }
            }
            return retVal.ToArray();
        }
    }
}
