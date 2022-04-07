using QuizModels.BaseModel;
using QuizModels.UsersDatabase;

namespace QuizService
{
    public class ValidationService
    {
        public static bool ValidateUserChoice(string inputChoice, string[] validOptions)
        {
            if (validOptions.Contains(inputChoice)) return true;
            return false;
        }

        public static bool CheckFullNameInDatabase(string fullName, string selectedOption)
        {
            if (selectedOption == "1") return UsersDatabase.TeacherList.Any(x => x.FullName == fullName);
            if (selectedOption == "2") return UsersDatabase.StudentList.Any(x => x.FullName == fullName);
            return false;
        }

        public static bool CheckPasswordInDatabase(int password, string selectedOption)
        {
            if (selectedOption == "1") return UsersDatabase.TeacherList.Any(x => x.Password == password);
            if (selectedOption == "2") return UsersDatabase.StudentList.Any(x => x.Password == password);
            return false;
        }

        public static User GetUser(string inputChoice, string fullName, int password)
        {
            if (inputChoice == "1") return UsersDatabase.TeacherList.FirstOrDefault(x => x.FullName == fullName && x.Password == password);
            else if (inputChoice == "2") return UsersDatabase.StudentList.FirstOrDefault(x => x.FullName == fullName && x.Password == password);
            return null;
        }

    }
}
