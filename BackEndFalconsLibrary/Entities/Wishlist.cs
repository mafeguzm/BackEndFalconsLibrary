using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BackEndFalconsLibrary.Entities
{
    public class Wishlist
    {
        [Key]

        public Int32 WishlistID { get; set; }
        [NotNull]

        public Int32 BookID { get; set; }
        [NotNull]

        public Int32 User_ID { get; set; }
        [NotNull]

        public Boolean Follow { get; set; }

    }
}
