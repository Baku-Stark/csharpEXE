namespace Exercises.Exers;

public class Ex007: IEx
{
    public void ShowEx()
    {
        Console.WriteLine("Word:");
        String word = Convert.ToString(Console.ReadLine()!);
        String reversedWord = "";
        
        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversedWord += word.ElementAt(i);
        }
        
        Console.WriteLine($"Word: {word} | Reverse word: {reversedWord}");
    }
}