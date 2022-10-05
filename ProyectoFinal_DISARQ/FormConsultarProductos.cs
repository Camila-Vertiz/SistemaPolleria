using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormConsultarProductos : Form
    {
        public FormConsultarProductos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataSet ds = logProducto.Instancia.ConsultaProductoId(Convert.ToInt32(txtCodigoProducto.Text));
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
        }
    }
}
