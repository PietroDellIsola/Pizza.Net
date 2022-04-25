using System;
using System.Collections.Generic;

namespace Pizza.Net.Models
{
    public class PizzaResponse  
    {
        public String Name { get; set; }

        public List<string> Ingredients { get; set; }

        public double Price { get; set; }

        public PizzaResponse() { }

        public PizzaResponse(String name, List<string> ingredients, double price) {
            Name = name;
            Ingredients = ingredients;
            Price = price;
        }

    }
}
