using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VictorSuquilanda_Project2MVC.Models
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]        
        public string Name { get; set; }
        [EmailAddress]
        public string Correo { get; set; }
        public Carrera? Carrera { get; set; }
        [ForeignKey("Carrera")]
        public int IdCarrera { get; set; }
    }
}
