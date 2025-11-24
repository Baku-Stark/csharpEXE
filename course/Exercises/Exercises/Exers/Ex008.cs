namespace Exercises.Exers;

public class Ex008: IEx
{
    public void ShowEx()
    {
        Console.WriteLine("Type a positive integer number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number == 1)
        {
            Console.WriteLine("The number is 1");
        }
        
        else if (number <= 0)
        {
            Console.WriteLine("Type a  positive integer number");
        }

        else
        {
            bool cousinNumber = true;
            
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    cousinNumber = false;
                    break;
                }
            }

            if (cousinNumber)
                Console.WriteLine($"{number} is COUSIN NUMBER!");
            else
                Console.WriteLine($"{number} isn't COUSIN NUMBER.");
        }
    }
}