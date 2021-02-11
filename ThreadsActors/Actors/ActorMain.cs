using Akka.Actor;
using System;
using System.Diagnostics;
using System.Threading;
using ThreadsActors.Actors.Messages;

namespace ThreadsActors.Actors
{
    class ActorMain : ReceiveActor, Executable
    {
        private IActorRef counterActor;

        public ActorMain()
        {
            Receive<GetValueResponse>((message) =>
            {
                Debug.Assert(9 == message.Value);
            });

            Receive<Execute>((message) => Execute());
            Receive<RunThreads>(message => RunThreads());
        }

        private void RunThreads()
        {
            this.counterActor = Context.ActorOf<CounterActor>();

            Thread t1 = new Thread(new ThreadStart(DoWorkAsync));
            Thread t2 = new Thread(new ThreadStart(DoWorkAsync));
            Thread t3 = new Thread(new ThreadStart(DoWorkAsync));
            Thread t4 = new Thread(new ThreadStart(DoWorkAsync));
            Thread t5 = new Thread(new ThreadStart(DoWorkAsync));
            Thread t6 = new Thread(new ThreadStart(DoWorkAsync));
            Thread t7 = new Thread(new ThreadStart(DoWorkAsync));
            Thread t8 = new Thread(new ThreadStart(DoWorkAsync));
            Thread t9 = new Thread(new ThreadStart(DoWorkAsync));

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            t6.Start();
            t7.Start();
            t8.Start();
            t9.Start();

            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();
            t5.Join();
            t6.Join();
            t7.Join();
            t8.Join();
            t9.Join();

            this.counterActor.Tell(new GetValue(Self));
        }

        public void Execute()
        {
            Context
                .System
                .Scheduler
                .ScheduleTellRepeatedly(
                    TimeSpan.FromSeconds(0),
                    TimeSpan.FromSeconds(0.1),
                    Self,
                    new RunThreads(),
                    ActorRefs.NoSender
                );
        }

        private void DoWorkAsync()
        {
            this.counterActor.Tell(new IncreaseBy(1));
        }
    }
}
