using System;
namespace Singleton
{
    public class Singleton2
    {
        private static Singleton2 _instance;
        private static readonly object _instancelock = new object();

        private Singleton2()
        {
        }

        public static Singleton2 instance
        {
            get
            {
                if (_instance == null)
                {
                    // avoid multiple threads updating _instance
                    lock (_instancelock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton2();
                            
                        }
                        
                    }
                }
                return _instance;
                
            }
        }
    }
}
