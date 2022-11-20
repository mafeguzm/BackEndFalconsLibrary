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
    public class BookController : ControllerBase
    {
        private readonly AppDbContext context;
        public BookController(AppDbContext context)
        {
            this.context = context;

        }

        // Read

        [HttpGet("bookList")]
        public IEnumerable<Book> Get()
        {
            return context.Books_List.ToList();
        }

        // Read

        [HttpGet("bookByID")]
        public Book Get(Int32 id)
        {
            var book = context.Books_List.FirstOrDefault(p=> p.BookID == id);
            return book;
        }

        // Create

        [HttpPost("createUser")]

        public ActionResult Post([FromBody] Book book)
        {
            try
            {
                context.Books_List.Add(book);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }


        //Update

        [HttpPut("updateBook")]
        public ActionResult Put(Int32 id, [FromBody] Book book)
        {
            if (book.BookID == id)
            {
                context.Entry(book).State = EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        // Delete

        [HttpDelete("deleteBook")]
        public ActionResult Delete(Int32 id)
        {
            var book=context.Books_List.FirstOrDefault(p=>p.BookID == id);
            if(book != null)
            {
                context.Books_List.Remove(book);
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
