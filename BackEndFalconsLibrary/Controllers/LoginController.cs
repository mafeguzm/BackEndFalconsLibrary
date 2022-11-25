//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Threading.Tasks;
//using BackEndFalconsLibrary.Contexts;
//using BackEndFalconsLibrary.Entities;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace BackEndFalconsLibrary.Controllers
//{
//    [Route("FalconsLibrary/[controller]")]
//    [ApiController]
//    public class LoginController : ControllerBase
//    {
//        private readonly AppDbContext context;
//        public LoginController(AppDbContext context)
//        {
//            this.context = context;

//        }
//        // Read

//        [HttpGet("userList")]
//        public IEnumerable<User> Get()
//        {
//            return context.Falcon_UserList.ToList();
//        }

//        // Read

//        [HttpGet("userByID")]
//        public User Get(Int32 id)
//        {
//            var user = context.Falcon_UserList.FirstOrDefault(p => p.User_ID == id);
//            return user;
//        }


//        // Create

//        [HttpPost("login")]
//        public ActionResult Post([FromBody] String email, [FromBody] String password)
//        {
//            try
//            {
//                var user = context.Falcon_UserList.FirstOrDefault(p => p.Email == email);
//                if (user?.Password == password)
//                {

//                }
//                context.SaveChanges();
//                return Ok();
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.ToString());
//            }

//        }



//        //Update

//        [HttpPut("updateUser")]
//        public ActionResult Put(Int32 id, [FromBody] User user)
//        {
//            if (user.User_ID == id)
//            {
//                context.Entry(user).State = EntityState.Modified;
//                context.SaveChanges();
//                return Ok();
//            }
//            else
//            {
//                return BadRequest();
//            }
//        }



//        //Delete

//        [HttpDelete("deleteUser")]
//        public ActionResult Delete(Int32 id)
//        {
//            var user = context.Falcon_UserList.FirstOrDefault(p => p.User_ID == id);
//            if (user != null)
//            {
//                context.Falcon_UserList.Remove(user);
//                context.SaveChanges();
//                return Ok();
//            }
//            else
//            {
//                return BadRequest();
//            }
//        }
//    }
//}
