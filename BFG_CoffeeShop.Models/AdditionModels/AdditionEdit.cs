﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFG_CoffeeShop.Models.AdditionModels
{
    public class AdditionEdit
    {
        public int AdditionId { get; set; }

        [Required]
        public string Name { get; set; }

    }
}