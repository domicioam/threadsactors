using System;
using ThreadsActors.Threads;

namespace ThreadsActors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Executable executable = new ThreadMain();
            executable.Execute();
        }
    }
}
