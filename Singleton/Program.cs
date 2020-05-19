using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 100; i++)
            {
                new Thread(() =>
                {
                    Console.WriteLine(Singleton1.instance.GetHashCode());
                    
                }).Start();
            }
        }
    }
}
