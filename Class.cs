using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace follows
{
    public class Class
    {
        [Key] 
        public int Id { get; set; }
        [Column ("nombre")]
        public string Name { get; set; }
        [Column ("apellido")]
        public string course { get; set; } 
    }
}
