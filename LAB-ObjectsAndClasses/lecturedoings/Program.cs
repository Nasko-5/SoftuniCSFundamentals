using System.Runtime.CompilerServices;

namespace lecturedoings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Student Nasko = new Student("Atanas", "Kozharov", 2008);
            Nasko.grades.Add(2);
            Nasko.grades.Add(5);
            Nasko.grades.Add(6);
            Nasko.grades.Add(3);
            Nasko.grades.Add(5);
            Nasko.grades.Add(3);
            Nasko.grades.Add(3);
            Nasko.grades.Add(6);
            Nasko.grades.Add(3);
            Nasko.grades.Add(5);

            Console.WriteLine($"{Nasko.FirstName} {(Nasko.OverEighteen ? "is" : "is not")} over eighteen! They are {Nasko.Age}");
            Console.WriteLine($"Their average grade is {Nasko.getAverageGrade()}");

        }
    }

    class Student : Person
    {
        public Student(string firstName, string lastName, int birthYear) : base(firstName, lastName, birthYear)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
        }

        public List<int> grades = new List<int>();

        public double getAverageGrade()
        {

            return grades.Average();
        }

    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }

        public bool OverEighteen { get; private set; }

        public int Age { get; private set; }

        public Person(string firstName, string lastName, int birthYear)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;

            Age = DateTime.Today.Year - BirthYear;
            OverEighteen = Age >= 18;
        }
    }
}