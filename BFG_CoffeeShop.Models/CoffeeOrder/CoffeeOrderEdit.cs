using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFG_CoffeeShop.Models.CoffeeOrder
{
    public class CoffeeOrderEdit
    {
        public DateTimeOffset? Edited { get; set; }
        public string Barista { get; set; }
        public string Country {get;set;}
    }
}
