using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaProgreso1Espin.Models
{
    public class Espin
    {
        [Key]
        private int DNI { get; set; }

        private float? Calificacion  { get; set; }

        [Required]
        private string Nombre { get; set; }

        [Required]
        private bool Ecuatoriano { get; set; }

        [Required]
        private DateTime Nacimiento { get; set; }

        private bool Ecuatoriano;
        private DateTime Nacimiento;
        [Required, ForeignKey("Carrera ID")]

        private int CarreraID { get; set; }
        private Carrera? Carrera { get; set; }
        
    }
}
