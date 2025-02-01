using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_03
{
    internal class SortingConditions
    {
        public static bool CompareAscending(int x, int y) { return x > y; }
        public static bool CompareDescending(int x, int y) { return x < y; }
        public static bool CompareAscending(string x, string y) { return x.Length > y.Length; }
        public static bool CompareDescending(string x, string y) { return x.Length < y.Length; }
    }
}
