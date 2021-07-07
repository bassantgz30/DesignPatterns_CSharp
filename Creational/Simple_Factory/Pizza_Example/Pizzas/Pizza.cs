using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Example.Pizzas
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }
        public string Dough { get; protected set; }
        public string Sauce { get; protected set; }
        public List<string> Toppings { get; protected set; } = new List<string>();

        public virtual void prepare()
        {
            Console.WriteLine("Preparing " + Name);
        }

        public virtual void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine("---- " + Name + " ----");
            result.AppendLine(Dough);
            result.AppendLine(Sauce);
            foreach (var topping in Toppings)
            {
                result.AppendLine(topping);
            }

            return result.ToString();
        }
    }
}
