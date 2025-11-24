namespace Exercises.Exers;

public class Ex001: IEx
{
    public void ShowEx()
    {
        Console.WriteLine($"Hello, {Convert.ToString(Console.ReadLine())}");
    }
}