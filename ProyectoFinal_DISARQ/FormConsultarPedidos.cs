using CapaEntidad;
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
    public partial class FormConsultarPedidos : Form
    {
        public FormConsultarPedidos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigoPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarDocumento_Click(object sender, EventArgs e)
        {
            entPedido oPedido = new logPedido().ObtenerPedido(txtNDocu.Text);
            if(oPedido.codigo_pedido != 0)
            {
                txtNDocu2.Text = oPedido.numeroComprobante_pedido;
                //txtFecha.Text = Convert.ToDateTime(oPedido.fechaCreacion_pedido);
            }
        }
    }
}
