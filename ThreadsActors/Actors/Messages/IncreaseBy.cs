using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadsActors.Actors.Messages
{
    class IncreaseBy
    {
        private int value;

        public IncreaseBy(int value)
        {
            this.Value = value;
        }

        public int Value { get => value; set => this.value = value; }
    }
}
