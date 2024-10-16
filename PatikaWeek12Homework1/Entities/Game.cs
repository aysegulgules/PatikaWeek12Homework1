using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatikaWeek12Homework1.Entities
{
    [Table("Games")]
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Platform { get; set; }

        [Required]
        [Column("Rating", TypeName ="decimal(2,2)")]
        [MaxLength(10)]
        [MinLength(0)]        
        public int Rating { get; set; }
    }
}
