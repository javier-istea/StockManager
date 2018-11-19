using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockManager.Models
{
    [Table("Prendas", Schema = "dbo")]
    public class Prenda
    {
        [Key]
        [Display(Name = "Id")]
        public int PrendaID { get; set; }

        [Required(ErrorMessage = "Talle requerido")]
        [MaxLength(10)]
        [Column("Talle")]
        [Display(Name = "Talle")]
        public string Talle { get; set; }

        [Required(ErrorMessage = "Descripcion requerida")]
        [MaxLength(100)]
        [Column("Descripcion")]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Color requerido")]
        [MaxLength(45)]
        [Column("Color")]
        [Display(Name = "Color")]
        public string Color { get; set; }

        [Column("TipoDePrenda")]
        public TipoDePrenda TipoDePrenda { get; set; }
        [Required(ErrorMessage = "Tipo de prenda requerido")]
        [Display(Name = "Tipo de prenda")]
        public int TipoDePrendaID { get; set; }

    }
}
