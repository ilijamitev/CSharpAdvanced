using QuizModels.UsersDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizService
{
    public class TeacherService
    {
        public static void ShowStudentQuizStats()
        {
            foreach (var student in UsersDatabase.StudentList)
            {
                if (student.DoneTest)
                {
                    HelpersService.ShowApprovalMessage($"Student {student.FullName} has {student.CorrectAnswers} correct answers.");
                }
                else
                {
                    HelpersService.ShowErrorMessage($"Student {student.FullName} hasn't done the test yet.");
                }
            }
            Console.ReadLine();
        }

    }
}
