namespace ChocolateBoiler;

internal class Program
{
    private static void Main(string[] args)
    {
        ChocolateBoiler boiler1 = ChocolateBoiler.GetInstance();
        ChocolateBoiler boiler2 = ChocolateBoiler.GetInstance();

        if (boiler1 == boiler2)
        {
            Console.WriteLine("Singleton works, both variables contain the same instance.");
        }
        else
        {
            Console.WriteLine("Singleton failed, variables contain different instances.");
        }

        Thread process1 = new Thread(() =>
        {
            TestSingleton("FOO");
        });
        Thread process2 = new Thread(() =>
        {
            TestSingleton("BAR");
        });

        process1.Start();
        process2.Start();

        process1.Join();
        process2.Join();
    }

    private static void TestSingleton(string name)
    {
        ChocolateBoilerWithLock boilerWithLock = ChocolateBoilerWithLock.GetInstance(name);
        Console.WriteLine(boilerWithLock.Name);
    }
}
