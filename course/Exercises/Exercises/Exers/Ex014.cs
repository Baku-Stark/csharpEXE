namespace Exercises.Exers;

public class Ex014: IEx
{
    public void ShowEx()
    {
        Console.WriteLine("Type the first number: ");
        int numA = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Type the second number: ");
        int numB = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        int comunDivisor = mdc(numA, numB);
        Console.WriteLine($"MDC({numA}, {numB}): {comunDivisor}");

        Console.WriteLine("Showing Comun Divisors");
        ShowComuunDivisor(numA, numB, comunDivisor);
    }

    private static int mdc(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        return mdc(b, a % b);
    }
    
    private static void ShowComuunDivisor(int a, int b, int mdc)
    {
        for (int i = 1; i <= mdc; i++)
        {
            if (a % i == 0 && b % i == 0)
            {
                Console.Write($"{i} ");
            }
        }
        Console.WriteLine();
    }
}