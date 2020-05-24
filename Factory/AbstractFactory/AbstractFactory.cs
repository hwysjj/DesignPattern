using System;
namespace Factory.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract Food CreateFood();
        public abstract Vihicle CreateVihicle();
        public abstract Weapon CreateWeapon();
    }
}
