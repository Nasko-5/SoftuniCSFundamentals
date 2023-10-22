

namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double students = double.Parse(Console.ReadLine());

            double lectures = double.Parse(Console.ReadLine());

            double additionalBonus = double.Parse(Console.ReadLine());


            List<(double attendance, double bonus)> studentList = new List<(double attendance, double bonusPoints)>();

            for (int i = 0; i < students; i++)
            {
                int studentAttendance = int.Parse(Console.ReadLine());

                double totalBonus = (double)studentAttendance / lectures * (5 + additionalBonus);


                studentList.Add((studentAttendance, totalBonus));
            }

            studentList.Sort((studentOne, studentTwo) => studentTwo.bonus.CompareTo(studentOne.bonus));
            var bestStudent = studentList[0];

            Console.WriteLine($"Max Bonus: {Math.Ceiling(bestStudent.bonus)}.\n" +
                              $"The student has attended {bestStudent.attendance} lectures."
                              );

        }
    }
}