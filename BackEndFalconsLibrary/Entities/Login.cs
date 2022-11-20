using System.ComponentModel.DataAnnotations;

namespace BackEndFalconsLibrary.Entities
{
    public class Login
    {
        [Required(ErrorMessage = "The user is required")]
        public string User { get; set; }
        [Required(ErrorMessage = "The password is required")]
        public string Password { get; set; }

    }
}
