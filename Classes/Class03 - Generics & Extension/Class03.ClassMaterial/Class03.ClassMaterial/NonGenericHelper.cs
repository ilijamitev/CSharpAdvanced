using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03.ClassMaterial
{
    public class NonGenericHelper
    {
        public void GoThroughList(List<string> stringList)
        {
            foreach (string item in stringList)
            {
                Console.WriteLine(item);
            }
        }
          public void GoThroughList(List<int> stringList)
        {
            foreach (int item in stringList)
            {
                Console.WriteLine(item);
            }
        }

        public void GetInfoForList(List<string> stringList)
        {
            Console.WriteLine($"The list has {stringList.Count} and the elements are of type {stringList[0].GetType()}");
        }
         public void GetInfoForList(List<int> stringList)
        {
            Console.WriteLine($"The list has {stringList.Count} and the elements are of type {stringList[0].GetType()}");
        }





    }
}
