using QuizModels.QuestionsData;
using QuizModels.RoleModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizService
{
    public class StudentService
    {
        public static void DoQuiz(Student student)
        {
            HelpersService.ShowApprovalMessage($"\nGOOD LUCK WITH THE QUIZ {student.FullName.ToUpper()}!\n");
            foreach (var item in QuestionsDatabase.QuestionsAndAnswers)
            {
                HelpersService.ShowQuestion(item.Key.ToString());
                int i = 0;
                while (i < item.Value.Count)
                {
                    HelpersService.ShowInformation(item.Value[i].Answer.ToString());
                    i++;
                }
                HelpersService.ShowApplicationMessages("Your final answer is:");
                while (true)
                {
                    string studentAnswer = Console.ReadLine();
                    bool validateInput = ValidationService.ValidateUserChoice(studentAnswer, new string[] { "1", "2", "3", "4" });
                    if (validateInput)
                    {
                        int answer = int.Parse(studentAnswer);
                        if (item.Value[answer - 1].IsTrueAnswer)
                        {
                            student.CorrectAnswers++;
                        }
                        break;
                    }
                    else
                    {
                        HelpersService.ShowErrorMessage("SELECT VALID OPTION!");
                        continue;
                    }
                }
            }

        }
    }
}
