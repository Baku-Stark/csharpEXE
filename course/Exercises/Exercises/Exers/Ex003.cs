namespace Exercises.Exers;

public class Ex003: IEx
{
    public void ShowEx()
    {
        Console.WriteLine("Type a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Your number is: {(number % 2 == 0 ? "Even" : "Odd")}");
    }
}