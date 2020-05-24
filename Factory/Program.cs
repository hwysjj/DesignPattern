using System;
using Factory.AbstractFactory;

namespace Factory
{
    class Program
    {
        // 工厂系列
        // 简单工厂
        // 静态工厂
        // 工厂方法
            ///产品围度扩展
        // 抽象工厂
            ///产品一族进行扩展
        static void Main(string[] args)
        {
            Factory.AbstractFactory.AbstractFactory af = new MagicFactory();
            af.CreateFood();
            af.CreateVihicle();
            af.CreateWeapon();
        }
    }
}
