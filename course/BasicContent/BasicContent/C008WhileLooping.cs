namespace BasicContent;

public class C008WhileLooping
{
    public void ShowC008WhileLooping()
    {
        int i = 0;
        
        while (i < 10)
        {
            for (int j = 0; j < 11; j++)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        Console.WriteLine("DONE!");
    }
}