﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFG_CoffeeShop.Data
{
    public class CoffeeOrder
    {
        [Key]
        public int CoffeeOrderId { get; set; }
        public string FullName { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Edited { get; set; }
        public string Country { get; set; }
        public decimal TotalPrice { get; set; }
        public string Barista { get; set; }
        //List<Addition> Additions { get; set; }

        //List<Customer> Customers { get; set; }

        //List<Menu> Menus { get; set; }  
    }
}