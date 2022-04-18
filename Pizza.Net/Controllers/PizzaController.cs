using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pizza.Net.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Net.Controllers
{
    [Route("api")]
    [ApiController]
    public class PizzaController : Controller
    {
        
        List<PizzaModel> pizzas = new List<PizzaModel>
        {
            new PizzaModel { PizzaEnum = PizzaEnum.Margherita, 
                Ingredients = new List<string> { "Pomodoro", "Mozzarella", "Basilico" }},
            new PizzaModel { PizzaEnum = PizzaEnum.Marinara,
            Ingredients = new List<string> { "Pomodoro", "Aglio", "Origano" }},
            new PizzaModel { PizzaEnum = PizzaEnum.RossaConVerdure,
            Ingredients = new List<string> { "Pomodoro", "Mozzarella", "Basilico", "Verdure grigliate" }},
            new PizzaModel { PizzaEnum = PizzaEnum.BiancaConVerdure,
            Ingredients = new List<string> { "Mozzarella", "Basilico", "Verdure grigliate" }}
        };

        [HttpGet("pizza")]
        public List<PizzaResponse> GetPizzas() {
            List<PizzaResponse> pizzaRes = new List<PizzaResponse>();
            foreach (PizzaModel pizza in pizzas)
            {
                pizzaRes.Add(new PizzaResponse(pizza.PizzaEnum.ToString(), pizza.Ingredients));
            }
            return pizzaRes;
        }

    }
}
