using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tienda_Huertas_Conlago.Models
{
    public class Pedido
    {
        [Key]
        public int PedidoId { get; set; }

        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario? Usuario { get; set; }

        public DateTime FechaPedido { get; set; }


    }
}
