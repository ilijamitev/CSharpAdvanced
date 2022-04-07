using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizModels.QuestionsData
{
    public class QuestionsDatabase
    {
        public static Dictionary<string, List<AnswerData>> QuestionsAndAnswers = new Dictionary<string, List<AnswerData>>();

        public QuestionsDatabase()
        {
            
        }

        public static void AddQuestions(string question, List<AnswerData> listOfAnswers)
        {
            QuestionsAndAnswers.Add(question, listOfAnswers);
        }

        public static void InitialQuestionDatabase()
        {
            AddQuestions("Q: What is the capital of Tasmania?", new List<AnswerData>() {
            new AnswerData("a: Dodoma"),
            new AnswerData("b: Hobart", true),
            new AnswerData("c: Launceston"),
            new AnswerData("d: Wellington"),
            });

            AddQuestions("Q: What is the tallest building in the Republic of the Congo?", new List<AnswerData>() {
            new AnswerData("a: Kinshasa Democratic Republic of the Congo Temple"),
            new AnswerData("b: Palais de la Nation"),
            new AnswerData("c: Kongo Trade Centre"),
            new AnswerData("d: Nabemba Tower", true),
            });

            AddQuestions("Q: Which of these is not one of Pluto's moons?", new List<AnswerData>() {
            new AnswerData("a: Styx"),
            new AnswerData("b: Hydra"),
            new AnswerData("c: Nix", true),
            new AnswerData("d: Lugia"),
            });

            AddQuestions("Q: What is the smallest lake in the world?", new List<AnswerData>() {
            new AnswerData("a: Onega Lake"),
            new AnswerData("b: Benxi Lake", true),
            new AnswerData("c: Kivu Lake"),
            new AnswerData("d: Wakatipu Lake"),
            });

            AddQuestions("Q: What country has the largest population of alpacas?", new List<AnswerData>() {
            new AnswerData("a: Chad"),
            new AnswerData("b: Peru", true),
            new AnswerData("c: Australia"),
            new AnswerData("d: Niger"),
            });

        }

    }
}
