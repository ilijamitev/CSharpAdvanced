using QuizModels.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizModels.BaseModel
{
    public class User
    {
        public string FullName { get; set; }
        public int Password { get; set; }

        public Role Role { get; set; }

    }
}
