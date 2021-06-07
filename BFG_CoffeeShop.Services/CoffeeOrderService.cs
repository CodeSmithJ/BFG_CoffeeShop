using BFG_CoffeeShop.Data;
using BFG_CoffeeShop.Models.CoffeeOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFG_CoffeeShop.Services
{
    public class CoffeeOrderService
    {
        public bool CreateCoffeeOrder(CoffeeOrderCreate model)
        {
            var entity = new CoffeeOrder()
            {
                FullName = model.FullName,
                Created = DateTimeOffset.Now,
                AdditionId = model.AdditionId,
                CustomerId = model.CustomerId,
                MenuId = model.MenuId,
                TotalPrice = model.TotalPrice,
                Country = model.Country
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.CoffeeOrders.Add(entity);
                return ctx.SaveChanges() >= 1;
            }
        }

        public IEnumerable<CoffeeOrderListItem> GetCoffeeOrders()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .CoffeeOrders
                        .Select(
                        e =>
                            new CoffeeOrderListItem
                            {
                                CoffeeOrderId = e.CoffeeOrderId,
                                CustomerId = e.CustomerId,
                                MenuId = e.MenuId,
                                AdditionId = e.AdditionId,
                                TotalPrice = e.TotalPrice
                            }
                        );
                return query.ToArray();
            }
        }

        /*
        public IEnumerable<NoteListItem> GetStarred()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .CoffeeOrders
                        .Where(e => e.OwnerId == _userId && e.IsStarred == true)
                        .Select(
                        e =>
                            new NoteListItem
                            {
                                NoteId = e.NoteId,
                                Title = e.Title,
                                IsStarred = e.IsStarred,
                                CategoryId = e.CategoryId,
                                CreatedUtc = e.CreatedUtc
                            }
                        );
                return query.ToArray();
            }
        }

        public CoffeeOrderDetail GetCoffeeOrderById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .CoffeeOrders
                    .Single(e => e.CoffeeOrderId == id);
                return
                    new CoffeeOrderDetail
                    {
                        entity.
                    };
            }
        }

        public bool UpdateCoffeeOrder(CoffeeOrderEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .CoffeeOrders
                        .Single(e => e.CoffeeOrderId == model.CoffeeOrderId);

                entity.Barista = model.Barista;
                entity.AdditionId = model.AdditionId;
                entity.Country = model.Country;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteNote(int noteId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Notes
                        .Single(e => e.NoteId == noteId && e.OwnerId == _userId);

                ctx.Notes.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    
        */
    }
}
