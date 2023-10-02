using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random();
            bool playAgain = true;
            string player;
            string computer;
            string answer;
            int playerWins = 0;
            int playerLosses = 0;
            int gameDraws = 0;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {   
                    Console.Write("Enter ROCK, PAPER or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                    Console.Write(player);
                    if (player == "SPOCK") Console.WriteLine(": That is not logcal!"); //Easter Egg :)
                }

                switch (rand.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }
                Console.WriteLine($"Player: {player}");
                Console.WriteLine($"Computer: {computer}");

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw");
                            gameDraws++;
                        } 
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose");
                            playerLosses++;
                        }
                        else
                        {
                            Console.WriteLine("Winner, Winner, Chicken Dinner");
                            playerWins++;
                        }
                        break;
                    case "PAPER":
                        if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw");
                            gameDraws++;
                        }
                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("You lose");
                            playerLosses++;
                        }
                        else
                        {
                            Console.WriteLine("Winner, Winner, Chicken Dinner");
                            playerWins++;
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "SCISSORS")
                        {
                            Console.WriteLine("It's a draw");
                            gameDraws++;
                        }
                        else if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose");
                            playerLosses++;
                        }
                        else
                        {
                            Console.WriteLine("Winner, Winner, Chicken Dinner");
                            playerWins++;
                        }
                        break;
                }

                while (answer != "Y" && answer != "N")
                {
                    Console.Write("Wound you like to play again? (Y/N)");
                    answer = Console.ReadLine();
                    answer = answer.ToUpper();
                    if (answer == "Y")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                    }
                }
                
            }
            Console.WriteLine($"Thanks for playing!\n\nWins: {playerWins}\nLosses: {playerLosses}\nDraws: {gameDraws}");
            Console.ReadKey();
        }
     
    }
}