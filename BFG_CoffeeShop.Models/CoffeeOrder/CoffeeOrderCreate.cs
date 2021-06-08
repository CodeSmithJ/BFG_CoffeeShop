﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFG_CoffeeShop.Models.CoffeeOrder
{
    public class CoffeeOrderCreate
    {
        public string FullName { get; set; }
        public string Country { get; set; }
        public string Barista { get; set; }
        public decimal TotalPrice { get; set; }
        public int AdditionId { get; set; }
        public int CustomerId { get; set; }
        public int MenuId { get; set; }
    }
}
