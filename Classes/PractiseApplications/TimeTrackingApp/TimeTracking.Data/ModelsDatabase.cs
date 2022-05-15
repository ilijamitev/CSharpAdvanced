using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Models;

namespace TimeTracking.Data
{
    public class ModelsDatabase
    {
        public static List<User> UsersList { get; set; } = new List<User>();
        public ModelsDatabase()
        {
            DatabaseService databaseService = new();
        }


    }

    public class DatabaseService
    {
        private static string userDatabaseDir = @"../../../../userDatabaseDir/";
        private static string userDatabase = $@"{userDatabaseDir}/userDatabase.txt";
        public DatabaseService()
        {
            if (!Directory.Exists(userDatabaseDir))
            {
                Directory.CreateDirectory(userDatabaseDir);
            }
            if (!File.Exists(userDatabase))
            {
                File.Create(userDatabase);
            }
        }

        // DA NAPRAVAM DA NE GI POVTORUVA USERITE AKO VEKE GI IMA (po ID)
        // DA JA BRISE LISTATA PA PAK DA JA PISUVA ...
        public void SaveToDatabase()
        {
            File.WriteAllText(userDatabase, "");
            using StreamWriter sw = new(userDatabase, true);
            string userSerialized = JsonConvert.SerializeObject(ModelsDatabase.UsersList);
            sw.Write(userSerialized.ToString());
        }

        public void GetFromDatabase()
        {
            using StreamReader sr = new(userDatabase);
            string userSerialized = sr.ReadToEnd();
            ModelsDatabase.UsersList = JsonConvert.DeserializeObject<List<User>>(userSerialized);
        }
    }
}
