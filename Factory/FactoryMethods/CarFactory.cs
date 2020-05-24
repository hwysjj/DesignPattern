using System;
namespace Factory.FactoryMethods
{
    public class CarFactory
    {
        public Moveable Create()
        {
            return new Car();
        }
    }
}
