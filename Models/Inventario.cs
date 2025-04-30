using System.ComponentModel.DataAnnotations;

namespace Tienda_Huertas_Conlago.Models
{
    public class Inventario
    {
        [Key]
        public int InventarioId { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }

        // Estado calculado automáticamente según la cantidad
        public string Estado
        {
            get
            {
                return Cantidad < 1 ? "Agotado" : "Disponible";
            }
        }
    }
}
