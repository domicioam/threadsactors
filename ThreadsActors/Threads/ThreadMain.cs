using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace ThreadsActors.Threads
{
    class ThreadMain : Executable
    {
        Counter counter;
        public void Execute()
        {
            while (true)
            {
                this.counter = new Counter();
                Thread t1 = new Thread(new ThreadStart(DoWork));
                Thread t2 = new Thread(new ThreadStart(DoWork));
                Thread t3 = new Thread(new ThreadStart(DoWork));
                Thread t4 = new Thread(new ThreadStart(DoWork));
                Thread t5 = new Thread(new ThreadStart(DoWork));
                Thread t6 = new Thread(new ThreadStart(DoWork));
                Thread t7 = new Thread(new ThreadStart(DoWork));
                Thread t8 = new Thread(new ThreadStart(DoWork));
                Thread t9 = new Thread(new ThreadStart(DoWork));

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
                Debug.Assert(9 == this.counter.GetValue());
            }
        }

        private void DoWork()
        {
            lock (this.counter)
            {
                int value = this.counter.GetValue();
                this.counter.IncrementBy(1);
            }
        }
    }
}
