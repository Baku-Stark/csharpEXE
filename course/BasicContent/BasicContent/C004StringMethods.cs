namespace BasicContent;

public class C004StringMethods
{
    public void ShowC004StringMethods()
    {
        String fullName = "Wallace Baku-Stark";
        Console.WriteLine("Upper Case: " + fullName.ToUpper());
        Console.WriteLine("Lower Case: " + fullName.ToLower());
        Console.WriteLine("FullName Lenght: " + fullName.Length);
        Console.WriteLine("FullName changed: " + fullName.Insert(0, "Z")); // FullName changed: ZWallace Baku-Stark
        Console.WriteLine();
        
        String phoneNumber = "012345-6789";
        Console.WriteLine("Phone Number: " + phoneNumber.Replace("-", " "));
    }
}