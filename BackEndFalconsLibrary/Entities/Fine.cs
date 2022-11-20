using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BackEndFalconsLibrary.Entities
{
    public class Fine
    {
        [Key]
        public Int32 Fines_ID { get; set; }

        public String? Description { get; set; }

        [NotNull]
        public String Status { get; set; }


    }
}
