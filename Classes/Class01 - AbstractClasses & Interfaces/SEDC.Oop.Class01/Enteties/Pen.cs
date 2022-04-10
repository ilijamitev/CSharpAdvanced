using Enteties.Interfacees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteties
{
    public class Pen : ITakingNotes
    {

        void ITakingNotes.WriteNote()
        {
            Console.WriteLine("Writing a note with Pen");
        }
    }
}
