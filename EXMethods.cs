using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqtest
{
    public static class EXMethods
    {
        public static bool isavailable( this string book, List<string> books)
        {
            return books.Contains(book);
        }
        public static string gettitle( this string book)
        {
            return book;
        }
    }
}
