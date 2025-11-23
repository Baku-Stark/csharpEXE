namespace BasicContent.Challengers;

public class NumberGuessing: IChallenger
{
    public void ShowChallenger()
    {
        Random random = new Random();
        int minNumber = 0;
        int maxNumber = 10;
        int guess = random.Next(minNumber, maxNumber);
        bool playAgain = true;

        while (playAgain)
        {
            

            Console.WriteLine($"Choice a number {minNumber} - {maxNumber}");
            int numberchoice =  Convert.ToInt32(Console.ReadLine());

            if (numberchoice != guess)
            {
                Console.WriteLine("You won't be able to play again!");
                playAgain = false;
            }
            else
            {
                Console.WriteLine("CONGRATULATIONS!!! `*`");
            }
        }

        Console.WriteLine("DONE!");
    }
}