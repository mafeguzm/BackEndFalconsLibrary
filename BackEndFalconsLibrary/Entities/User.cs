using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace BackEndFalconsLibrary.Entities
{
    public class User
    {
        [Key]
        public Int32 User_ID { get; set; }

        [NotNull]
        public String User_Name { get; set; }
        [NotNull]
        public String F_LastName { get; set; }
        public String? S_LastName { get; set; }
        [NotNull]
        public String Email { get; set; }
        [NotNull]
        public Byte[] Password { get; set; }
        [NotNull]
        public String Role { get; set; }

        //[Compare("Password", ErrorMessage = "Passwords do not match.")]
        //[NotMapped]
        //public string ConfirmPassword { get; set; }



    }
}
