using System;
namespace Excer2
{
    public class Student {
        public string Id;
        public string Name;
        public int Age;
        public int Grade;

        public Student(string id, string name, int age, int grade) {
            Id = id;
            Name = name;
            Age = age;
            Grade = grade;
        }

    }

    public class CSV {
        public static void ReadFromFile(string fileName) {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in lines) {
                string[] values = line.Split(',');
                if (values.Length == 4) {
                    Student student = new Student(values[0], values[1], Convert.ToInt32(values[2]), Convert.ToInt32(values[3]));
                    Console.WriteLine($"{student.Id}, {student.Name}, {student.Age}, {student.Grade}");
                }
            }
        }

        public static void WriteToFile(string fileName, List<Student> students) {
            System.IO.File.WriteAllLines(fileName, students.Select(s => $"{s.Id},{s.Name},{s.Age},{s.Grade}"));
            Console.WriteLine("write to file successfully");
        }
    }




    public class MainClass {
        public static void Main(string[] args) {
            CSV.ReadFromFile("CSV.txt");
            CSV.WriteToFile("CSV.txt", );
            Console.ReadLine(); // Keep the console window open until the user presses a key.
        }   
    }
}
