using BFG_CoffeeShop.Data;
using BFG_CoffeeShop.Models.MenuModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFG_CoffeeShop.Services
{
    public class MenuService
    {
        public bool CreateMenu(MenuCreate model)
        {
            var entity =
                new Menu()
                {
                    ItemName = model.ItemName,
                    ItemPrice = model.ItemPrice
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Menus.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
