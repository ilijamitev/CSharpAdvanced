using ServiceLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary.Entities
{
    public class Student : User, IStudent
    {
        public List<int> Grades { get; set; }

        public override void PrintUser()
        {
            base.PrintUser();
            foreach (int grade in Grades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
