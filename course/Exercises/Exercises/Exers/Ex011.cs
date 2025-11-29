namespace Exercises.Exers;

public class Ex011: IEx
{
    public void ShowEx()
    {
        Console.WriteLine("Write a sentence: ");
        String  sentence = Convert.ToString(Console.ReadLine()!).Trim().ToLower();

        String reversedSentence = "";
        
        for (int i = sentence.Length - 1; i >= 0; i--)
        {
            reversedSentence += sentence.ElementAt(i);
        }
        
        Console.WriteLine($"Your sentence: {sentence} | Reverse sentence: {reversedSentence}");

        if (sentence.Equals(reversedSentence))
        {
            Console.WriteLine("This sentence is a palindrome");
        }

        else
        {
            Console.WriteLine("This sentence isn't a palindrome");
        }
    }
}