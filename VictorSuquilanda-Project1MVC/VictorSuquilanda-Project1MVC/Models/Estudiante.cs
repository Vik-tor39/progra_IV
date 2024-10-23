using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VictorSuquilanda_Project1MVC.Models
{
    public class Estudiante
    {
        [Key]
        public int Id {  get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Range(0, 120)]
        public int Edad { get; set; }
        public DateTime BornDate { get; set; }
        [EmailAddress]
        public string Correo { get; set; }
        public Carrera Carrera { get; set; }
        [ForeignKey("Carrera")]
        public int IdCarrera { get; set; }
    }
}
