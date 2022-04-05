using QuizModels.BaseModel;
using QuizModels.Enum;
using QuizModels.QuestionsData;
using QuizModels.RoleModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizModels.UsersDatabase
{
    public class UsersDatabase
    {
        public static List<Student> StudentList = new List<Student>()
        {
            new Student("Ilija Mitev", 3333),
            new Student("Stefan Stefanovski", 3333),
            new Student("Marko Markovski", 3333),
            new Student("Bob Bobsky", 3333),
            new Student("Rob Robsky", 3333),
            new Student("Jon Jonsky", 3333),
            new Student("Don Donsky", 3333),
        };

        public static List<Teacher> TeacherList = new List<Teacher>()
        {
            new Teacher("John Doe", 1111),
            new Teacher("Jane Doe", 1111),
        };

    }
}
