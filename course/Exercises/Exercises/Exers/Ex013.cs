namespace Exercises.Exers;

public class Ex013: IEx
{
    public void ShowEx()
    {
        Console.WriteLine("Write a sentence: ");
        string  sentence = Convert.ToString(Console.ReadLine()!).Trim();

        Console.WriteLine($"Word count: {sentence.Length}");
    }
}