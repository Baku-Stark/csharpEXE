namespace BasicContent;

public class C002UserInput
{
    public void ShowC002UserInput()
    {
        Console.WriteLine("What is your name?");
        String name = Convert.ToString(Console.ReadLine()!);
        Console.WriteLine("What is your age?");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Hello,  {name}! You are {age} years old.");
    }
}