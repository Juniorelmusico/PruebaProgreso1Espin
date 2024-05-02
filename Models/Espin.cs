using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaProgreso1Espin.Models
{
    public class Espin
    {
        [Key]
        private int DNI();

        private float? Calificacion;

        [Required]
        private string Nombre;

        private bool Ecuatoriano;
        private DateTime Nacimiento;
        [Required, ForeignKey("Carrera ID")]

        private int CarreraID;
        private Carrera? Carrera;
        
    }
}
