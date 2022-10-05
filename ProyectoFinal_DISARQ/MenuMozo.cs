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
    public partial class MenuMozo : Form
    {
        public MenuMozo()
        {
            InitializeComponent();
            DataSet ds = logProducto.Instancia.ListarProducto();
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
            formatoDGV();
        }
        void formatoDGV()
        {
            dgvProducto.Columns[0].Width = 50;
            dgvProducto.Columns[0].HeaderText = "Cod.";
            dgvProducto.Columns[1].Width = 300;
            dgvProducto.Columns[1].HeaderText = "Producto";
            dgvProducto.Columns[2].Width = 70;
            dgvProducto.Columns[2].HeaderText = "P. Unitario";
            dgvProducto.Columns[3].Width = 400;
            dgvProducto.Columns[3].HeaderText = "Descripcion";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtBuscarProductos.Text == "Buscar...")
            {
                txtBuscarProductos.Text = "";
                txtBuscarProductos.ForeColor = Color.Black;
            }
        }

        private void txtBuscarProductos_Leave(object sender, EventArgs e)
        {
            if (txtBuscarProductos.Text == "")
            {
                txtBuscarProductos.Text = "Buscar...";
                txtBuscarProductos.ForeColor = Color.DimGray;

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtMostrarMesa.Text = "";
        }

        private void MenuMozo_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMesa1_Click(object sender, EventArgs e)
        {
            txtMostrarMesa.Text = "1";
        }

        private void btnMesa2_Click(object sender, EventArgs e)
        {
            txtMostrarMesa.Text = "2";
        }

        private void btnMesa3_Click(object sender, EventArgs e)
        {
            txtMostrarMesa.Text = "3";
        }

        private void btnBrasa_Click(object sender, EventArgs e)
        {
            DataSet ds = logProducto.Instancia.BuscaProducto("Brasa");
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            DataSet ds = logProducto.Instancia.ListarProducto();
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
        }

        private void btnParrilla_Click(object sender, EventArgs e)
        {
            DataSet ds = logProducto.Instancia.BuscaProducto("Parrilla");
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
        }

        private void btnAlaCarta_Click(object sender, EventArgs e)
        {
            DataSet ds = logProducto.Instancia.BuscaProducto("Carta");
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
        }

        private void btnBroaster_Click(object sender, EventArgs e)
        {
            DataSet ds = logProducto.Instancia.BuscaProducto("Broaster");
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
        }

        private void btnBurger_Click(object sender, EventArgs e)
        {
            DataSet ds = logProducto.Instancia.BuscaProducto("Burger");
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
        }

        private void btnComplementos_Click(object sender, EventArgs e)
        {
            DataSet ds = logProducto.Instancia.BuscaProducto("Complementos");
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
        }

        private void btnEnsaladas_Click(object sender, EventArgs e)
        {
            DataSet ds = logProducto.Instancia.BuscaProducto("Ensaladas");
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
        }

        private void btnGaseosas_Click(object sender, EventArgs e)
        {
            DataSet ds = logProducto.Instancia.BuscaProducto("Gaseosas");
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
        }

        private void btnCervezas_Click(object sender, EventArgs e)
        {
            DataSet ds = logProducto.Instancia.BuscaProducto("Cervezas");
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
        }

        private void btnPostres_Click(object sender, EventArgs e)
        {
            DataSet ds = logProducto.Instancia.BuscaProducto("Postres");
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
        }

        private void txtBuscarProductos_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = logProducto.Instancia.BuscaNombreProducto(txtBuscarProductos.Text.Trim());
            dgvProducto.DataSource = ds;
            dgvProducto.DataMember = "Producto";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //txtNPersonas.Focus();
            //if (!txtNPersonas.Text.Equals(""))
            //{
            //    int cant = Convert.ToInt32(txtNPersonas.Text);
            //    entMesas m = logMesas.Instancia.BuscarCapacidadMesas(cant);
            //    if(m != null)
            //    {
            //        if(m.capacidad_mesa)
            //    }
            //}
            //else
            //    MessageBox.Show("Ingrese un valor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void txtNPersonas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProducto.Rows[e.RowIndex]; //
            txtProductoSelec.Text = filaActual.Cells[1].Value.ToString();
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
