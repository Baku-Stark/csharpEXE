namespace Exercises.Exers;

public class Ex010: IEx
{
    public void ShowEx()
    {
        Console.Write("How many terms of the Fibonacci sequence do you want to see? ");
        int number = int.Parse(Console.ReadLine()!);
        
        if (number <= 0)
        {
            Console.WriteLine("Please enter a number greater than zero.");
            return;
        }
        
        if (number == 1)
        {
            Console.WriteLine("0");
            return;
        }
        if (number == 2)
        {
            Console.WriteLine("0, 1");
            return;
        }
        
        long lastNumber = 0;
        long currentNumber = 1;

        Console.Write("0, 1");

        for (int i = 3; i <= number; i++)
        {
            long nextNumber = lastNumber + currentNumber;
            Console.Write($", {nextNumber}");
            
            lastNumber = currentNumber;
            currentNumber = nextNumber;
        }

        Console.WriteLine();
    }
}