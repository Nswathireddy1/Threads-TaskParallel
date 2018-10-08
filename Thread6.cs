using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadsExamples
{
    class Thread6
    {
        public static void Test1()
        {
            Console.WriteLine("thread one is starting:");
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Test1 :" + i);
                Thread.Sleep(5000);
                
            }
            Console.WriteLine("thread one is exiting");
        }
        public static void Test2()
        {
            Console.WriteLine("thread two starting");
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Test2 :" + i);
               
            }
            Console.WriteLine("thread two is exiting");
        }
        public static void Test3()
        {
            Console.WriteLine("thread three staring");
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Test3 :" + i);
                
            }
            Console.WriteLine("thread three exiting");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("main thread starting");
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start();
            t2.Start();
            t3.Start();
          //t1.Join();
            //t2.Join();
            //t3.Join();
            Console.WriteLine("main thread exiting");
            Console.ReadLine();


        }
    }
}
