using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_03
{
    internal class ConditionFunctions
    {
        public static bool IsOdd(int x) { return x % 2 != 0; }
        public static bool IsEven(int x) { return x % 2 == 0; }
        public static bool IsDivisibleBy4(int x) { return x % 4 == 0; }

        public static bool LengthGreaterThan5(string x) { return x.Length > 5; }
        public static bool LengthEquals5(string x) { return x.Length == 5; }
        public static bool LengthLessThan5(string x) { return x.Length < 5; }
    }
}
