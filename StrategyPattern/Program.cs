using System;
using StrategyPattern.Ducks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strategy Pattern!");

            /*
                Strategy Pattern defines a family of algorithms encapsulates each one, and makes them interchangeable.
                Stretegy lets the algorithm vary independently from clients that use it.              
            */

            var duck = new Duck();
            duck.Display();
            duck.PerformFly();
            duck.PerformQuack();
            duck.Swim();

            var rubberDuck = new RubberDuck();
            rubberDuck.Display();
            rubberDuck.PerformFly();
            rubberDuck.PerformQuack();
            rubberDuck.Swim();

            var mallardDuck = new MallardDuck();
            mallardDuck.Display();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();
            mallardDuck.Swim();
        }
    }
}
