using System.ComponentModel;

namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> rooms = Console.ReadLine()
                .Split('|')
                .ToList();

            (int health, int bitcoins, string monster, int atRoom) gameState = (100, 0, "", 0);

            int maxHealth = 100;

            bool dead = false;

            foreach (string room in rooms)
            {
                if (dead)
                {
                    break;
                }

                string[] arguments = room.Split(" ");
                string roomType = arguments[0];
                int roomValue = int.Parse(arguments[1]);

                gameState.atRoom += 1;

                switch (roomType)
                {
                    case "potion":
                        if (roomValue + gameState.health <= maxHealth)
                        {
                            gameState.health += roomValue;

                            Console.WriteLine($"You healed for {roomValue} hp.\n" +
                                              $"Current health: {gameState.health} hp.");
                        }
                        else
                        {
                            int adjusted = maxHealth - gameState.health;
                            gameState.health += adjusted;

                            Console.WriteLine($"You healed for {adjusted} hp.\n" +
                                              $"Current health: {gameState.health} hp.");
                        }

                        break;
                    case "chest":
                        gameState.bitcoins += roomValue;
                        Console.WriteLine($"You found {roomValue} bitcoins.");
                        break;
                    default:
                        gameState.monster = roomType;
                        gameState.health -= roomValue;

                        if (isDead(gameState.health))
                        {
                            dead = true;
                        }
                        else
                        {
                            Console.WriteLine($"You slayed {roomType}.");
                        }

                        break;
                }
            }

            if (dead)
            {
                Console.WriteLine($"You died! Killed by {gameState.monster}.\n" +
                                  $"Best room: {gameState.atRoom}");
            }
            else
            {
                Console.WriteLine( "You've made it!\n" + 
                                  $"Bitcoins: {gameState.bitcoins}\n" +
                                  $"Health: {gameState.health}");
            }
        }

        static bool isDead(int health)
        {
            return health <= 0;
        }
    }
}