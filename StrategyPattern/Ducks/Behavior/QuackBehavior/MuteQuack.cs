using System;
namespace StrategyPattern.Ducks.Behavior.QuackBehavior
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("...");
        }
    }
}
