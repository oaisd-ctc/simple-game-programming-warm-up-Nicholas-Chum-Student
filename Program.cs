public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Dice Game");
        Console.WriteLine("In this game you and a computer Rival will play 10 rounds where you will each roll a 6-sided dice, and the player with the highest dice value will win the round. The player who wins the most rounds win the game. Good luck!");
        Console.WriteLine("Press any key to start...");
        Console.ReadLine();

        int YourScore = 0;
        int EnemyScore = 0;
        int Round = 1;
        do
        {
            Random random = new Random();
            int EnemyRoll = random.Next(1, 7);
            int YourRoll = random.Next(1, 7);

            Console.WriteLine($"Round {Round}");
            Console.WriteLine($"Rival rolled a {EnemyRoll}");
            Console.WriteLine("Press any key to roll the dice...");
            Console.ReadLine();
            Console.WriteLine($"You rolled a {YourRoll}");
            if (EnemyRoll < YourRoll)
            {
                YourScore++;
                Console.WriteLine("You won this round.");
            }
            else if (EnemyRoll == YourRoll)
            {
                Console.WriteLine("The round is a draw!");
            }
            else
            {
                EnemyScore++;
                Console.WriteLine("The Rival won this round.");
            }

            Console.WriteLine($"The score is now - You : {YourScore}. Rival : {EnemyScore}.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Round++;
        }
        while (Round < 11);
        
        Console.Clear();
        Console.WriteLine("Dice Game was closed.");
    }
    public static void RandomRoll()
    {
        Random random = new Random();
        int Roll = random.Next(1, 7);
    }
}