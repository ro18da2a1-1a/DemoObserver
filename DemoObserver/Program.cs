using System;

namespace DemoObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            worker.Start();

            Console.ReadLine();
        }
    }
}
