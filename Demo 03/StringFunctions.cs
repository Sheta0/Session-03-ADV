using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_03
{
    internal class StringFunctions
    {
        public static int GetUpperCaseCount(string word)
        {
            int count = 0;
            if(!string.IsNullOrEmpty(word))
            {
                foreach (char c in word)
                {
                    if (char.IsUpper(c))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public static int GetLowerCaseCount(string word)
        {
            int count = 0;
            if(!string.IsNullOrEmpty(word))
            {
                foreach (char c in word)
                {
                    if (char.IsLower(c))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
