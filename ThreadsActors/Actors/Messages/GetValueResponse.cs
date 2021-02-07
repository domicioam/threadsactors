using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadsActors.Actors.Messages
{
    class GetValueResponse
    {
        public GetValueResponse(int value)
        {
            Value = value;
        }

        public int Value { get; }
    }
}
