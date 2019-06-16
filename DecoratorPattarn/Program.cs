using System;

namespace DecoratorPattarn
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.GetDescription() + ", Cost: " + beverage.Cost());

            Beverage beverage2 = new Espresso();
            beverage2 = new Mocha(beverage2);
            Console.WriteLine(beverage2.GetDescription() + ", Cost: " + beverage2.Cost());

            Beverage beverage3 = new Espresso();
            beverage3 = new Mocha(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Mocha(beverage3);
            Console.WriteLine(beverage3.GetDescription() + ", Cost: " + beverage3.Cost());
        }
    }
}
