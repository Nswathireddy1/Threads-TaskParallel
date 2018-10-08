using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadsExamples
{
    class Thread5
    {
        public static void Test1()
        {
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Test1 :" + i);
            }
            Console.WriteLine("thread one is executing:");
        }
        public static void Test2()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test2 :" + i);
                if (i == 50)
                {
                    Console.WriteLine("thread two going to sleep:");
                    Thread.Sleep(5000);
                    Console.WriteLine("thread woke up:");
                }
            }
            Console.WriteLine("Thread two is executing:");
        }
        public static void Test3()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test3 :" + i);
            }
            Console.WriteLine("thread three is executing:");
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("main thread is executing:");
            Console.Read();


        }

    }
}
