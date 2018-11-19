using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace StockManager.ViewModel
{
    public class TipoDePrendaViewModel
    {
        public int TipoDePrendaId { get; set; }
        public string Descripcion { get; set; }
    }
}