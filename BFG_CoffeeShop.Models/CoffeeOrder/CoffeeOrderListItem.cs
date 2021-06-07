using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFG_CoffeeShop.Models.CoffeeOrder
{
    public class CoffeeOrderListItem
    {
        public int CoffeeOrderId { get; set; }
        public DateTimeOffset Created { get; set; }
        public double TotalPrice { get; set; }
        public int AdditionId { get; set; }
        public int CustomerId { get; set; }
        public int MenuId { get; set; }
    }
}
