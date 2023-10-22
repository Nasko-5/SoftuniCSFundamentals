namespace MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> gameState = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();


            int[] guess = new int[2];
            string input;
            int moves = 0;
            bool win = false;

            while ((input = Console.ReadLine()) != "end")
            {
                guess = input.Split().Select(int.Parse).ToArray();

                if (gameState.Count == 0)
                {
                    win = true;
                    break;
                }

                if (IsNotValid(gameState.Count, guess[0], guess[1]))
                {   
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    gameState.Insert(gameState.Count / 2, $"-{moves}a");
                    gameState.Insert(gameState.Count / 2, $"-{moves}a");
                    continue;
                }

                if (gameState[guess[0]] == gameState[guess[1]])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {gameState[guess[0]]}!");
                    removeTwo(gameState, guess[0], guess[1]);
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
            }

            if (win)
            {
                Console.WriteLine($"You have won in {moves} turns!");
            }
            else
            {
                Console.WriteLine($"Sorry you lose :(\n{string.Join(' ', gameState)}");
            }

        }

        static void removeTwo(List<string> gameState, int indexOne, int indexTwo)
        {
            if (indexOne > indexTwo)
            {
                gameState.RemoveAt(indexOne);
                gameState.RemoveAt(indexTwo);
            }
            else
            {
                gameState.RemoveAt(indexTwo);
                gameState.RemoveAt(indexOne);
            }
        }

        static bool IsNotValid(int listLength, int indexOne, int indexTwo)
        {
            return (indexOne < 0 || indexTwo < 0) ||
                   (indexOne >= listLength || indexTwo >= listLength) ||
                   (indexOne == indexTwo);
        }
    }
}