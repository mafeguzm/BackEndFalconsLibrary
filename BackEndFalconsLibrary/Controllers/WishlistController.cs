using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BackEndFalconsLibrary.Contexts;
using BackEndFalconsLibrary.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace BackEndFalconsLibrary.Controllers
{
    [Route("FalconsLibrary/[controller]")]
    [ApiController]
    public class WishlistController : ControllerBase
    {
        private readonly AppDbContext context;
        public WishlistController(AppDbContext context)
        {
            this.context = context;

        }

        // Read

        [HttpGet("wishlist")]

        public IEnumerable<Wishlist> Get()
        {
            return context.Wishlist.ToList();
        }

        // Read

        [HttpGet("wishlistByID")]
        public Wishlist Get(Int32 id)
        {
            var wishlist = context.Wishlist.FirstOrDefault(p => p.WishlistID == id);
            return wishlist;
        }

        // Create

        [HttpPost("createWishlist")]

        public ActionResult Post([FromBody] Wishlist wishlist)
        {
            try
            {
                context.Wishlist.Add(wishlist);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }


        // Update

        [HttpPut("updateWishlist")]
        public ActionResult Put(Int32 id, [FromBody] Wishlist wishlist)
        {
            try
            {
                if (wishlist.WishlistID == id)
                {
                    context.Entry(wishlist).State = EntityState.Modified;
                    context.SaveChanges();
                    return Ok();
                }

                else
                {

                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        // Delete

        [HttpDelete("deleteWishlist")]
        public ActionResult Delete(Int32 id)
        {
            var wishlist = context.Wishlist.FirstOrDefault(p => p.WishlistID == id);
            if (wishlist != null)
            {
                context.Wishlist.Remove(wishlist);
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
