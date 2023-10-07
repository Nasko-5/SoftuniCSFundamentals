// input and parse

string[] strings = Console.ReadLine()
                          .Split(' ')
                          .Reverse()
                          .ToArray();

string reversedStrings = string.Join(' ', strings);

Console.WriteLine(reversedStrings);