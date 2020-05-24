using System;
namespace Factory.AbstractFactory
{
    public class MagicFactory : AbstractFactory
    {

        public override Food CreateFood()
        {
            return new MushRoom();
        }

        public override Vihicle CreateVihicle()
        {
            return new Broom();
        }

        public override Weapon CreateWeapon()
        {
            return new MagicStick(); 
        }
    }
}
