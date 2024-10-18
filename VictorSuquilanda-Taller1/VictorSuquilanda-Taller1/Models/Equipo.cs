using Microsoft.AspNetCore.Routing.Constraints;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VictorSuquilanda_Taller1.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Ciudad { get; set; }
        [Range(0, 120)]
        public int Titulos { get; set; }
        [Required]
        public Boolean AceptaExtranjeros {  get; set; }
        public Estadio Estadio { get; set; }
        [ForeignKey("Estadio")]
        public int IdEstadio { get; set; }
    }
}
