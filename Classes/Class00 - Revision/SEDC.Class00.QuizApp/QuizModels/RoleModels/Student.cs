using QuizModels.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizModels.RoleModels
{
    public class Student : User
    {
        public bool DoneTest { get; set; }
        public int CorrectAnswers = 0;
        public Student(string fullName, int password)
        {
            FullName = fullName;
            Password = password;
            Role = Enum.Role.Student;
            DoneTest = false;
        }

    }
}
