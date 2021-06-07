using BFG_CoffeeShop.Data;
using BFG_CoffeeShop.Models.CoffeeOrder;
using BFG_CoffeeShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace BFG_CoffeeShop.WebAPI.Controllers
{
   
    public class CoffeeOrderController : ApiController
    {
       
        public IHttpActionResult Get()
        {
            var CoffeeOrder = new CoffeeOrderService();
            var cat = CoffeeOrder.GetCoffeeOrders();
            return Ok(cat);
        }

        /*
        public IHttpActionResult Get(int id)
        {
            var CategoryService = CreateCategory();
            var cat = CategoryService.GetCategoryById(id);
            return Ok(cat);
        }
        */

        public IHttpActionResult Post(CoffeeOrderCreate Category)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = new CoffeeOrderService();

            if (!service.CreateCoffeeOrder(Category))
                return InternalServerError();

            return Ok(service);
        }

        /*
        public IHttpActionResult Put(CategoryEdit Category)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateCategory();

            if (!service.UpdateCategory(Category))
                return InternalServerError();

            return Ok(service);
        }

        public IHttpActionResult Delete(int id)
        {
            var service = CreateCategory();

            if (!service.DeleteCategory(id))
                return InternalServerError();

            return Ok($"Category with Id #{id} has been deleted");
        }
        */
        
    }
}