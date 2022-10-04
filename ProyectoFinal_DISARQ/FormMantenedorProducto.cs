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
    public partial class FormMantenedorProducto : Form
    {
        public FormMantenedorProducto()
        {
            InitializeComponent();
            listaProducto();
        }
        public void listaProducto()
        {
            DataSet ds = logProducto.Instancia.ListarProducto();
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto m = new entProducto();
                m.nombre_producto = txtNombreProducto.Text.Trim();
                m.categoria_producto = cboCategoria.Text.Trim();
                m.precio_unitario_producto = float.Parse(txtPrecioUnitario.Text.Trim());
                m.descripcion_producto = txtDescripcion.Text.Trim();
                logProducto.Instancia.InsertaProducto(m);
                MessageBox.Show("Registro agregado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listaProducto();
        }
    }
}
