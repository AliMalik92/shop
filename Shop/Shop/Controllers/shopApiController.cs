using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;
using Microsoft.AspNet.Identity;
namespace Shop.Controllers
{
    public class shopApiController : ApiController
    {
        private Entities db = new Entities();

        [HttpGet]
        public IHttpActionResult addCart([FromUri]int itemid)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                User_Products u = new User_Products();
                u.ProductId = itemid;
                u.UserId = @User.Identity.GetUserId();
                u.Shipping = 0;
                db.User_Products.Add(u);
                db.SaveChanges();
               
            }
            catch (Exception ex)
            {
                return BadRequest("Exception" + ex.Data);
            }
            return Ok();
            
        }
    }
}
