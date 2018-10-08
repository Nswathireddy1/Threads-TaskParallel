using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadsExamples
{
    class ThreadDemo2
    {
        public static void Test1()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test1 :" + i);
                if(i==50)
                {
                    Console.WriteLine("main thread going to sleep:");
                    Thread.Sleep(5000);
                    Console.WriteLine("main thread woke up:");
                }
            }
        }
        public static void Test2()
        {
            for (int i = 0; i <= 150; i++)
            {
                Console.WriteLine("Test2 :" + i);
            }
        }
        static void Main(string[] args)
        {
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Main :" + i);
            }
            Test1();
            Test2();
            Console.Read();
        }
    }


}

