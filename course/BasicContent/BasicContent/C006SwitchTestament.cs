namespace BasicContent;

public class C006SwitchTestament
{
    public void ShowC006SwitchTestament()
    {
        String food = "Pizza";

        switch (food)
        {
            case "Pizza":
                Console.WriteLine("AAAAAAAAAAAAAAAAAAAH");
                break;
            
            case "Cheese":
                Console.WriteLine("HOHOHHOHO");
                break;
            
            default:
                Console.WriteLine("BLYAAAAAAAAAAAAAAAT");
                break;
        }
    }
}