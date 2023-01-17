
using System.ComponentModel.DataAnnotations;

namespace SystemaInventario.Modelos
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name= "Descripcion")]
        public string Descripcion { get; set; }

        public bool Estado { get; set; }

    }
}
