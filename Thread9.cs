using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadsExamples
{
    class Thread9
    {
        public void Display()
        {
            lock (this)
            {
                Console.Write("[CSharp is an");
                Thread.Sleep(5000);
                Console.WriteLine("Object Oriented Language]");
            }
        }
        static void Main(string[] args)
        {
            Thread9 obj = new Thread9(); //thread locking concept.

            Thread t1 = new Thread(obj.Display);
            Thread t2 = new Thread(obj.Display);
            Thread t3 = new Thread(obj.Display);
            t1.Start();t2.Start();t3.Start();
            Console.ReadLine();
        }
    }
}
