using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LB_BasicThreading
{
    internal class MyThreadClass
    {
        public static void Thread1() 
        {
            for (int LoopCount = 0; LoopCount <= 5; LoopCount++) 
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + LoopCount);
                Thread.Sleep(1500); // 1.5 seconds

            }
        
        }
    }
}
