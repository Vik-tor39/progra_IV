using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuquilandaVictor_PruebaProgreso1.Models
{
    public class Celular
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Modelo { get; set; }
        [Required]
        [MaxLength(100)]
        public string Fabricando { get; set; }
        public DateTime Anio { get; set; }
        [Range(0,10000)]
        public double Precio { get; set; }
        public VSuquilanda? VSuquilanda { get; set; }
        [ForeignKey("VSuquilanda")]
        public int IdVSuquilanda { get; set;}
    }
}
