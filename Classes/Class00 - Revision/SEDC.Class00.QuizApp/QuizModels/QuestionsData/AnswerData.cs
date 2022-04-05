using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizModels.QuestionsData
{
    public class AnswerData
    {
        public string Answer { get; set; }
        public bool IsTrueAnswer { get; set; }

        public AnswerData(string answer, bool isTrue = false)
        {
            Answer = answer;
            IsTrueAnswer = isTrue;
        }
    }
}
