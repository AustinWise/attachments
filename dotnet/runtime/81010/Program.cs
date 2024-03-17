using System.Diagnostics;

static class Program
{
    static void FillStack(byte value)
    {
        Span<byte> bytes = stackalloc byte[1024 * 16];
        bytes.Fill(value);
    }

    static void Main(string[] args)
    {
        Console.WriteLine($"Attach to PID {Process.GetCurrentProcess().Id} and press enter.");
        Console.ReadLine();
        AppDomain.CurrentDomain.UnhandledException += (_,_) => FillStack(0xff);
        throw new Exception();
    }
}