using System;
using StrategyPattern.Ducks.Behavior.FlyBehavior;
using StrategyPattern.Ducks.Behavior.QuackBehavior;

namespace StrategyPattern.Ducks
{
    public class RubberDuck: Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Squeak();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Rubber Duck!");
        }
    }
}
