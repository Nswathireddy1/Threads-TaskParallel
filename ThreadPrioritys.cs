using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadsExamples
{
    class ThreadPrioritys
    {
        static long Count1, Count2;
        public static void IncrementCount1()
        {
            while (true)
            Count1 += 1;
        }
        public static void IncrementCount2()
        {
            while (true)
                Count2 += 1;
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(IncrementCount1);
            Thread t2 = new Thread(IncrementCount2);
            //t1.Priority = ThreadPriority.Lowest;
            //t2.Priority = ThreadPriority.Highest;
            t1.Start();
            t2.Start();
            Console.WriteLine("main thread going to sleep");
            Thread.Sleep(10000);
            Console.WriteLine("thread woke up");
            t1.Abort();//treminating thread
            t2.Abort();
            t1.Join();
            t2.Join();
            Console.WriteLine("count1:" + Count1);
            Console.WriteLine("count2:" + Count2);
            Console.Read();
        }
    }
}
