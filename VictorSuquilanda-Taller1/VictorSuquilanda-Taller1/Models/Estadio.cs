using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VictorSuquilanda_Taller1.Models
{
    public class Estadio
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Direccion { get; set; }
        [Range(1000, 10000)]
        public int Capacidad { get; set; }
    }
}
