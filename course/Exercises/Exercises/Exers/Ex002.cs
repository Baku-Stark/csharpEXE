namespace Exercises.Exers;

public class Ex002: IEx
{
    public void ShowEx()
    {
        Console.WriteLine("Type first number:");
        int fnumber = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"Type second number:");
        int snumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Result: {fnumber + snumber}");
    }
}