using System;
namespace StrategyPattern.Ducks.Behavior.QuackBehavior
{
    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quack Quack!!!");
        }
    }
}
