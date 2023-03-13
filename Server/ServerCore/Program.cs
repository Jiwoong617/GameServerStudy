using System;
using System.Threading;

namespace ServerCore
{
    class Program
    {
        volatile static bool _stop =false;

        static void ThreadMain()
        {
            Console.WriteLine("Start");

            while (!_stop)
            {

            }

            Console.WriteLine("End");
        }

        static void Main(string[] args)
        {
            Task t = new Task(ThreadMain);
            t.Start();

            Thread.Sleep(1000);

            _stop = true;

            Console.WriteLine("STOP 호출");
            Console.WriteLine("종료 대기중");

            t.Wait();

            Console.WriteLine("종료 성공");
        }
    }
}