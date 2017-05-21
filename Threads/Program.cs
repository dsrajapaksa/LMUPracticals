using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            for (i = 1; i < 50; i++)
            {
                Console.WriteLine("Current Value : {0}", i);
                Console.WriteLine("Lets Sleep for 2 seconds... :P");
                Thread.Sleep(2000);
            }

            Console.ReadLine();
        }
    }
}
