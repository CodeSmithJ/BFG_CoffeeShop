﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFG_CoffeeShop.Models.CoffeeOrder
{
    public class CoffeeOrderEdit
    {
        public int CoffeeOrderId {get; set;}
        public DateTimeOffset? Edited {get; set;}
        public int AdditionId {get; set;}
        public string Barista {get; set;}
        public string Country {get;set;}
    }
}