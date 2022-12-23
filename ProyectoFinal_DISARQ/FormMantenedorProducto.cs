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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CapaPresentacion
{
    public partial class FormMantenedorProducto : Form
    {
        public FormMantenedorProducto()
        {
            InitializeComponent();
            listaProducto();
            txtCodigoProducto.Enabled = false;
        }
        public void listaProducto()
        {
            DataSet ds = logProducto.Instancia.ListarProductoConCategoria();
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
            formatoDGVProducto();
        }
        private void formatoDGVProducto()
        {
            dgvProducto.Columns[0].Width = 50;
            dgvProducto.Columns[0].HeaderText = "Cod.";
            dgvProducto.Columns[1].Width = 300;
            dgvProducto.Columns[1].HeaderText = "Producto";
            dgvProducto.Columns[2].Width = 200;
            dgvProducto.Columns[2].HeaderText = "Categoria";
            dgvProducto.Columns[3].Width = 70;
            dgvProducto.Columns[3].HeaderText = "P. Unitario";
            dgvProducto.Columns[4].Width = 70;
            dgvProducto.Columns[4].HeaderText = "Stock";
            dgvProducto.Columns[5].Width = 200;
            dgvProducto.Columns[5].HeaderText = "Descripcion";
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto m = new entProducto();
                m.nombre_producto = txtNombreProducto.Text.Trim();
                m.categoria_producto = cboCategoria.Text.Trim();
                m.precio_unitario_producto = float.Parse(txtPrecioUnitario.Text.Trim());
                m.stock_producto = int.Parse(txtStock.Text.Trim());
                m.descripcion_producto = txtDescripcion.Text.Trim();
                logProducto.Instancia.InsertaProducto(m);
                MessageBox.Show("Registro agregado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            listaProducto();
            dgvProducto.Enabled = true;
            LimpiarVariabes();

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
            LimpiarVariabes();
            dgvProducto.Enabled = true;
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
                p.stock_producto = int.Parse(txtStock.Text.Trim());
                p.descripcion_producto = txtDescripcion.Text.Trim();
                logProducto.Instancia.EditaProducto(p);
                MessageBox.Show("Registro Modificado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            listaProducto();
            LimpiarVariabes();
            dgvProducto.Enabled = true;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listaProducto();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBoxProducto.Enabled = true;
            btnRegistrar.Visible = true;
            btnModificar.Visible = false;
            LimpiarVariabes();
            txtCodigoProducto.Enabled = false;
            dgvProducto.Enabled = false;
        }
        private void LimpiarVariabes()
        {
            txtCodigoProducto.ResetText();
            txtDescripcion.ResetText();
            txtNombreProducto.ResetText();
            txtPrecioUnitario.ResetText();
            txtStock.ResetText();
            cboCategoria.ResetText();
        }

        private void btnEditarMesa_Click(object sender, EventArgs e)
        {
            groupBoxProducto.Enabled = true;
            btnModificar.Visible = true;
            btnRegistrar.Visible = false;
            dgvProducto.Enabled = true;
            txtCodigoProducto.Enabled = false;
        }

        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProducto.Rows[e.RowIndex];
            txtCodigoProducto.Text = filaActual.Cells[0].Value.ToString();
            txtNombreProducto.Text = filaActual.Cells[1].Value.ToString();
            cboCategoria.Text = filaActual.Cells[2].Value.ToString();
            txtPrecioUnitario.Text = filaActual.Cells[3].Value.ToString();
            txtStock.Text = filaActual.Cells[4].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[5].Value.ToString();
        }

        private void btnBuscar_Click_2(object sender, EventArgs e)
        {
            if (cboTipoB.Text == "Nombre" && (!txtBus.Text.Trim().Equals("")))
            {
                DataSet ds = logProducto.Instancia.BuscaNombreProducto(txtBus.Text.Trim());
                dgvProducto.DataSource = ds;
                dgvProducto.DataMember = "Producto";
            }
            else if (cboTipoB.Text == "Categoria" && (!txtBus.Text.Trim().Equals("")))
            {
                DataSet ds = logProducto.Instancia.BuscaProductoConCategoria(txtBus.Text.Trim());
                dgvProducto.DataSource = ds;
                dgvProducto.DataMember = "Producto";
            }
            formatoDGVProducto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = logProducto.Instancia.ListarProductoConCategoria();
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
            formatoDGVProducto();
        }
    }
}
