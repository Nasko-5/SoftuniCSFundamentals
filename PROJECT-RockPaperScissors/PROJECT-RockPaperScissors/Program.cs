using System.Reflection.Metadata;

Random random = new Random();
char[] hands = new char[3] { 'r', 'p', 's' };
char randomHand = hands[random.Next(0, 3)];

Console.WriteLine("[r]ock [p]aper [s]cossors...");
bool valid = false;

while (true)
{
    Console.Write("> ");
    valid = char.TryParse(Console.ReadLine().ToLower(), out char userHand);

    if (valid)
    {
        Console.WriteLine("\nShoot!\n");

        Console.WriteLine($"I choose {randomHand}!");

        if ((userHand == 'r' && randomHand == 'r') ||
            (userHand == 'p' && randomHand == 'p') ||
            (userHand == 's' && randomHand == 's'))
        {
            Console.WriteLine("Draw :/");
        }
        else if
            ((userHand == 'r' && randomHand == 's') ||
            (userHand == 'p' && randomHand == 'r') ||
            (userHand == 's' && randomHand == 'p'))
        {
            Console.WriteLine("You win -,-");
        }
        else
        {
            Console.WriteLine("You lose ;p");
        }

        break;
    }

}