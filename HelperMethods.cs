using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class HelperMethods
    {
        public static string PrintSequence(IEnumerable<int> seq)
        {
            string retVal = "[";
            foreach (int v in seq)
            {
                retVal += String.Format("{0}, ", v);
            }
            return retVal.Substring(0, retVal.Length - 2) + "]";
        }
    }
}
