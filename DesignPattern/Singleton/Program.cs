using TestCSharp;
internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 0; i < 100; i++)
        {
            Thread t = new Thread(() =>
            {
                for (int j = 0; j < 1000; j++)
                {
                    Singleton.IncreaseCount();
                }
                Console.WriteLine("Done thread");
            });
            t.IsBackground = true;
            t.Start();
        }
        Thread.Sleep(3000);

        Console.WriteLine(Singleton.GetCount());
    }

}