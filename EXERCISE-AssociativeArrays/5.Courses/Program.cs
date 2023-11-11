namespace _5.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string[] splitInput;

            Dictionary<string, Course> courses = new Dictionary<string, Course>();

            string courseName, studentName;

            while ((input = Console.ReadLine()) != "end")
            {
                splitInput = input.Split(" : ");
                courseName = splitInput[0];
                studentName = splitInput[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new Course(courseName));
                }

                courses[courseName].AddStudent(studentName);
            }

            foreach (var course in courses)
            {
                Console.WriteLine(course.Value);
            }
        }

        class Course
        {
            List<string> Students = new List<string> {};
            public string Name { get; set; }

            public Course(string name)
            {
                Name = name;
            }

            public void AddStudent(string student)
            {
                if (!Students.Contains(student))
                {
                    Students.Add(student);
                }
            }

            public override string ToString()
            {
                return $"{Name}: {Students.Count}\n" +
                       $"{string.Join('\n', Students.Select(student => "-- " + student))}";
            }

        }
    }
}