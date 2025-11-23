namespace BasicContent.Challengers;

public class Jokenpo: IChallenger
{
    public void ShowChallenger()
    {
        Random random = new Random();
        String computer;
        bool playAgain = true;

        while (playAgain)
        {
            String computerChoice = this.SystemChoice(random.Next(1, 3));

            Console.WriteLine("Choice between [1] 'ROCK', [2] 'PAPER' and [3] 'SCISSOR'");
            String playerChoice = this.SystemChoice(Convert.ToInt32(Console.ReadLine()));

            if (computerChoice == playerChoice)
            {
                Console.WriteLine("Computer Vs. Player: DRAW!");
            }
            
            else if (computerChoice == "PAPER" && playerChoice == "ROCK" || computerChoice == "ROCK" && playerChoice == "SCISSOR" ||  computerChoice == "SCISSOR" && playerChoice == "PAPER")
            {
                Console.WriteLine("COMPUTER WIN!");
                playAgain = false;
            }
            else
            {
                Console.WriteLine("PLAYER WIN!");
                playAgain = false;
            }
            
            Console.WriteLine($"Computer '{computerChoice}' | Player '{playerChoice}'");
        }
    }

    private String SystemChoice(int numberChoice)
    {
        String choice = String.Empty;
        
        switch (numberChoice)
        {
            case 1:
                choice = "ROCK";
                break;
            
            case 2:
                choice = "PAPER";
                break;
            
            case 3:
                choice = "SCISSOR";
                break;
            
            default:
                throw  new Exception("Type ''");
        }

        return choice;
    }
}