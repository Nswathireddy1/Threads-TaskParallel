using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadsExamples
{
    class Thread4
    {
        public static void DoTask()
        {
            Console.WriteLine("From DOTask");

        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(DoTask);

            Console.WriteLine(thread.IsAlive);
            Console.WriteLine(thread.Priority);
            Console.WriteLine(thread.ThreadState);

            thread.Start();
            Console.Read();
        }
    }
}
