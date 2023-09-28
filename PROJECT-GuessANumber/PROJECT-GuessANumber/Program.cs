
using System.Runtime.CompilerServices;

Random randomNumber = new Random();
int toGuess = randomNumber.Next(1, 101);

while (true)
{
    Console.Write("Guess a number (1-100): ");

    string playerGuess = Console.ReadLine();
    bool isValid = int.TryParse(playerGuess, out int playerNumber);

    if (isValid)
    {
        if (playerNumber == toGuess)
        {
            Console.WriteLine("You guessed correctly :D");
            break;
        }
        else if (playerNumber > toGuess)
        {
            Console.WriteLine($"Too high :(");
        }
        else
        {
            Console.WriteLine("Too low :(");
        }
    } else
    {
        Console.WriteLine("Invalid input!! >:*");
    }

}