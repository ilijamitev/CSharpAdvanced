using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03.Extensionss
{
    public static class ListExtensions
    {
        public static void PrintElements<T>(this List<T> listToPrint)
        {
            foreach (T item in listToPrint)
            {
                Console.WriteLine(item);    
            }
        }
    }
}
