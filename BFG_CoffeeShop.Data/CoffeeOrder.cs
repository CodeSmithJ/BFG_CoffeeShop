using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public DateTimeOffset Created {get;set;}
        public DateTimeOffset? Edited { get; set; }
        public string Country { get; set; }
        public double TotalPrice { get; set; }
        [Required]
        public string Barista { get; set; }
        public int AdditionId {get; set;}
        //[ForeignKey(nameof(AdditionId))]
        //List<Addition> Additions { get; set; }
        public int CustomerId { get; set; }
        //[ForeignKey(nameof(CustomerId))]
        //List<Customer> Customers { get; set; }
        public int MenuId { get; set; }
        //[ForeignKey(nameof(CustomerId))]
        //List<Customer> Customers { get; set; }  
    }
}
