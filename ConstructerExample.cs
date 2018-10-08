using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadsExamples
{
    class ConstructerExample
    {
        static void Test()
        {
            for(int i=1;i<=100;i++)
            {
                Console.WriteLine("test:" + i);
            }
        }
        static void Main(string[] args)
        {
            // Test();
            //Console.ReadLine();
            ThreadStart obj = new ThreadStart(Test);
            Thread t = new Thread(obj);
            t.Start();
            Console.ReadLine();
        }
    }
}
