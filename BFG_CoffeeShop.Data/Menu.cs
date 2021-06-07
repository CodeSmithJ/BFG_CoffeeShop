﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFG_CoffeeShop.Data
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }
        
        [Required]
        public string MenuName { get; set; }
        
        public List<string> MenuList { get; set; }
        
        [Required]
        public double ItemPrice { get; set; }
    }
}
