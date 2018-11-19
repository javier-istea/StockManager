using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using StockManager.Models;


namespace StockManager.ViewModel
{
    public class PrendaViewModel
    {
        //[Key]
        public int PrendaID { get; set; }

        //[Required(ErrorMessage = "Talle requerido")]
        //[MaxLength(10)]
        public string Talle { get; set; }

        //[Required(ErrorMessage = "Descripcion requerida")]
        //[MaxLength(100)]
        public string Descripcion { get; set; }

        //[Required(ErrorMessage = "Color requerido")]
        //[MaxLength(45)]
        public string Color { get; set; }

        //[Required(ErrorMessage = "Tipo de prenda requerido")]
        //[MaxLength(100)]
        //[Display(Name = "Tipo de prenda")]

        public int TipoDePrendaID { get; set; }

        public IEnumerable<TipoDePrenda> TiposDePrendas { get; set; }

    }
}
