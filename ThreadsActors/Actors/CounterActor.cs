using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Text;
using ThreadsActors.Actors.Messages;

namespace ThreadsActors.Actors
{
    class CounterActor : ReceiveActor
    {
        Counter counter;

        public CounterActor()
        {
            counter = new Counter();
            Receive<IncreaseBy>((message) => 
                counter.IncrementBy(message.Value));
            Receive<GetValue>((message) => {
                int value = counter.GetValue();
                var response = new GetValueResponse(value);
                message.ReplyTo.Tell(response);
            });
        }
    }
}
