using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstOwnApi.Model
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public Training Training { get; set; }
        public float Average { get; set; }

        public Student()
        {
            Id = Guid.NewGuid();
            Name = GetARandomName();
            FirstName = GetARandomFirstName();
            Age = GetARandomAge();
            Training = GetARandomTraining();
            Average = GetARandomAverage();
        }
        public Student(Guid id, string name, string firstName, int age, Training training, float average)
        {
            Id = id;
            Name = name; 
            FirstName = firstName;
            Age = age;
            Training = training;
            Average = average;
        }
        public string GetARandomName()
        {
            Random random = new Random();
            List<string> list = new List<string>
            {
                "Smith",
                "Garcia",
                "Kim",
                "Martinez",
                "Singh",
                "Müller",
                "Chen",
                "Khan",
                "Anderson",
                "Nguyen",
                "Silva",
                "Hernandez",
                "Lee",
                "Gonzalez",
                "Wong",
                "Lopez",
                "Schmidt",
                "Gupta",
                "Johnson",
                "Wang",
                "Fernandez",
                "Brown",
                "Yamamoto",
                "Ramos",
                "Taylor",
                "Nakamura",
                "Rodriguez",
                "Ivanov",
                "Gomez",
                "Wu",
                "Kumar",
                "O'Connor",
                "Gao",
                "Thomas",
                "Sato",
                "Perez",
                "Wilson",
                "Chang",
                "Morgan",
                "Sánchez",
                "Evans",
                "Takahashi",
                "Walker",
                "Chan",
                "Jensen",
                "Ferrari",
                "García",
                "Jones",
                "Huang",
                "Morales",
                "Li",
                "Gutierrez",
                "Mueller",
                "Williams",
                "Park",
                "Chung",
                "Young",
                "Kawasaki",
                "Santos",
                "Le",
                "Rossi",
                "Brown",
                "Liu",
                "Murphy",
                "Ahmed",
                "Ito",
                "Thompson",
                "Fischer",
                "Ramirez",
                "Olsen",
                "Yilmaz",
                "Torres",
                "Carvalho",
                "Bianchi",
                "Ribeiro",
                "Gonzales",
                "Lam",
                "Ortega",
                "Ruiz",
                "Ferreira",
                "Kovacs",
                "Vasquez",
                "Novak",
                "Kaur",
                "Alves",
                "Yildirim",
                "Nascimento",
                "Liu",
                "Ryan",
                "Hansen",
                "Petrov",
                "Fernandes",
                "Moreno",
                "Molina",
                "Bach",
                "Matsuda",
                "Suzuki",
                "Petrovic",
                "Zhang",
                "Kang"
            };

            int randomIndex = random.Next(list.Count);
            return list[randomIndex];

        }
        public string GetARandomFirstName()
        {
            Random random = new Random();
            List<string> list = new List<string>
            {
                "Sofia",
                "Liam",
                "Aisha",
                "Gabriel",
                "Mei",
                "Alejandro",
                "Fatima",
                "Luca",
                "Leila",
                "Ivan",
                "Ananya",
                "Diego",
                "Nia",
                "Matteo",
                "Jasmine",
                "Aditya",
                "Zara",
                "Omar",
                "Isabella",
                "Amir",
                "Maya",
                "Nikhil",
                "Ingrid",
                "Lucas",
                "Priya",
                "Rafael",
                "Layla",
                "Hiroshi",
                "Emilia",
                "Carlos",
                "Yara",
                "Mattea",
                "Ahmed",
                "Mia",
                "Giuseppe",
                "Arya",
                "Ahmed",
                "Ana",
                "Leo",
                "Yuki",
                "Olivia",
                "Ravi",
                "Chihiro",
                "Tariq",
                "Kira",
                "Lorenzo",
                "Sana",
                "Erika",
                "Youssef",
                "Layla",
                "Julian",
                "Sakura",
                "Ibrahim",
                "Leilani",
                "Maria",
                "Rohan",
                "Svetlana",
                "Mateo",
                "Natasha",
                "Elias",
                "Amara",
                "Dario",
                "Shiori",
                "Alejandro",
                "Neha",
                "Nikolas",
                "Zoe",
                "Yusuf",
                "Maya",
                "Leonardo",
                "Aisha",
                "Tenzin",
                "Priya",
                "Ismail",
                "Yara",
                "Chiara",
                "Juan",
                "Amaya",
                "Pavel",
                "Aria",
                "Selim",
                "Estelle",
                "Daniel",
                "Riya",
                "Marco",
                "Mei",
                "Ahmed",
                "Layla",
                "Luca",
                "Kana",
                "Liam",
                "Ayaka",
                "Sebastian",
                "Noor",
                "Hiroki",
                "Fatima",
                "Amir",
                "Nina",
                "Antonio",
                "Sana"
            };

            int randomIndex = random.Next(list.Count);
            return list[randomIndex];
        }
        public int GetARandomAge()
        {
            Random random = new Random();
            return random.Next(18,46);
        }
        public Training GetARandomTraining()
        {
            Random random = new Random();
            int randomValueForSwitch = random.Next(1,5);

            switch(randomValueForSwitch)
            {
                case 0:
                    return Training.CDA_Csharp;
                    break;
                case 1:
                    return Training.CDA_Java;
                    break;
                case 2:
                    return Training.Web;
                    break;
                case 3:
                    return Training.CyberSecurity;
                    break;
            }
            return default;
        }
        public float GetARandomAverage()
        {
            Random random = new Random();
            return (float)random.NextDouble() * 20;
        }
        public static List<Student> GetStudent()
        {
            List<Student> list = new List<Student>();
            // Normally, this would be a call to a database or a service
            for (int i = 0; i < 200; i++)
            {
                list.Add(new Student());
            }
            return list;
        }

        public static Student GetStudentById(Guid id)
        {
            // Normally, this would be a call to a database or a service
            return new Student(Guid.NewGuid(), "Kuster", "Louis", 31, Training.CDA_Java, 15.5f);
        }

        public static Student CreateStudent(string name, string firstName, int age, Training training, float average)
        {
            // Normally, this would be a call to a database or a service
            return new Student(Guid.NewGuid(), name, firstName, age, training, average);
        }

        public static Guid DeleteStudent(Guid id)
        {
            // Normally, this would be a call to a database or a service
            return id;
        }
    }
}
