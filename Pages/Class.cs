using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace follows
{
    public class docentes
    {
        [Key]
        public int Id { get; set; }
        [Column("la tabla joaquin")]
        public string Name { get; set; }
        [Column("la tabla joaquinx2")]
        public string course { get; set; }

    }
}
