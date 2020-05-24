using System;
namespace Factory.FactoryMethods
{
    // simple factory pattern is hard to extend
    public class SimpleVehicalFactory
    {
        
        public Car CreateCar()
        {
            return new Car();
        }
        public Plane CreatePlane()
        {
            return new Plane();
        }
    }
}
