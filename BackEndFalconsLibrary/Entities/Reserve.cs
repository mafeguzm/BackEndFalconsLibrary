using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BackEndFalconsLibrary.Entities
{
    public class Reserve
    {
        [Key]
        public Int32 Reserve_ID { get; set; }
        [NotNull]
        public Int32 BookID { get; set; }
        [NotNull]
        public Int32 User_ID { get; set; }
        [NotNull]
        public DateTime Perd_Start { get; set; }
        [NotNull]
        public DateTime Perd_End { get; set; }


    }
}
