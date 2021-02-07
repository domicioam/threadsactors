using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadsActors
{
    class Counter
    {
        int value;

        public void IncrementBy(int value)
        {
            this.value += value;
        }

        public int GetValue()
        {
            return this.value;
        }
    }
}
