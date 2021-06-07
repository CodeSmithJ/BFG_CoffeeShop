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
            var coffee = CoffeeOrder.GetCoffeeOrders();
            return Ok(coffee);
        }

        public IHttpActionResult Get(int id)
        {
            var CoffeeOrder = new CoffeeOrderService();
            var coffee = CoffeeOrder.GetCoffeeOrderById(id);
            return Ok(coffee);
        }
        
        public IHttpActionResult Post(CoffeeOrderCreate Coffee)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = new CoffeeOrderService();

            if (!service.CreateCoffeeOrder(Coffee))
                return InternalServerError();

            return Ok(service);
        }

        
        public IHttpActionResult Put(CoffeeOrderEdit Coffee)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = new CoffeeOrderService();

            if (!service.UpdateCoffeeOrder(Coffee))
                return InternalServerError();

            return Ok(service);
        }

        public IHttpActionResult Delete(int id)
        {
            var service = new CoffeeOrderService();

            if (!service.DeleteCoffeeOrder(id))
                return InternalServerError();

            return Ok($"CoffeeOrder with Id #{id} has been deleted");
        }
    }
}