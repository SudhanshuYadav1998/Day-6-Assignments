using System.Diagnostics;

class Program
{
    static void Main()
    {
        // Create new stopwatch from class Stopwatch
        Stopwatch stopwatch = new Stopwatch();

        // here we start the timing for stopwatch
        stopwatch.Start();

        // calculating time elapsed for 1000 sec
        for (int i = 0; i < 1000; i++)
        {
            Thread.Sleep(1);
        }

        // Stop the counting of stopwatch
        stopwatch.Stop();

        // Output the result 
        Console.WriteLine($"Time elapsed:  {stopwatch.Elapsed}");
    }
}