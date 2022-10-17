using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProducto
    {
        public int codigo_producto { get; set; }
        public string nombre_producto { get; set; }
        public string categoria_producto { get; set; }
        public float precio_unitario_producto { get; set; }
        public string descripcion_producto { get; set; }
        public int stock_producto { get; set; }
    }
}
