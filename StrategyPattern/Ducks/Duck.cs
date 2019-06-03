using System;
using StrategyPattern.Ducks.Behavior.FlyBehavior;
using StrategyPattern.Ducks.Behavior.QuackBehavior;

namespace StrategyPattern.Ducks
{
    public class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;

        public Duck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }

        public void Swim()
        {
            Console.WriteLine("I'm swimming!");

        }

        public virtual void Display()
        {
            Console.WriteLine("I'm a duck!");
        }

        public void PerformQuack()
        {
            flyBehavior.Fly();
        }

        public void PerformFly()
        {
            quackBehavior.Quack();
        }
    }
}
