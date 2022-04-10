using ServiceLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary.Entities
{
    public class Teacher : User, ITeacher
    {
        public string Subject { get; set; }
        public override void PrintUser()
        {
            base.PrintUser();
            Console.WriteLine(Subject);
        }
    }
}
