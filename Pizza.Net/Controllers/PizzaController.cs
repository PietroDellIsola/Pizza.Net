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
            new PizzaModel { PizzaEnum = PizzaEnum.Marinara,
                Ingredients = new List<string> { "Pomodoro", "Aglio", "Origano", "Olio" }, Price = 3.5},
            new PizzaModel { PizzaEnum = PizzaEnum.Margherita,
                Ingredients = new List<string> { "Pomodoro", "Fior di latte", "Basilico", "Olio" }, Price = 4.0},
            new PizzaModel { PizzaEnum = PizzaEnum.Napoletana,
                Ingredients = new List<string> { "Pomodoro", "Acciughe", "Aglio", "Origano", "Olio" }, Price = 4.0},
            new PizzaModel { PizzaEnum = PizzaEnum.RossaConVerdure,
                Ingredients = new List<string> { "Pomodoro", "Fior di latte", "Basilico", "Verdure grigliate", "Olio" }, Price = 6.0},
            new PizzaModel { PizzaEnum = PizzaEnum.BiancaConVerdure,
                Ingredients = new List<string> { "Fior di latte", "Basilico", "Verdure grigliate", "Olio" }, Price = 6.0},
            new PizzaModel { PizzaEnum = PizzaEnum.QuattroFormaggi,
                Ingredients = new List<string> { "Fior di latte", "Formaggi misti", "Olio" }, Price = 6.0},
            new PizzaModel { PizzaEnum = PizzaEnum.Capricciosa,
                Ingredients = new List<string> { "Fior di latte", "Pomodoro", "Prosciutto cotto",
                    "Carciofi", "Funghi", "Olive nere", "Olio" }, Price = 6.0},
            new PizzaModel { PizzaEnum = PizzaEnum.QuattroStagioni,
                Ingredients = new List<string> { "Fior di latte", "Pomodoro", "Prosciutto cotto",
                    "Carciofi", "Funghi", "Olive nere", "Olio" }, Price = 6.0},
            new PizzaModel { PizzaEnum = PizzaEnum.Siciliana,
                Ingredients = new List<string> { "Fior di latte", "Pomodoro", "Melanzane a funghetti", "Olio" }, Price = 6.0},
            new PizzaModel { PizzaEnum = PizzaEnum.WurstelEPatatine,
                Ingredients = new List<string> { "Fior di latte", "Pomodoro", "Wurstel", "Patatine fritte", "Olio" }, Price = 6.0}
        };

        [HttpGet("pizza")]
        public List<PizzaResponse> GetPizzas()
        {
            List<PizzaResponse> pizzaRes = new List<PizzaResponse>();
            foreach (PizzaModel pizza in pizzas)
            {
                pizzaRes.Add(new PizzaResponse(pizza.PizzaEnum.ToString(), pizza.Ingredients, pizza.Price));
            }
            return pizzaRes;
        }

    }
}
