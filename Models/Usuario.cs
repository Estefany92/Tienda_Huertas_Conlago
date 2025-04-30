using System.ComponentModel.DataAnnotations;

namespace Tienda_Huertas_Conlago.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        public string Nombre { get; set; }

        public string Identificacion { get; set; }

        public string NumeroTelefonico { get; set; }

        public string Correo { get; set; }

        public int Edad { get; set; }

        // Lista de pedidos realizados por el usuario
        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();

        // Se considera recurrente si tiene más de 3 pedidos
        public bool EsRecurrente
        {
            get
            {
                return Pedidos.Count > 3;
            }
        }
    }
}
