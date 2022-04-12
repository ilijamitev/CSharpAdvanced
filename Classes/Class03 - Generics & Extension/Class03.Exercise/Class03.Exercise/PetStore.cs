using Class03.Exercise.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03.Exercise
{
    public class PetStore<T> where T : Pet
    {
        public List<T> PetsList { get; set; }
        public void PrintPet()
        {
            foreach (T item in PetsList)
            {
                item.PrintInfo();
            }
        }
        public void BuyPet(string name)
        {
            foreach (T item in PetsList)
            {
                // T removed;   // PODOBAR NACIN
                if (item.Name == name)
                {
                    Console.WriteLine("Congrats you have a new pet.");
                    //  removed = item;
                    PetsList.Remove(item);
                    break;
                }
                else
                {
                    Console.WriteLine("No pet by that name found!");
                }

            }
            // PetsList.Remove(removed);
        }

        public PetStore(List<T> petsList)
        {
            PetsList = petsList;
        }




    }
}
