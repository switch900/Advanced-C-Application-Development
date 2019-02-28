using System;
using System.Threading;

namespace SimpleThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Counting);
            Thread threadOne = new Thread(threadStart);
            Thread threadTwo = new Thread(threadStart);
            threadOne.Start();
            threadTwo.Start();
            threadOne.Join();
            threadTwo.Join();
            Console.Read();
        }

        static void Counting()
        {
            for(int x=1; x<=10; ++x)
            {
                Console.WriteLine("Count : {0} - Thread: {1}", x, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            }
        }
    }
}
