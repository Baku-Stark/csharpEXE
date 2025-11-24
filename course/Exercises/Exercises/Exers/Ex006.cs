using System.Numerics;

namespace Exercises.Exers;

public class Ex006: IEx
{
    public void ShowEx()
    {
        Console.WriteLine("Type a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        BigInteger result = 1;

        for (int i = number; i >= 1; i--)
        {
            result = i * result;
        }
        
        Console.WriteLine($"{number}! = {result}");
    }
}