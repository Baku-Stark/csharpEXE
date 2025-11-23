namespace AdvancedContent;

public class MultiThreadingMethods
{
    public void ShowMultiThreadingMethods()
    {
        Thread maindThread = Thread.CurrentThread;
        maindThread.Name = "MultiThreadingMethods";

        Thread thread1 = new Thread(CountDown);
        thread1.Start();
        
        Console.WriteLine($"Thread #1 : {maindThread.ManagedThreadId}");
    }

    public static void CountDown()
    {
        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine($"Timer #1 : {i}");
            Thread.Sleep(1000);
        }

        Console.WriteLine("Thread is complete!");
    }
}