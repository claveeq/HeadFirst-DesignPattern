using System;
namespace DecoratorPattarn
{
    public abstract class Beverage
    {
        public string description = "Unkown Beverage";

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
}
