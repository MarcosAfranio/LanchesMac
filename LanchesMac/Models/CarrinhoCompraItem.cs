using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace LanchesMac.Models
{
    [Table("CarrinhoCompraItems")]
    public class CarrinhoCompraItem
    {
        public int CarrinhoCompraItemid { get; set; }
        public Lanche Lanche { get; set; }
        public int Quantidade { get; set; }
        [StringLength(200)]
        public string CarrinhoCompraId { get; set; }

    }
}
