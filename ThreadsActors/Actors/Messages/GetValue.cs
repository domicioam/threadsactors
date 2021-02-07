using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadsActors.Actors.Messages
{
    class GetValue
    {
        IActorRef replyTo;
        public GetValue(IActorRef replyTo)
        {
            this.ReplyTo = replyTo;
        }

        public IActorRef ReplyTo { get => replyTo; set => replyTo = value; }
    }
}
