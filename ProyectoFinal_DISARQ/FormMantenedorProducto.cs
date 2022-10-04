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
            txtNombreProducto.Focus();
            int codigoProducto = Convert.ToInt32(txtCodigoProducto.Text);
            entProducto Pro = logProducto.Instancia.BuscaProductoId(codigoProducto);
            if (Pro != null)
            {

                txtCodigoProducto.Text = Convert.ToString(Pro.codigo_producto);
                txtNombreProducto.Text = Pro.nombre_producto;
                cboCategoria.Text = Pro.categoria_producto;
                txtPrecioUnitario.Text = Convert.ToString(Pro.precio_unitario_producto);
                txtDescripcion.Text = Pro.descripcion_producto;
                MessageBox.Show("Registro Encontrado");
            }
            else
                MessageBox.Show("El Calzado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto p = new entProducto();

                p.codigo_producto = int.Parse(txtCodigoProducto.Text.Trim());
                logProducto.Instancia.EliminaProductos(p);
                MessageBox.Show("Registro eliminado con exito!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listaProducto();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                entProducto p = new entProducto();
                p.codigo_producto = int.Parse(txtCodigoProducto.Text.Trim());
                p.nombre_producto = txtNombreProducto.Text.Trim();
                p.categoria_producto = cboCategoria.Text.Trim();
                p.precio_unitario_producto = float.Parse(txtPrecioUnitario.Text.Trim());
                p.descripcion_producto = txtDescripcion.Text.Trim();
                logProducto.Instancia.EditaProducto(p);
                MessageBox.Show("Registro Modificado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            listaProducto();
        }
    }
}
