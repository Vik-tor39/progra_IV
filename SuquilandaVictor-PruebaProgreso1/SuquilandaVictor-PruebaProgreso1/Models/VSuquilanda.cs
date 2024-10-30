using System.ComponentModel.DataAnnotations;

namespace SuquilandaVictor_PruebaProgreso1.Models
{
    public class VSuquilanda
    {
        [Key]
        public int Id {  get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [Range(0,100)]
        public int Edad { get; set; }
        [Range(0, 100000)]
        public double Fondos { get; set; }
        [EmailAddress]
        public string Correo {  get; set; }
        public Boolean ComproCelular { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [Range (0,10)]
        public int TotalCelulares { get; set; }
    }
}
