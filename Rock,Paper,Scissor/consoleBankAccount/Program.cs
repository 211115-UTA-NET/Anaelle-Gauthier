namespace RockPaperScissorApp.App
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to RockPaperScissors App");

            var game = new Game();
            String Player = "";
            String computer = "";

            Random random = new Random();
            

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Play a round? (y/n) ");

                string? input = Console.ReadLine();

                if (input != "y") { break; }

                game.PlayRound();
            }

         


            while( Player != "ROCK" && Player != "PAPER" && Player != "SCISSORS")
            {
                Console.WriteLine("Please enter ROCK, PAPER, SCISSORS");
                Player = Console.ReadLine();
                Player = Player.ToUpper();
            }
            int randomNumber = random.Next(1,4);
            switch (randomNumber)

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

            switch(Player)

            {
                case "ROCK":

                    if (computer == "ROCK")
                    {
                        Console.WriteLine("THIS IS A TIE!");
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("YOU HAVE LOST!");
                    }
                    else
                    {
                        Console.WriteLine("YOU WON!");
                    }
                   break;

                case "PAPER":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("YOU WON !");
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("IT'S A TIE! ");
                    }
                    else
                    {
                        Console.WriteLine("YOU HAVE LOST");
                    }
                    break;

                case "SCISSOR":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("YOU HAVE LOST !");
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("YOU WON! ");
                    }
                    else
                    {
                        Console.WriteLine("IT'S A TIE!");
                    }
                    break;
            }

            Console.WriteLine("Player: " + Player);
            string summary = game.Summary;
            Console.WriteLine(summary);
        }
    }
}
