//using BackEndFalconsLibrary.Entities;
//using Microsoft.AspNetCore.Mvc;



//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

using BackEndFalconsLibrary.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace BackEndFalconsLibrary.Controllers
{
    public class LoginController : ControllerBase
    {
        public IConfiguration _configuration;
        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;

        }
        public dynamic Login([FromBody] Object loginData)
        {
            var data = JsonConvert. DeserializeObject<dynamic>(loginData.ToString());

            string user = data.usuario.ToString();
            string password = data.password.ToString();

            //User user = context.Falcon_UserList.Where(x => x.user == user && x.password == password).FirstOrDefaul();

            if (user == null)
            {
                return new
                {
                    success = false,
                    message = "Incorrect",
                    result = ""
                };
            }

            var jwt = _configuration.GetSection("Jwt");

            return null;


        }


    }
}





//{
//    [ApiController]
//    [Route("[Controller")]
//    public class LoginController:Controller
//    {
//        public LoginController(User user)
//        {
//            user = user;
//        }

//        [HttpPost]
//        public async Task<IActionResult> Post(Login login)
//        {
//            if(!ModelState.IsValid)
//            {
//                return BadRequest();
//            }

//            User user = await user.Where(x =>x.User == Login.Usuario)
//        }
    
//    }
//}



    