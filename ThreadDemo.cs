using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsExamples
{
    class ThreadDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");//here internally thread will be generated. but did'nt mention thread name
            Console.Read();
        }
    }
}
