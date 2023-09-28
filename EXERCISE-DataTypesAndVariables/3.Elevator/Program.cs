/* silly template */

// initialize inputs defined by problem
int numberOfPeople = int .Parse(Console.ReadLine());
int capacity = int .Parse(Console.ReadLine());

// parse inputs from console


// preform needed operation and print out result
int courses = (int)Math.Ceiling((double)numberOfPeople / capacity);

Console.WriteLine(courses);

Environment.Exit(0);