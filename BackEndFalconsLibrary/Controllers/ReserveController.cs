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
    public class ReserveController : ControllerBase
    {
        private readonly AppDbContext context;
        public ReserveController(AppDbContext context)
        {
            this.context = context;

        }

        // Read

        [HttpGet("reserveList")]

        public IEnumerable<Reserve> Get()
        {
            return context.Reserve.ToList();
        }

        // Read

        [HttpGet("reserveByID")]
        public Reserve Get(Int32 id)
        {
            var reserve = context.Reserve.FirstOrDefault(p => p.Reserve_ID == id);
            return reserve;
        }

        // Create

        [HttpPost("createReserve")]

        public ActionResult Post([FromBody] Reserve reserve)
        {
            try
            {
                context.Reserve.Add(reserve);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }


        // Update

        [HttpPut("updateReserve")]
        public ActionResult Put(Int32 id, [FromBody] Reserve reserve)
        {
            try
            {
                if (reserve.Reserve_ID == id)
                {
                    context.Entry(reserve).State = EntityState.Modified;
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

        [HttpDelete("deleteReserve")]
        public ActionResult Delete(Int32 id)
        {
            var reserve = context.Reserve.FirstOrDefault(p => p.Reserve_ID == id);
            if (reserve != null)
            {

                context.Reserve.Remove(reserve);
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
