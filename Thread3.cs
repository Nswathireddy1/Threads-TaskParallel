using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadsExamples
{
    class Thread3
    {
        static void Main(string[] args)
        {
            Thread th = new Thread(() =>
            {
                for (int i = 0; i <= 50; i++)
                {
                    Console.WriteLine(i);
                }
            });
            Thread th1 = new Thread(() =>
            {
                for (int i = 50; i <= 100; i++)
                {
                    Console.WriteLine(i);
                }
            });
            th.Start();
            th1.Start();
            Console.Read();
        }
    }
}
