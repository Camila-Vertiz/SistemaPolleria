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
        public entMesas mesa { get; set; }
        public entUsuario usuario { get; set; }
        public entCliente cliente { get; set; }
        public string numeroDocumento_cliente { get; set; }
        public string nombre_cliente { get; set; }
        public string tipoComprobante_pedido { get; set; }
	    public string numeroComprobante_pedido { get; set; }
        public float montoPago_pedido { get; set; }
        public float montoCambio_pedido { get; set; }
        public float montoTotal_pedido { get; set; }
        public char estado_pedido { get; set; }
        public DateTime fechaCreacion_pedido { get; set; }
        public List<entDetallePedido> detallePedido { get; set; }
    }
}
