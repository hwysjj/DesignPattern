using System;
namespace Factory.AbstractFactory
{
    public class MordernFactory : AbstractFactory
    {

        public override Food CreateFood()
        {
            return new Bread();
        }

        public override Vihicle CreateVihicle()
        {
            return new Car();
        }

        public override Weapon CreateWeapon()
        {
            return new AK47();
        }
    }
}
