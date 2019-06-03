using System;
namespace StrategyPattern.Ducks.Behavior.FlyBehavior
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flying...");
        }
    }
}
