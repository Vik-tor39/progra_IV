using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace VictorSuquilanda_Project1MVC.Models
{
    public class EstudianteUdla
    {
        public string IdBanner { get; set; }
        [AllowNull]
        [Required]
        [MaxLength(50)]
        public string? Nombre { get; set; }  // Al emplar '?' junto con [AllowNull] le permitimos a este dato tener valor Null  
        public string Correo { get; set; }
        public Carrera Carrera { get; set; }
    }
}
