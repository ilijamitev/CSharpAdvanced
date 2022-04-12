using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03.ClassMaterial
{
    public class GenericDB<T> where T : BaseEntity  // gi obvrzuvame sekogas koga ke se pravi instanca da se vnese nesto sto nasleduva od BaseEntity ili e od samata BaseEntity
    {
        private List<T> items;

        public GenericDB()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
            Console.WriteLine($"New item of type {typeof(T)} was added.");
        }

        public void PrintInfo()
        {
            foreach (T item in items)
            {
                //item.PrintInfo();
                Console.WriteLine(item);

            }
        }




    }
}
