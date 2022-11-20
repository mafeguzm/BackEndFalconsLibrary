using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BackEndFalconsLibrary.Entities
{
    public class Copy
    {
        [Key]
        public Int32 CopyID { get; set; }
        [NotNull]
        public Int32 BookID { get; set; }

    }
}
