namespace BasicContent;

public class C003ArithmeticOperators
{
    public void ShowC003ArithmeticOperators()
    {
        int friends = 5;
        friends *= friends; // 25
        friends += 2; // 27
        friends *= 2; // 54
        friends -= 8; // 46
        Console.WriteLine("Basic Math: " +friends);

        double x = 3;
        double pow2 =  Math.Pow(x, 2); // 9
        Console.WriteLine("Pow2 (^2): " + pow2);
        
        double squareRoot = Math.Sqrt(pow2); // Raiz Quadrada
        Console.WriteLine("Rq: " + squareRoot);

        double y = 3.9;
        double absoluteValue = Math.Abs(-y);
        Console.WriteLine("Absolute value: " + absoluteValue);
        
        double roundValue = Math.Round(absoluteValue);
        Console.WriteLine("Round value: " + roundValue);
        
        Random random = new Random();
        Console.WriteLine("Random Number: " + random.Next(1, 7));
    }
}