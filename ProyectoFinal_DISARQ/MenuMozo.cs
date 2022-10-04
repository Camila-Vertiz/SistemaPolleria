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
    }
}
