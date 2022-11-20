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
    public class CopyController : ControllerBase
    {
        private readonly AppDbContext context;
        public CopyController(AppDbContext context)
        {
            this.context = context;

        }
        // Read

        [HttpGet("copyList")]

        public IEnumerable<Copy> Get()
        {
            return context.Falcon_Copies_List.ToList();
        }

        // Read

        [HttpGet("copyByID")]
        public Copy Get(Int32 id)
        {
            var copy = context.Falcon_Copies_List.FirstOrDefault(p => p.CopyID == id);
            return copy;
        }

        // Create

        [HttpPost("createCopy")]

        public ActionResult Post([FromBody] Copy copy)
        {
            try
            {
                context.Falcon_Copies_List.Add(copy);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }



        //Update

        [HttpPut("updateCopy")]
        public ActionResult Put(Int32 id, [FromBody] Copy copy)
        {
            if (copy.CopyID == id)
            {
                context.Entry(copy).State = EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }



        //Delete

        [HttpDelete("deleteCopy")]
        public ActionResult Delete(Int32 id)
        {
            var copy = context.Falcon_Copies_List.FirstOrDefault(p => p.CopyID == id);
            if (copy != null)
            {
                context.Falcon_Copies_List.Remove(copy);
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
