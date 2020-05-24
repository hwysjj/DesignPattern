using System;
namespace Factory.FactoryMethods
{
    public class PlaneFactory
    {
        public Moveable Create()
        {
            return new Plane();
        }
    }
}
