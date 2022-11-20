using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BackEndFalconsLibrary.Entities
{
    public class Book
    {
        [Key]
        public Int32 BookID { get; set; }

        [NotNull]
        public String Book_Name { get; set; }
        [NotNull]
        public String Gender { get; set; }
        [NotNull]
        public String Author { get; set; }
        [NotNull]
        public String Epilogue { get; set; }
        [NotNull]
        public Byte[] IMG { get; set; }

    }
}
