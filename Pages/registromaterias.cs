using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace follows
{
    public class registromaterias
    {
        [Key]
        public int Id { get; set; }
        [Column("la tabla joaquin")]
        public string Nota{ get; set; }
        [Column("la tabla joaquinx2")]
        public string Materia { get; set; }
    }
}
