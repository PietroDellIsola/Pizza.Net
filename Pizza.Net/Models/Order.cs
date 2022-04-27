using System;
using System.Collections.Generic;

namespace Pizza.Net.Models
{
    public class Order
    {
        public List<int> OrderedPizzas { get; set; } 

        public DateTime insertOrder { get; set; }//DateTime.Now

        public DateTime requestOrder { get; set; }

        public double TotalPrice { get; set; }

        public Boolean Payed { get; set; }
    }
}
