namespace BasicContent;

public class C005IfElseTestament
{
    public void ShowC005IfElseTestament()
    {
        int age = 41;
        Boolean live = true;

        if (age == 18 || age == 19)
        {
            Console.WriteLine("Age is 18 or 19");
        }
        
        else if (age == 20)
        {
            Console.WriteLine("BLYAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAT");
        }
        
        else if (age == 41 && live)
        {
            Console.WriteLine("You're alive");
        }
        
        else
        {
            Console.WriteLine("You're a child");
        }
    }
}