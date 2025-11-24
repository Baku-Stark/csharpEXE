namespace Exercises.Exers;

public class Ex005: IEx
{
    public void ShowEx()
    {
        Console.WriteLine("Type a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = number; i >= 0; i--)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("EXPLOSION!");
    }
}