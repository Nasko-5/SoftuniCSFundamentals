namespace _4.Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Grade}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int _ = 0; _ < numberOfStudents; _++)
            {
                string[] splitInput = Console.ReadLine().Split(' ');

                students.Add(new Student(splitInput[0], splitInput[1], double.Parse(splitInput[2])));
            }

            students = students.OrderBy(student => student.Grade).ToList();
            students.Reverse();

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}