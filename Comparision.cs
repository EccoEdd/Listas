using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Comparision
    {
        public int Compare(string arr1, string arr2)
        {
            int comparer = String.Compare(arr1, arr2, 
                comparisonType: StringComparison.OrdinalIgnoreCase);
            return comparer;
        }
    }
}
