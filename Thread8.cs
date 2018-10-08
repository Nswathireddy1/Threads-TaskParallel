using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadsExamples
{
    class Thread8
    {
        public void Display()
        {
            
            
                Console.Write("[CSharp is an");
                Thread.Sleep(5000);
                Console.WriteLine("Object Oriented Language]");
            
        }
        static void Main(string[] args)
        {
            Thread8 obj = new Thread8(); // ove come these problem thread locking concept.
            Thread t1=new Thread(obj.Display);
            Thread t2=new Thread (obj.Display);
            Thread t3=new Thread (obj.Display);
            t1.Start();//perfect out put will come
            t2.Start();
            t3.Start();
            Console.ReadLine();
        }
    }
}
