namespace Exercises.Exers;

public class Ex004: IEx
{
    public void ShowEx()
    {
        Console.WriteLine("Type a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < 11; i++)
        {
            Console.WriteLine($"{i} * {number} = {number * i}");
        }
    }
}