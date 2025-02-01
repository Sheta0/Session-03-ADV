using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    public delegate string BookDelegate(Book B);
    public class LibraryEngine
    {
        public static void ProcessBooks (List<Book> bList, /*BookDelegate*/ Func<Book, string> fPtr)
        {
            foreach (Book b in bList)
            {
                Console.WriteLine(fPtr(b));
            }
        }
    }
}
