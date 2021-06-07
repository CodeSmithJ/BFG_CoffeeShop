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

        public IEnumerable<MenuListItem> GetMenus()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Menus
                        .Select(
                            e =>
                                new MenuListItem
                                {
                                    MenuId = e.MenuId,
                                    ItemName = e.ItemName,
                                }
                        );
                return query.ToArray();
            }
        }

        public MenuDetail GetMenuById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Menus
                        .Single(e => e.MenuId == id);
                return
                    new MenuDetail
                    {
                        MenuId = entity.MenuId,
                        ItemName = entity.ItemName,
                        ItemPrice = entity.ItemPrice
                    };
            }
        }
    }
}
