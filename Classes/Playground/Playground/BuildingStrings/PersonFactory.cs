﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingStrings
{
    internal class PersonFactory
    {
        private List<string> _names = new List<string>
        {
            "James",
"Robert",
"John",
"Michael",
"David",
"William",
"Richard",
"Joseph",
"Thomas",
"Charles",
"Christopher",
"Daniel",
"Matthew",
"Anthony",
"Mark",
"Donald",
"Steven",
"Paul",
"Andrew",
"Joshua",
"Kenneth",
"Kevin",
"Brian",
"George",
"Timothy",
"Ronald",
"Edward",
"Jason",
"Jeffrey",
"Ryan",
"Jacob",
"Gary",
"Nicholas",
"Eric",
"Jonathan",
"Stephen",
"Larry",
"Justin",
"Scott",
"Brandon",
"Benjamin",
"Samuel",
"Gregory",
"Alexander",
"Frank",
"Patrick",
"Raymond",
"Jack",
"Dennis",
"Jerry",
"Tyler",
"Aaron",
"Jose",
"Adam",
"Nathan",
"Henry",
"Douglas",
"Zachary",
"Peter",
"Kyle",
"Ethan",
"Walter",
"Noah",
"Jeremy",
"Christian",
"Keith",
"Roger",
"Terry",
"Gerald",
"Harold",
"Sean",
"Austin",
"Carl",
"Arthur",
"Lawrence",
"Dylan",
"Jesse",
"Jordan",
"Bryan",
"Billy",
"Joe",
"Bruce",
"Gabriel",
"Logan",
"Albert",
"Willie",
"Alan",
"Juan",
"Wayne",
"Elijah",
"Randy",
"Roy",
"Vincent",
"Ralph",
"Eugene",
"Russell",
"Bobby",
"Mason",
"Philip",
"Louis",
"Mary",
"Patricia",
"Jennifer",
"Linda",
"Elizabeth",
"Barbara",
"Susan",
"Jessica",
"Sarah",
"Karen",
"Lisa",
"Nancy",
"Betty",
"Margaret",
"Sandra",
"Ashley",
"Kimberly",
"Emily",
"Donna",
"Michelle",
"Carol",
"Amanda",
"Dorothy",
"Melissa",
"Deborah",
"Stephanie",
"Rebecca",
"Sharon",
"Laura",
"Cynthia",
"Kathleen",
"Amy",
"Angela",
"Shirley",
"Anna",
"Brenda",
"Pamela",
"Emma",
"Nicole",
"Helen",
"Samantha",
"Katherine",
"Christine",
"Debra",
"Rachel",
"Carolyn",
"Janet",
"Catherine",
"Maria",
"Heather",
"Diane",
"Ruth",
"Julie",
"Olivia",
"Joyce",
"Virginia",
"Victoria",
"Kelly",
"Lauren",
"Christina",
"Joan",
"Evelyn",
"Judith",
"Megan",
"Andrea",
"Cheryl",
"Hannah",
"Jacqueline",
"Martha",
"Gloria",
"Teresa",
"Ann",
"Sara",
"Madison",
"Frances",
"Kathryn",
"Janice",
"Jean",
"Abigail",
"Alice",
"Julia",
"Judy",
"Sophia",
"Grace",
"Denise",
"Amber",
"Doris",
"Marilyn",
"Danielle",
"Beverly",
"Isabella",
"Theresa",
"Diana",
"Natalie",
"Brittany",
"Charlotte",
"Marie",
"Kayla",
"Alexis",
"Lori"
        };

        private List<string> _lastNames = new List<string>
        {
            "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez", "Hernandez", "Lopez", "Gonzales", "Wilson", "Anderson", "Thomas", "Taylor", "Moore", "Jackson", "Martin", "Lee", "Perez", "Thompson", "White", "Harris", "Sanchez", "Clark", "Ramirez", "Lewis", "Robinson", "Walker", "Young", "Allen", "King", "Wright", "Scott", "Torres", "Nguyen", "Hill", "Flores", "Green", "Adams", "Nelson", "Baker", "Hall", "Rivera", "Campbell", "Mitchell", "Carter", "Roberts", "Gomez", "Phillips", "Evans", "Turner", "Diaz", "Cruz", "Edwards", "Collins", "Reyes", "Stewart", "Morris", "Morales", "Murphy", "Cook", "Rogers", "Gutierrez", "Ortiz", "Cooper", "Peterson", "Bailey", "Reed", "Kelly", "Howard", "Ramos", "Cox", "Ward", "Richardson", "Watson", "Chavez", "Wood", "Bennet", "Mendoza", "Ruiz", "Hughes", "Price", "Alvarez", "Castillo", "Sanders", "Patel", "Myers", "Long", "Ross", "Jimenez"
        };

        private List<string> _cities = new List<string>
        {
            "Shanghai",
"Buenos Aires",
"Mumbai",
"Mexico City",
"Karachi",
"İstanbul",
"Delhi",
"Manila",
"Moscow",
"Dhaka",
"Seoul",
"São Paulo",
"Lagos",
"Jakarta",
"Tokyo",
"Zhumadian",
"New York",
"Taipei",
"Kinshasa",
"Lima",
"Cairo",
"London",
"Beijing",
"Tehrān",
"Nanchong",
"Bogotá",
"Hong Kong",
"Lahore",
"Rio de Janeiro",
"Baghdad",
"Tai’an",
"Bangkok",
"Bangalore",
"Yueyang",
"Santiago",
"Kaifeng",
"Kolkata",
"Toronto",
"Yangon",
"Sydney",
"Chennai",
"Riyadh",
"Wuhan",
"Saint Petersburg",
"Chongqing",
"Chengdu",
"Chittagong",
"Alexandria",
"Los Angeles",
"Tianjin",
"Melbourne",
"Ahmadābād",
"Pusan",
"Abidjan",
"Kano",
"Hyderābād",
"Puyang",
"Yokohama-shi",
"Ibadan",
"Singapore",
"Ankara",
"Shenyang",
"Hồ Chí Minh City",
"Shiyan",
"Cape Town",
"Berlin",
"Montréal",
"Madrid",
"Harbin",
"Xi’an",
"Pyongyang",
"Lanzhou",
"Guangzhou",
"Casablanca",
"Durban",
"Nanjing",
"Kabul",
"Shenzhen",
"Caracas",
"Pune",
"Sūrat",
"Jeddah",
"Kānpur",
"Luanda",
"Addis Ababa",
"Nairobi",
"Taiyuan",
"Salvador",
"Jaipur",
"Dar es Salaam",
"Chicago",
"Incheon",
"Yunfu",
"Al Başrah",
"Ōsaka-shi",
"Mogadishu",
"Taegu",
"Rome",
"Changchun",
"Kiev "
        };
        public IEnumerable<Person> GetPersons()
        {
            return
                from name in _names
                from lastName in _lastNames
                from city in _cities.Take(2)
                select new Person(name, lastName, city);
        }

    }
}
