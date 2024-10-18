using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VictorSuquilanda_Taller1.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Range(0, 120)]
        public int Edad { get; set; }
        [MaxLength(100)]
        public string Posicion { get; set; }
        public Equipo Equipo { get; set; }
        [ForeignKey("Equipo")]
        public int IdEquipo { get; set; }
    }
}
