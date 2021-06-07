using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFG_CoffeeShop.Models.CustomerModels
{
    public class CustomerDetails
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        public Guid CustomerTag { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string PaymentType { get; set; }

        //      public List<FavoriteOrder> FavoriteOrders { get; set; }
    }
}
