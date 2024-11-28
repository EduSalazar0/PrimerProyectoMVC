using System.ComponentModel.DataAnnotations;

namespace PrimerProyectoMVC.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="El nombre es necesario")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El telefono es necesario")]
        public string Telefono { get; set; }
        [Required(ErrorMessage ="El celular es necesario")]
        public string Celular { get; set; }
        [Required(ErrorMessage ="El email es necesario")]
        public string Email { get; set; }
        public DateTime Fecha { get; set; }
    }
}
