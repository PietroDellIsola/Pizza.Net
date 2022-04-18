using System;
using System.Collections.Generic;

namespace Pizza.Net.Models
{
    public enum PizzaEnum
    {
        PizzaNotFounded,
        Margherita,
        Marinara,
        RossaConVerdure,
        BiancaConVerdure
    }

    /*public class PizzaEnum
    {
        private readonly int code;
        public readonly string name;

        private PizzaEnum(int code, string name) {
            this.code = code;
            this.name = name;
        }

        public static PizzaEnum ERROR = new PizzaEnum(0, "Pizza not founded");
        public static PizzaEnum MARGHERITA = new PizzaEnum(1, "Margherita");
        public static PizzaEnum MARINARA = new PizzaEnum(2, "Marinara");
        public static PizzaEnum ROSSA_CON_VERDURE = new PizzaEnum(3, "Rossa con verdure");
        public static PizzaEnum BIANCA_CON_VERDURE = new PizzaEnum(4, "Bianca con verdure");

        public PizzaEnum getByCode(int codeToFind) {
            foreach (PizzaEnum pizza in Enum.GetValues(typeof(PizzaEnum))) 
            {
                if (pizza.code == codeToFind) {
                    return pizza;
                }
            }
            
            return PizzaEnum.ERROR;
        }

        public override string ToString()
        {
            return name;
        }

        public String getName(PizzaEnum pizzaEnum) {
            return pizzaEnum.name;
        }
    }*/
}
