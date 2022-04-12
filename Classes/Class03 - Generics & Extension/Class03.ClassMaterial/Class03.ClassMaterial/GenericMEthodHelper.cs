using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03.ClassMaterial
{
    public class GenericMEthodHelper
    {
        public void GoThroughList<T>(List<T> listOfUnknownType)
        {
            foreach (T item in listOfUnknownType)   //moze i var mesto T
            {
                Console.WriteLine(item);
            }
        }

        public void GetInfoForList<T>(List<T> listOfUnknownType)
        {
            Console.WriteLine($"There are {listOfUnknownType.Count} elements of type {typeof(T)}.");
        }




    }
}
