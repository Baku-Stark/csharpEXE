namespace BasicContent;

public class C007ForLooping
{
    public void ShowC007ForLooping()
    {
        Console.WriteLine("MATH TABLE");
        for (int i = 0; i < 11; i++)
        {
            Console.WriteLine($"{i} x {2} = {i * 2}");
        }

        Console.WriteLine();

        Console.WriteLine("READING TABLE");
        String[] arrayNumbers = ["11", "12"];
        for (int i = 0; i < arrayNumbers.Length; i++)
        {
            Console.WriteLine(arrayNumbers[i]);
        }
    }
}