namespace _2.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            string definition = GradeToText(grade);

            Console.WriteLine(definition);
        }

        private static string GradeToText(double grade)
        {
            switch (grade)
            {
                case <= 2.99:
                    return "Fail";
                    break;
                case >= 3.00 and <= 3.49:
                    return "Poor";
                    break;
                case >= 3.50 and <= 4.49:
                    return "Good";
                    break;
                case >= 4.50 and <= 5.49:
                    return "Very good";
                    break;
                case >= 5.50:
                    return "Excellent";
                    break;
                default:
                    return "Whoops!";
            }
        }
    }
}