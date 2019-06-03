using System;
namespace StrategyPattern.Ducks.Behavior.FlyBehavior
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Not flying...");
        }
    }
}
