// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Events;
 
internal class Program
{
    private static void Main(string[] args)
    {
        Publisher pbl = new Publisher();
        pbl.SampleEvent += Emailsubs.EmailEventHandler;
        pbl.SampleEvent += LogSubs.LogEventHandler;

        pbl.Initiate();
    }
}