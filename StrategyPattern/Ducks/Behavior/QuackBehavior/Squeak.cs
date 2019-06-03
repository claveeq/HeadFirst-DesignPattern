using System;
namespace StrategyPattern.Ducks.Behavior.QuackBehavior
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak Squeak!!!");
        }
    }
}
