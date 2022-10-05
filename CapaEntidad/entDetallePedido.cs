using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDetallePedido
    {
        public int id_detallePedido { get; set; }
        public int codigo_pedido { get; set; }
        public int cantidad_detallePedido { get; set; }
        public float precioUnitario_detallePedido { get; set; }
        public float subtotal_detallePedido { get; set; }
        public entProducto codigo_producto { get; set; }
        public DateTime fechaCreacion_detallePedido { get; set; }
    }
}
