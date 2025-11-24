namespace Exercises.Exers;

public class Ex009: IEx
{
    public void ShowEx()
    {
        int[] arrayNumbers = new int[10];
        
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Type a positive integer number ({i + 1}): ");
            int number = Convert.ToInt32(Console.ReadLine());
            arrayNumbers[i] = number;
        }
        
        Array.Sort(arrayNumbers);
        foreach (var number in arrayNumbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine($"The largest number is: {arrayNumbers.GetValue(arrayNumbers.Length - 1)}");
    }
}