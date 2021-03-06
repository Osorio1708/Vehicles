using System.ComponentModel.DataAnnotations;

namespace Vehicles.API.Data.Entities
{
    public class Procedure
    {
        public int Id { get; set; }

        [Display(Name = "Procedimiento")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatiorio.")]
        public string Description { get; set; }

        [Display(Name = "Precio")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Required(ErrorMessage = "El campo {0} es obligatiorio.")]
        public decimal Price { get; set; }
    }
}
