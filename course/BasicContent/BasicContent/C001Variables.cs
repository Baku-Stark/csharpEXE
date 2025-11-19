namespace BasicContent;

public class C001Variables {
    public void ShowC001Variables()
    {
        string name = "Wallace";
        int age = 25;
        char gender = 'M';
        double height = 1.5;
        bool live = true;
        long years = 4545131;

        int converting = Convert.ToInt32(height);
        
        Console.WriteLine("My name is {0}", name);
        Console.WriteLine("I'm {0} years old", age);
        Console.WriteLine("My gender is {0}", gender);
        Console.WriteLine("Height is {0}", height);
        Console.WriteLine("Live is {0}", live);
        Console.WriteLine("Years is {0}", years);
        Console.WriteLine($"Converting Double {height} to Int32 {converting} (Type: {converting.GetType()})");
    }
}