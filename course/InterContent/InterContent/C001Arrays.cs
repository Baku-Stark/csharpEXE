namespace InterContent;

public class C001Arrays
{
    public void ShowC001Arrays()
    {
        String[] cars = new string[3];
        
        cars[0] = "BMW";
        cars[1] = "Mercedes";
        cars[2] = "Toyota";

        foreach (String car in cars)
        {
            Console.WriteLine($"Car: {car}");
        }
    }
}