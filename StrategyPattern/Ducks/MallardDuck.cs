using System;
using StrategyPattern.Ducks.Behavior.FlyBehavior;
using StrategyPattern.Ducks.Behavior.QuackBehavior;

namespace StrategyPattern.Ducks
{
    public class MallardDuck: Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck!");
        }
    }
}
