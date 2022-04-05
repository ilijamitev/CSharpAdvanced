using QuizModels.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizModels.RoleModels
{
    public class Teacher : User
    {
        public Teacher(string fullName, int password)
        {
            FullName = fullName;
            Password = password;
            Role = Enum.Role.Teacher;
        }

    }
}
