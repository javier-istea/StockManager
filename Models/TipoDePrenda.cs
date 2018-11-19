using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Models
{
    [Table("TipsoDePrendas", Schema = "dbo")]
    public class TipoDePrenda
    {
        [Key]
        [Display(Name = "Id")]
        public int TipoDePrendaId { get; set; }
        
        [Required(ErrorMessage = "Descripcion Requerida")]
        [MaxLength(100)]
        [Column("Descripcion")]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }

    }
}