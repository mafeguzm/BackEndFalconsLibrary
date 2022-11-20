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
    public class FineController : ControllerBase
    {
        private readonly AppDbContext context;
        public FineController(AppDbContext context)
        {
            this.context = context;

        }

        // Read

        [HttpGet("fineList")]

        public IEnumerable<Fine> Get()
        {
            return context.Fines_List.ToList();
        }

        // Read

        [HttpGet("fineListByID")]
        public Fine Get(Int32 id)
        {
            var fine = context.Fines_List.FirstOrDefault(p => p.Fines_ID == id);
            return fine;
        }

        // Create

        [HttpPost("createFine")]

        public ActionResult Post([FromBody] Fine fine)
        {
            try
            {
                context.Fines_List.Add(fine);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }


        // Update

        [HttpPut("updateFine")]
        public ActionResult Put(Int32 id, [FromBody] Fine fine)
        {
            if (fine.Fines_ID == id)
            {
                context.Entry(fine).State = EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        // Delete

        [HttpDelete("deleteFine")]
        public ActionResult Delete(Int32 id)
        {
            var fine = context.Fines_List.FirstOrDefault(p => p.Fines_ID == id);
            if (fine != null)
            {
                context.Fines_List.Remove(fine);
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
