using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadsExamples
{
    class ThreadDemo1
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;//here thread is class and currentthread is property.
            t.Name = "my thread";
            Console.WriteLine("current executing thread is:"+Thread.CurrentThread.Name);
            Console.Read();
        }
         
    }
}
