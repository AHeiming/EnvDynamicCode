using System.Diagnostics;

public class ProdConsoleApplication
{
    public static void Main(string[] args)
    {
        PrintDebugString();
    }

    public static void PrintDebugString()
    {
        Console.WriteLine("This line is printed if executor is prod or test!");

        var test = Process.GetCurrentProcess().ProcessName;
        if (test == nameof(ProdConsoleApplication))
        {
            Console.WriteLine("This line is only printed if executed from prod!");
        }
    }
}