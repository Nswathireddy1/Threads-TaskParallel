using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadsExamples
{
    class Thread7
    {
        public void Display()
        {
            Console.Write("[CSharp is an");
            Thread.Sleep(5000);
            Console.WriteLine("Object Oriented Language]");
        }
        static void Main(string[] args)
        {
            Thread7 obj = new Thread7(); 
            obj.Display();
            obj.Display();
            obj.Display();
            Console.ReadLine();
        }
    }
}
