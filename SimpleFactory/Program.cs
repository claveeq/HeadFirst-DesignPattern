using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine(pizza.GetName());

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine(pizza.GetName());
        }
    }
}
