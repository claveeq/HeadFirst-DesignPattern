using System;
namespace DecoratorPattarn
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string GetDescription();
    }
}
