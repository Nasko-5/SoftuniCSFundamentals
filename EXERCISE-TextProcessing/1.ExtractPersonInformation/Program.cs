namespace _1.ExtractPersonInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string input;

            (int startIndex, int endIndex) nameIndecies;
            (int startIndex, int endIndex) ageIndecies;

            string name, age;

            for (int i = 0; i < people; i++)
            {
                input = Console.ReadLine();

                nameIndecies = (input.IndexOf('@'), input.LastIndexOf('|'));
                ageIndecies = (input.IndexOf('#'), input.LastIndexOf('*'));

                name = input.Substring(nameIndecies.startIndex+1, (nameIndecies.endIndex - nameIndecies.startIndex)-1);
                age = input.Substring(ageIndecies.startIndex+1, (ageIndecies.endIndex - ageIndecies.startIndex)-1);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}