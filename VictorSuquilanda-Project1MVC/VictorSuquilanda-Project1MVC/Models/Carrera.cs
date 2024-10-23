using System.ComponentModel.DataAnnotations;

namespace VictorSuquilanda_Project1MVC.Models
{
    public class Carrera
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [Range(1, 5)]
        public int Anios { get; set; }
    }
}
