using System;
namespace Singleton
{
    public class Singleton1
    {

        private static readonly Lazy<Singleton1> _instance =
            new Lazy<Singleton1>(() => new Singleton1());


        private Singleton1()
        {
            // initialise instance
        }

        public static Singleton1 instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }
}
