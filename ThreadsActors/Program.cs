using Akka.Actor;
using System;
using ThreadsActors.Actors;
using ThreadsActors.Actors.Messages;
using ThreadsActors.Threads;

namespace ThreadsActors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Executable threadMain = new ThreadMain();
            //threadMain.Execute();

            var actorSystem = ActorSystem.Create("ActorSystem");
            var actorMain = actorSystem.ActorOf<ActorMain>();
            actorMain.Tell(new Execute());

            while (true) { }
        }
    }
}
