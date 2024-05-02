using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PruebaProgreso1Espin.Models
{
    public class Carrera
    {

        [Key]

        public int ID { get; set; }
        [Required,StringLength(30)]
        [DisplayNameAttribute("Numero de semestre")]
        public string Nombrecarrera { get; set; }
        [Required]

        public string Campus { get; set; }
        [Required]
        [Range (1,9)]
        public int NumeroSemestre { get; set; }
        [Required]

    }
}