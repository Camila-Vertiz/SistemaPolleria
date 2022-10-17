using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPedido
    {
        public int codigo_pedido { get; set; }
        public entMesas oMesa { get; set; }
        public entUsuario oUsuario { get; set; }
        public entCliente oCliente { get; set; }
        public string nombre_cliente { get; set; }
        public string tipoComprobante_pedido { get; set; }
        public string numeroComprobante_pedido { get; set; }
        public float montoPago_pedido { get; set; }
        public float montoCambio_pedido { get; set; }
        public float montoTotal_pedido { get; set; }
        public string estado_pedido { get; set; }
        public DateTime fechaCreacion_pedido { get; set; }
        public List<entDetallePedido> oDetallePedido { get; set; }
    }
}
