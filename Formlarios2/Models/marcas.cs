using System.ComponentModel.DataAnnotations;

namespace Formlarios2.Models
{
    public class marcas
    {
        [Key]
        [Display(Name ="ID")]
        
        public int Id_marcas { get; set; }
        [Display(Name ="Nombre de la marca")]
        public string? nombre_marca { get; set; }

        [Display(Name ="Estado")]
        public string? estados { set; get; }
    }
}
