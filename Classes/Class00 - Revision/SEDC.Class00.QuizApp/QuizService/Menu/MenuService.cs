using QuizModels.BaseModel;
using QuizModels.QuestionsData;
using QuizModels.RoleModels;

namespace QuizService
{
    public class MenuService
    {
        public static void LoginMenu()
        {
            HelpersService.ShowApplicationMessages("\n\n        *** WELCOME TO OUR QUIZ APP ***\n                  Have fun :)\n\n");
            QuestionsDatabase.InitialQuestionDatabase();

            while (true)
            {
                string fullName = string.Empty;
                int password;
                HelpersService.ShowApplicationMessages("Login as:\n1.Teacher\n2.Student\n3.Exit");
                string loginChoice = LoginService.LoginChoice();
                if (loginChoice == "3") break;

                User logedInUser = LoginService.LoginUser(loginChoice);
                if (loginChoice == "1")
                {
                    Teacher teacher = (Teacher)ValidationService.GetUser("1", logedInUser.FullName, logedInUser.Password);
                    HelpersService.ShowApprovalMessage($"\n       Welcome teacher {teacher.FullName}\n");
                    TeacherService.ShowStudentQuizStats();
                    LoginService.ResetLoginTries();
                    HelpersService.ShowApplicationMessages("Press any key to logout");
                    Console.ReadLine();
                    continue;
                }
                else if (loginChoice == "2")
                {
                    Student student = (Student)ValidationService.GetUser("2", logedInUser.FullName, logedInUser.Password);
                    if (student.DoneTest)
                    {
                        HelpersService.ShowErrorMessage($"YOU HAVE ALREADY DONE THE TEST {student.FullName.ToUpper()}!\n");
                        continue;
                    }
                    HelpersService.ShowApprovalMessage($"\n       Welcome student {student.FullName}\n");
                    StudentMenu(student);
                    student.DoneTest = true;
                    LoginService.ResetLoginTries();
                    HelpersService.ShowApplicationMessages("Press any key to logout");
                    Console.ReadLine();
                    continue;
                }
            }
            Console.ReadLine();
            ShowEnd();
        }


        public static void StudentMenu(Student student)
        {
            StudentService.DoQuiz(student);
            HelpersService.ShowApprovalMessage($"Congrats {student.FullName}. You have {student.CorrectAnswers} correct answers.");
        }

        public static void ShowEnd()
        {
            Console.Clear();
            HelpersService.ShowApplicationMessages("\n\n\n\n\n        *** THANK YOU FOR USING OUR QUIZ APP ***\n                   Come back soon :)\n\n");
        }



    }
}
