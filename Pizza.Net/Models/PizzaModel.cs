using System;
using System.Collections.Generic;

namespace Pizza.Net.Models
{
    public class PizzaModel
    {
        public PizzaEnum PizzaEnum { get; set; }

        public List<string> Ingredients { get; set; }

        public PizzaModel(){}

        public PizzaModel (PizzaEnum pizzaEnum, List<string> ingredients)
        {
            PizzaEnum = pizzaEnum;
            Ingredients = ingredients;
        }
    }
}
