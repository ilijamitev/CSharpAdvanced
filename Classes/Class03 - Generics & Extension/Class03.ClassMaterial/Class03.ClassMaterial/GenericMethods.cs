using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03.ClassMaterial
{
    public class GenericMethods
    {
        // T ==> Type Argument
        public void PrintObject<TFirst, TSecond>(TFirst objectToPrint, TSecond secondObject)
        {
            Console.WriteLine(objectToPrint);
            Console.WriteLine(typeof(TFirst));   // isto so gore
            Console.WriteLine(secondObject);
            Console.WriteLine(typeof(TSecond));
            //Console.WriteLine(objectToPrint.GetType().ToString());  
        }



    }
}
