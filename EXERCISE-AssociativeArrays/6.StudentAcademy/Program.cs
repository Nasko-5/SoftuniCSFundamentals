namespace _6.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            string name;
            double grade;

            Dictionary<string, Student> studentList = new Dictionary<string, Student>();

            for (int _ = 0; _ < studentCount; ++_)
            {
                name = Console.ReadLine();
                grade = double.Parse(Console.ReadLine());

                if (!studentList.ContainsKey(name))
                {
                    studentList.Add(name, new Student(name));
                }

                studentList[name].AddGrade(grade);
            }

            foreach (var student in studentList.Where(student => student.Value.averageGrade >= 4.50))
            {
                Console.WriteLine(student.Value);
            }
        }

        class Student
        {
            public string Name { get; set; }
            private List<double> grades = new List<double>();

            public double averageGrade => grades.Average();

            public Student(string name)
            {
                Name = name;
            }

            public void AddGrade(double grade)
            {
                grades.Add(grade);
            }

            public override string ToString()
            {
                return $"{Name} -> {averageGrade:F2}";
            }
        }
    }
}